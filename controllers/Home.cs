using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cSharp2022.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.IO;
using cSharp2022.Extensions;

namespace cSharp2022
{
    public class HomeController : Controller
    {
        private readonly MuhContext _context;

        public HomeController(MuhContext context)
        {
            _context = context;
        }

        [HttpGet("/")]
        public ViewResult Land()
        {
            return View("Landing");
        }

        [HttpGet("/tracks")]
        public ViewResult Dash()
        {
            List<Recordis> AllRecs = _context.Recs
                .Include(c => c.Comments)
                .Include(v => v.Aversions)
                .Include(g => g.Gears)
                .ThenInclude(con => con.Gear)
                .ToList();
            return View("Dashboard", AllRecs); //i did not specify index since it will find it anyhow via line 24
        }

        [HttpGet("/track/comments/{recId}")]
        public JsonResult RetrieveComments(int recId)
        {
            // Retrieve the track with its comments, if it exists
            var theTrack = _context.Recs
                .Include(c => c.Comments)
                .FirstOrDefault(t => t.RecordisId == recId);

            // Check if the track exists
            if (theTrack == null)
            {
                return Json(new List<Comment>()); // Return an empty list if no track found
            }

            // Retrieve comments for the track
            var coms = theTrack.Comments ?? new List<Comment>();

            // Store the comments in session if not already set
            if (HttpContext.Session.GetObjectFromJson<List<Comment>>("Thoughts") == null)
            {
                HttpContext.Session.SetObjectAsJson("Thoughts", coms);
            }

            // Return comments as JSON
            return Json(coms);
        }


        [HttpGet("track/{recId}")]
        public ViewResult TrackDetails(int recId)
        {
            Recordis theTrack = _context.Recs
                .Include(r => r.Gears)
                .ThenInclude(con => con.Gear)
                .Include(r => r.Comments)
                .Include(v => v.Aversions)
                .FirstOrDefault(t => t.RecordisId == recId);
            return View("TrackDetails", theTrack); //i did not specify index since it will find it anyhow via line 24
        }

        [HttpGet("new-track")]
        public IActionResult DisplayNewRecForm()
        {
            return View("AddRecForm");
        }

        [HttpGet("/edit/track/add-version/{recId:int}")]
        public IActionResult DisplayAddVersionForm(int recId)
        {
            ViewBag.RecordisId = recId;
            return View("AddVForm");
        }

        [HttpPost("/edit/track/post-version/{recId:int}")]
        public async Task<IActionResult> SubmitAversion(Aversion fromForm, IFormFile uploadFile, int recId)
        {
            var folderName = _context.Recs.First(t => t.RecordisId == recId);
            if (uploadFile != null && uploadFile.Length > 0)
            {
                var fileName = Path.GetFileName(uploadFile.FileName);
                var trackNameDir = $"wwwroot/audio/{@folderName.title}";
                if (!Directory.Exists(trackNameDir))
                {
                    Directory.CreateDirectory(trackNameDir);
                }

                var filePath =
                    Path.Combine(Directory.GetCurrentDirectory(), trackNameDir,
                        fileName); //get a path of file for playback

                using (var fileSrteam = new FileStream(filePath, FileMode.Create))
                {
                    await uploadFile.CopyToAsync(fileSrteam);
                }

                string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };

                string FormatSize(Int64 bytes)
                {
                    int counter = 0;
                    decimal number = (decimal)bytes;
                    while (Math.Round(number / 1024) >= 1)
                    {
                        number /= 1024;
                        counter++;
                    }

                    return $"{number:n1}{suffixes[counter]}"; //do not use String.format
                }

                string size = FormatSize(uploadFile.Length);
                fromForm.Length = size;
                fromForm.MediaFilePath = filePath;
                fromForm.RecordisId = recId;
                fromForm.Title = fileName;
                _context.Add(fromForm);
                await _context.SaveChangesAsync();
                return RedirectToAction("TrackDetails", new { recId });
            }

            return View("Dashboard");
        }

        // ########################VERSION###################
        [HttpGet("version/delete/{trackId}/{vId}/")]
        public IActionResult DeleteVersion(int trackId, int vId)
        {
            var target = _context.Aversions
                .FirstOrDefault(t => t.AversionId == vId);
            if (target != null) _context.Remove((object)target);
            _context.SaveChanges();
            return RedirectToAction("TrackDetails", new { recId = trackId });
        }

        [HttpPost("/associate2/{trackId:int}/")]
        public IActionResult ConnectTool(Connect FromForm, int trackId)
        {
            var ToolsUsedOnTrack = _context.Connects
                .Include(con => con.Recordis)
                .Where(g => g.RecordisId == trackId);

            if (ToolsUsedOnTrack.Any(x => x.GearId == FromForm.GearId))
            {
                return NotFound(" Duplicate Entry");
            }

            if (ModelState.IsValid) //bs here
            {
                FromForm.RecordisId = trackId; // BRINGING from asp-route, part of fromForm or u can use hidden input
                _context.Add(FromForm);
                _context.SaveChanges();
                return RedirectToAction("TrackDetails",
                    new { recId = trackId }); //error if View, why assign id like this?
            }

            return View("TrackInfo", new { recId = trackId });
        }

        [HttpGet("delete/{trackId}/{connectId}")] //deletes tool assignments
        public IActionResult DeleteConnect(int connectId, int trackId)
        {
            var x = _context.Connects.FirstOrDefault(c => c.ConnectId == connectId);
            _context.Remove(x);
            _context.SaveChanges();

            return RedirectToAction("TrackDetails", new { recId = trackId });
        }

        [HttpGet("/delete/track/{trackId}")]
        public async Task<IActionResult> DeleteTrack(int trackId)
        {
            // Retrieve the track and its related aversions
            var track = await _context.Recs
                .Include(t => t.Aversions)
                .FirstOrDefaultAsync(t => t.RecordisId == trackId);

            if (track == null)
            {
                return NotFound($"Track with ID {trackId} not found.");
            }

            // Remove all related Aversions
            foreach (var aversion in track.Aversions.ToList())
            {
                _context.Aversions.Remove(aversion);
            }

            // Remove the track
            _context.Recs.Remove(track);

            try
            {
                // Save changes asynchronously
                await _context.SaveChangesAsync();

                // Delete the media file if it exists
                if (System.IO.File.Exists(track.MediaFilePath))
                {
                    System.IO.File.Delete(track.MediaFilePath);
                }

                // Get the parent directory path
                var dirPath = Path.GetDirectoryName(track.MediaFilePath);
                if (dirPath != null && Directory.Exists(dirPath))
                {
                    Directory.Delete(dirPath, true); // true to delete recursively
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error during deletion: {e.Message}");
                return StatusCode(500, "An error occurred while deleting the track.");
            }

            return RedirectToAction("Dash");
        }


        [HttpGet("track/play/{trackId}")]
        public IActionResult EntryOpen(string trackName, int trackId)
        {
            var target = _context.Recs.FirstOrDefault(s => s.RecordisId == trackId);
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = @target.MediaFilePath,
                UseShellExecute = true
            };
            Process.Start(psi);
            return RedirectToAction("TrackDetails", new { recId = trackId });
        }

        [HttpGet("{recId}/comment")]
        public IActionResult DisplayNewCommentForm()
        {
            // ViewBag.AllGears = _context.Gears.ToList();
            return View("FormComment");
        }

        [HttpPost("{recId}/post")] //if missing, razor will look for a "form route" "/new-tool-form/" like above
        public IActionResult PostComment(Comment FromForm, int recId) //we create new entry in table based on the model 
            // create1 is used in the form asp-action
        {
            if (ModelState.IsValid)
            {
                FromForm.RecordisId = recId;
                _context.Add(FromForm);
                _context.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("TrackDetails", new { recId });
                //using overload (Home) so it redirects OK
                // https://stackoverflow.com/questions/7892094/how-to-redirect-to-index-from-another-controller
            }
            else
            {
                return View("FormComment");
            }
        }

        [HttpPost("add-track")]
        [RequestSizeLimit(100_000_000)]
        public async Task<IActionResult>
            SubmitTrack(Recordis FromForm, IFormFile uploadFile) //we create new entry in table based on the model 
            // submitTrack was named "IndexAsync" before stack
        {
            // f.Tag.Album = "New Album Title";
            // f.Save();
            if (uploadFile != null && uploadFile.Length > 0)
            {
                var fileName = Path.GetFileName(uploadFile.FileName);
                FromForm.title ??= fileName;
                var folderName = FromForm.title; //to create  folder named after track
                var trackNameDir = $"wwwroot/audio/{@folderName}"; //to be used as a wrapper

                var filePath =
                    Path.Combine(Directory.GetCurrentDirectory(), trackNameDir, fileName); //path to upload file to
                FromForm.MediaFilePath = filePath;
                FromForm.fileName = uploadFile.FileName;
                // TagLib.File f = TagLib.File.Create(uploadFile.FileName);
                FromForm.artist ??= "Dude";
                // if (FromForm.title == null) FromForm.title = fileName;

                FromForm.desc ??= "bluh bluh bluh";
                if (!Directory.Exists(trackNameDir))
                {
                    Directory.CreateDirectory(trackNameDir);
                }

                // https://www.c-sharpcorner.com/article/csharp-convert-bytes-to-kb-mb-gb/
                string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };

                string FormatSize(Int64 bytes)
                {
                    int counter = 0;
                    decimal number = (decimal)bytes;
                    while (Math.Round(number / 1024) >= 1)
                    {
                        number /= 1024;
                        counter++;
                    }

                    return string.Format("{0:n1}{1}", number, suffixes[counter]);
                }

                string size = FormatSize(uploadFile.Length);
                FromForm.length = size;

                using (var fileSrteam = new FileStream(filePath, FileMode.Create))

                {
                    await uploadFile.CopyToAsync(fileSrteam);
                }

                _context.Recs.Add(FromForm);
                _context.SaveChanges();
                return RedirectToAction("Dash");
            }

            return NotFound("Did not post");
        }

        [HttpGet("/dummy/")]
        public IActionResult Dummy()
        {
            return View("dummy");
        }

        [HttpGet("/edit/track/{recId}/")]
        public IActionResult DisplayEditTrackForm(int recId)
        {
            if (!_context.Recs.Any(d => d.RecordisId == recId))
            {
                return RedirectToAction("Dash");
            }

            FormWrapper theRec = new FormWrapper
            {
                RecForm = _context.Recs.FirstOrDefault(i => i.RecordisId == recId)
            };

            ViewBag.AllGear = _context.Gears.ToList();
            ViewBag.theSong = _context.Recs.FirstOrDefault(p => p.RecordisId == recId);
            ViewBag.UsedConnects = _context.Connects;
            return View("EditTrack", theRec);
        }

        [HttpPost("update/rec/{id:int}")]
        public IActionResult UpdateRec(int id, Recordis fromForm)
        {
            if (ModelState.IsValid)
            {
                var x = _context.Recs.Where(t => t.RecordisId == id).AsNoTracking().FirstOrDefault();
                fromForm.RecordisId = id;
                string fileName = fromForm.fileName;
                string[] cut = fromForm.MediaFilePath.Split("audio");
                string[] f = cut[1].Split(@fileName);
                string fN = fromForm.title;
                fromForm.CreatedAt = x.CreatedAt; //for now
                // string updatedPath = FromForm.MediaFilePath.Replace(f[0], "/" + fN + "/"); //update path for playback
                // FromForm.MediaFilePath = updatedPath;
                System.Console.WriteLine(_context.Entry(fromForm).Property("CreatedAt").IsModified); //already false
                _context.Update(fromForm);
                _context.SaveChanges();
                // var path = $"wwwroot\\audio{f[0]}";
                // if (x.title != FromForm.title)
                // {
                //     Directory.Move(@Url.Content($"wwwroot//audio{f[0]}"), @Url.Content($"wwwroot\\audio\\{FromForm.title}"));
                // }
                return RedirectToAction("TrackDetails", new { recId = id });
            }
            else
            {
                return RedirectToAction("EditTrack");
            }
        }

        [HttpGet("/tool/delete/{recordID:int}/{comId:int}/")]
        public IActionResult DeleteComment(int comId, int recordId)
        {
            var x = _context.Comments.First(t => t.CommentId == comId);
            _context.Remove(x);
            _context.SaveChanges();

            return RedirectToAction("TrackDetails", new { recId = recordId });
        }

        //experimental
        [HttpGet("convert/{fileName}")]
        public async Task<IActionResult> MciConvertWavMP3(string fileName, bool waitFlag)
        {
            string pworkingDir = "wwwroot/lamecli/";
            string wavFilePath = Path.Combine(pworkingDir, fileName);
            string mp3FilePath = Path.Combine(pworkingDir, fileName.Replace(".wav", ".mp3"));

            // Check if the WAV file exists
            if (!System.IO.File.Exists(wavFilePath))
            {
                return NotFound($"The file {fileName} does not exist.");
            }

            // Prepare the arguments for the conversion
            string outfile = $"-b 32 --resample 22.05 -m m \"{wavFilePath}\" \"{mp3FilePath}\"";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = Path.Combine(pworkingDir, "lame.exe"),
                Arguments = outfile,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            try
            {
                // Start the conversion process
                using (var process = new System.Diagnostics.Process { StartInfo = psi })
                {
                    process.Start();

                    if (waitFlag)
                    {
                        // Wait for the process to exit asynchronously
                        await Task.Run(() => process.WaitForExit());
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error (consider using a logging framework)
                Console.WriteLine($"Error during conversion: {ex.Message}");
                return StatusCode(500, "An error occurred during the conversion process.");
            }

            return Ok($"Conversion successful. Output file: {mp3FilePath}");
        }
    }
}
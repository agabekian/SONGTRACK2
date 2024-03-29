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
            Recordis TheTrack = _context.Recs
            .Include(c => c.Comments)
            .FirstOrDefault(t => t.RecordisId == recId);

            Comment bubble = HttpContext.Session.GetObjectFromJson<Comment>("Thoughts");

            List<Comment> coms = TheTrack.Comments;
            if (coms == null)
            {
                HttpContext.Session.SetObjectAsJson("Thoughts", coms);
                return Json(coms);
            }
            else
            {
                return Json(coms);
            }

        }

        [HttpGet("track/{recId}")]
        public ViewResult TrackDetails(int recId)
        {
            Recordis TheTrack = _context.Recs
            .Include(r => r.Gears)
            .ThenInclude(con => con.Gear)
            .Include(r => r.Comments)
            .Include(v => v.Aversions)
            .FirstOrDefault(t => t.RecordisId == recId);
            return View("TrackDetails", TheTrack); //i did not specify index since it will find it anyhow via line 24
        }

        [HttpGet("new-track")]
        public IActionResult DisplayNewRecForm()
        {
            return View("AddRecForm");
        }

        [HttpGet("/edit/track/add-version/{recId}")]
        public IActionResult DisplayAddVersionForm(int recId)
        {
            ViewBag.RecordisId = recId;
            return View("AddVForm");
        }

        [HttpPost("/edit/track/post-version/{recId}")]
        public async Task<IActionResult> SubmitAversion(Aversion FromForm, IFormFile uploadFile, int recId)
        {
            var folderName = _context.Recs.Where(t => t.RecordisId == recId).First();
            if (uploadFile != null && uploadFile.Length > 0)
            {
                var fileName = Path.GetFileName(uploadFile.FileName);
                var trackNameDir = $"wwwroot/audio/{@folderName.title}";
                if (!Directory.Exists(trackNameDir))
                {
                    Directory.CreateDirectory(trackNameDir);
                }
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), trackNameDir, fileName);//get a path of file for playback

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
                        number/=1024;
                        counter++;
                    }
                    return string.Format("{0:n1}{1}", number, suffixes[counter]);
                }
                string size = FormatSize(uploadFile.Length);
                FromForm.Length = size;
                FromForm.MediaFilePath = filePath;
                FromForm.RecordisId = recId;
                FromForm.Title = fileName;
                _context.Add(FromForm);
                _context.SaveChanges();
                return RedirectToAction("TrackDetails", new { recId });
            }
            return View("Dashboard");
        }
       
        // ########################VERSION###################
        [HttpGet("version/delete/{trackId}/{vId}/")]
        public IActionResult DeleteVersion(int trackId, int vId)
        {
            var target = _context.Aversions
            .Where(t => t.AversionId == vId)
            .FirstOrDefault();
            _context.Remove(target);
            _context.SaveChanges();
            return RedirectToAction("TrackDetails", new { recId = trackId });
        }

        [HttpPost("/associate2/{trackId}/")]
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
                FromForm.RecordisId = trackId;// BRINIGING from asp-route, part of FromForm or u can use hidden input
                _context.Add(FromForm);
                _context.SaveChanges();
                return RedirectToAction("TrackDetails", new { recId = trackId });//error if View, why assign id like this?
            }
            return View("TrackInfo", new { recId = trackId });
        }

        [HttpGet("delete/{trackId}/{connectId}")] //deletes tool assignments
        public IActionResult DeleteConnect(int connectId, int trackId)
        {
            var x = _context.Connects
            .Where(c => c.ConnectId == connectId).FirstOrDefault();
            _context.Remove(x);
            _context.SaveChanges();
            return RedirectToAction("TrackDetails", new { recId = trackId });
        }

        [HttpGet("/delete/track/{trackId}")]
        public IActionResult DeleteTrack(int trackId)
        {
            var junk = _context.Recs
            .Where(t => t.RecordisId == trackId).FirstOrDefault();

            var related = _context.Recs.Include(v => v.Aversions).SingleOrDefault(r => r.RecordisId == trackId);
            foreach (var entry in related.Aversions.ToList())
            _context.Aversions.Remove(entry); //removes all dependent children ("Aversions" here)
            _context.Remove(junk);
            _context.SaveChanges();

            if (System.IO.File.Exists(junk.MediaFilePath))
            {
                System.IO.File.Delete(junk.MediaFilePath); //delete actual FILE (io)(not moving to trash!!!)
            }
            var dirPath = junk.MediaFilePath.Split(junk.fileName);
    
            try
            {
                Console.WriteLine(dirPath[0]);
                Directory.Delete(dirPath[0]);//clean up -delete parent directory
            }
            catch (Exception e)
            {
                System.Console.WriteLine((e, "The actual file may be already deleted"));
                // throw;
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
        public async Task<IActionResult> SubmitTrack(Recordis FromForm, IFormFile uploadFile) //we create new entry in table based on the model 
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
                
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), trackNameDir, fileName); //path to upload file to
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
            FormWrapper TheRec = new FormWrapper(); //Dont forget to give it some data (below) 3/5/22
            TheRec.RecForm = _context.Recs.FirstOrDefault(i => i.RecordisId == recId);

            ViewBag.AllGear = _context.Gears.ToList();
            ViewBag.theSong = _context.Recs.FirstOrDefault(p => p.RecordisId == recId);
            ViewBag.UsedConnects = _context.Connects;
            return View("EditTrack", TheRec);
        }

        [HttpPost("update/rec/{id}")]
        public IActionResult UpdateRec(int id, Recordis FromForm)
        {
            if (ModelState.IsValid)
            {
                var x = _context.Recs.Where(t => t.RecordisId == id).AsNoTracking().FirstOrDefault();
                FromForm.RecordisId = id;
                string fileName = FromForm.fileName;
                string[] cut = FromForm.MediaFilePath.Split("audio");
                string[] f = cut[1].Split(@fileName);
                string fN = FromForm.title;
                FromForm.CreatedAt = x.CreatedAt; //for now
                // string updatedPath = FromForm.MediaFilePath.Replace(f[0], "/" + fN + "/"); //update path for playback
                // FromForm.MediaFilePath = updatedPath;
                System.Console.WriteLine(_context.Entry(FromForm).Property("CreatedAt").IsModified);//already false
                _context.Update(FromForm);
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

        [HttpGet("/tool/delete/{RecId}/{id}/")]
        public IActionResult DeleteComment(int id, int RecId)
        {
            var x = _context.Comments
            .Where(t => t.CommentId == id).First();
            _context.Remove(x);
            _context.SaveChanges();
            return RedirectToAction("TrackDetails", new { recId = RecId });
        }

        [HttpGet("convert/{fileName}")]
        public void mciConvertWavMP3(string fileName, bool waitFlag)
        {
            string pworkingDir = "wwwroot/lamecli/";
            string outfile = "-b 32 --resample 22.05 -m m \"" + pworkingDir + fileName + "\" \"" + pworkingDir + fileName.Replace(".wav", ".mp3") + "\"";
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            psi.FileName = "\"" + pworkingDir + "lame.exe" + "\"";
            psi.Arguments = outfile;
            psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi);
            if (waitFlag)
            {
                p.WaitForExit();
            }
        }
    }
}
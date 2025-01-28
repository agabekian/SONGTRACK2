using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.IO;
using cSharp2022.Models;


namespace cSharp2022.controllers
{
    public class GearzController : Controller
    {
        private readonly MuhContext _context;
        // "inject" context service into the constructor.
        public GearzController(MuhContext context)
        {
            _context = context;
        }

        [HttpGet("/gear/info/{gearId:int}")]
        public IActionResult GearInfo(int gearId)
        {
            Gear id = _context.Gears
            .Include(g => g.Recs)
            .ThenInclude(con => con.Gear)
            .Include(x => x.Images)
            .ThenInclude(z => z.Image)
            .FirstOrDefault(g => g.GearId == gearId);

            ViewBag.ToolStats = _context.Recs.ToList();
            return View("ToolInfo", id);
        }

        [HttpGet("/tools/")]
        public IActionResult Tools()
        {
            var allTools = _context.Gears.ToList();
            return View(allTools);
        }

        [HttpGet("/new-tool-form/")]
        public IActionResult DisplayNewToolForm()
        {
            return View("AddToolForm");
        }

        [HttpPost("/post-new-tool/")]
        //if missing, razor will look for a "form route" "/new-tool-form/" like above
        public IActionResult PostNewTool(Gear fromForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fromForm);
                _context.SaveChanges();
                return RedirectToAction("Tools");
            }
            else
            {
                return View("AddToolForm");
            }
        }

        [HttpGet("/gear/{gearId}/")]
        public IActionResult DisplayEditGearForm(int gearId)
        {
            Gear retrievedGear = _context.Gears.FirstOrDefault(i => i.GearId == gearId);
            return View("EditGear", retrievedGear);
        }
        
        //basic add form
        [HttpGet("/gear/{gearId}/add-photos")]
        public IActionResult DisplayAddGearPhotosForm()
        {
            return View("AddGearPhotosForm");
        }

        [HttpGet("/gear/{imgId}/delete-photo")]
        public IActionResult DeleteImage(int imgId)
        {
            // Find the image in the database
            var imageToDelete = _context.Images.FirstOrDefault(i => i.Id == imgId);

            // Check if the image exists
            if (imageToDelete == null)
                return NotFound($"Image with ID {imgId} not found.");

            // Retrieve the gearId associated with the image
            var albumEntry = _context.Albums.FirstOrDefault(a => a.ImageId == imgId);
            if (albumEntry == null)
                return NotFound($"No gear found associated with the image ID {imgId}.");

            int gearId = albumEntry.GearId;

            try
            {
                // Delete the file from the server
                if (System.IO.File.Exists(imageToDelete.Path))
                {
                    System.IO.File.Delete(imageToDelete.Path);
                }
                else
                {
                    // Log or notify that the file does not exist
                    Console.WriteLine($"File {imageToDelete.Path} not found on disk.");
                }

                // Remove the image record from the database
                _context.Images.Remove(imageToDelete);

                // Remove the album entry linking the image to the gear
                _context.Albums.Remove(albumEntry);

                // Save the changes to the database
                _context.SaveChanges();

                // Redirect to the ToolInfo view for the gear
                return RedirectToAction("GearInfo", new { gearId = gearId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the image: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while deleting the image.");
            }
        }

        //delete the tool completely
        [HttpGet("tools/{toolId}/del")]
        public IActionResult DeleteTool(int toolId)
        {
            var x = _context.Gears.FirstOrDefault(c => c.GearId == toolId);
            if (x == null) return NotFound($"Tool with ID {toolId} not found."); // 404 if doesn't exist
            _context.Gears.Remove(x);
            _context.SaveChanges();
            
            return RedirectToAction("Tools");
        }
        
        //add photos to tool
        [HttpPost("/gear/{gearId}/add-photos/")]
        public async Task<IActionResult> PostImage(Image image, IFormFile uploadFile, int gearId)
        {
            // Check if a file was uploaded
            if (uploadFile == null || uploadFile.Length <= 0) return RedirectToAction("GearInfo", new { gearId = gearId });
            
            // Generate a unique file name to prevent collisions
            var fileName = $"{Guid.NewGuid()}_{Path.GetFileName(uploadFile.FileName)}";
        
            // Define the folder path where images will be stored
            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
        
            // Ensure the directory exists
            if (!Directory.Exists(uploadsFolder)) Directory.CreateDirectory(uploadsFolder);
            
            // Combine the folder and file name
            var filePath = Path.Combine(uploadsFolder, fileName);
        
            // Set the image path for saving to the database
            image.Path = $"/images/{fileName}";
        
            // Save image information to the database
            _context.Images.Add(image);
            await _context.SaveChangesAsync();

            // Create and save the album entry that links the image to the gear
            var albumEntry = new Album
            {
                GearId = gearId,
                ImageId = image.Id
            };
            _context.Albums.Add(albumEntry);
            await _context.SaveChangesAsync();

            // Save the file to the server
            await using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await uploadFile.CopyToAsync(fileStream);
            }

            // Redirect back to the gear information page
            return RedirectToAction("GearInfo", new { gearId = gearId });
        }


        [HttpPost("update/{id:int}")]
        public IActionResult UpdateGear(int id, Gear fromForm)
        {
            if (ModelState.IsValid)
            {
                if (!_context.Gears.Any(d => d.GearId == id))//important! try to understand
                {
                    return RedirectToAction("Dash");
                }

                fromForm.GearId = id;
                _context.Entry(fromForm).Property("CreatedAt").IsModified = false;
                _context.Update(fromForm);
                _context.SaveChanges();
                return RedirectToAction("GearInfo", new { gearId = id });
            }
            else
            {
                return View("EditGear");
            }
        }
    }
}
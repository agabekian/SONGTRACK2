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
            List<Gear> allTools = _context.Gears.ToList();
            return View(allTools);
        }

        [HttpGet("/new-tool-form/")]
        public IActionResult DisplayNewToolForm()
        {
            return View("AddToolForm");
        }

        [HttpPost("/post-new-tool/")]
        //if missing, razor will look for a "form route" "/new-tool-form/" like above
        public IActionResult PostNewTool(Gear FromForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(FromForm);
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
            Gear RetrievedGear = _context.Gears.FirstOrDefault(i => i.GearId == gearId);
            return View("EditGear", RetrievedGear);
        }

        [HttpGet("/gear/{gearId}/add-photos")]
        public IActionResult DisplayAddGearPhotosForm()
        {
            return View("AddGearPhotosForm");
        }

        [HttpGet("/gear/{imgId}/delete-photo")]
        public IActionResult DeleteImage(int imgId)
        {
            Image imageToDelete = _context.Images.FirstOrDefault(i => i.Id == imgId);
            System.IO.File.Delete(imageToDelete.Path); //delete file from wwwroot altogether
            _context.Remove(imageToDelete); //del refs
            _context.SaveChanges();

            return RedirectToAction("Tools");
        }

        [HttpGet("tools/{toolId}/del")]
        public IActionResult DeleteTool(int toolId)
        {
            var x = _context.Gears.FirstOrDefault(c => c.GearId == toolId);
            if (x == null) return NotFound($"Tool with ID {toolId} not found."); // 404 if doesn't exist
            _context.Gears.Remove(x);
            _context.SaveChanges();
            
            return RedirectToAction("Tools");
        }
        
        [HttpPost("/gear/{gId}/add-photos/")]
        public async Task<IActionResult> PostImage(Image image, IFormFile uploadFile, int gId)
        {
            // Check if a file was uploaded
            if (uploadFile == null || uploadFile.Length <= 0) return RedirectToAction("GearInfo", new { gearId = gId });
            
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
                GearId = gId,
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
            return RedirectToAction("GearInfo", new { gearId = gId });
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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using cSharp2022.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Drawing;

namespace cSharp2022
{
    public class GearzController : Controller
    {
        private MuhContext _context;
        // here we can "inject" our context service into the constructor
        public GearzController(MuhContext context)
        {
            _context = context;
        }

        [HttpGet("/gear/{gearId}/info/")]
        public IActionResult GearInfo(int gearId)
        {
            Gear theGear = _context.Gears
            .Include(g => g.Recs)
            .ThenInclude(con => con.Gear)
            .Include(x => x.Images)
            .ThenInclude(z => z.Image)
            .FirstOrDefault(g => g.GearId == gearId);

            ViewBag.ToolStats = _context.Recs.ToList();
            return View("ToolInfo", theGear);
        }

        [HttpGet("/tools/")]
        public IActionResult Tools()
        {
            List<Gear> store = _context.Gears.ToList();
            return View(store);
        }

        [HttpGet("/new-tool-form/")]
        public IActionResult DisplayNewToolForm()
        {
            return View("AddToolForm");
        }

        [HttpPost("/postnewtool/")] //if missing, razor will look for a "form route" "/new-tool-form/" like above
        public IActionResult createTool(Gear FromForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(FromForm);
                _context.SaveChanges();
                return RedirectToAction("Tools");//this way, method here not actual route string, "".
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

        // [HttpGet("/delete/tool/{toolId}/")]
        [HttpGet("tools/{toolId}/del")]
        public IActionResult DeleteTool(int toolId)
        {
            var x = _context.Gears
            .Where(c => c.GearId == toolId).FirstOrDefault();
            _context.Remove(x);
            _context.SaveChanges();
            return RedirectToAction("Tools");
        }

        [HttpPost("/gear/{gId}/add-photos/")]
        public async Task<IActionResult> IndexAsync(Image image, IFormFile uploadFile, int gId)
        // Microsoft.AspNetCore.Http 
        {
            if (uploadFile != null && uploadFile.Length > 0)
            {
                var fileName = Path.GetFileName(uploadFile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);
                // var filePath = Path.Combine("~/images", fileName);
                image.Path = filePath;
                _context.Images.Add(image);
                _context.SaveChanges();
                Album pix = new Album()
                {
                    GearId = gId,
                    ImageId = image.Id
                };
                _context.Albums.Add(pix);
                _context.SaveChanges();

                using (var fileSrteam = new FileStream(filePath, FileMode.Create))
                {
                    await uploadFile.CopyToAsync(fileSrteam);
                }
            }
            return GearInfo(gId);
        }
        [HttpPost("update/{id}")]
        public IActionResult Update(int id, Gear FromForm)
        {
            if (ModelState.IsValid)
            {
                // Dish RetrievedDish = _context.Dishes.FirstOrDefault(d => d.DishId == id);//was causing error
                if (!_context.Gears.Any(d => d.GearId == id))//important! try to understand
                // if (RetrievedDish == null)//obsolete
                {
                    return RedirectToAction("Dash");
                }
                
                FromForm.GearId = id;
                _context.Entry(FromForm).Property("CreatedAt").IsModified = false;
                _context.Update(FromForm);
                _context.SaveChanges();
                return RedirectToAction("GearInfo",new {gearId=id});
            }
            else
            {
                return View("EditGear");
            }
        }

    }
}
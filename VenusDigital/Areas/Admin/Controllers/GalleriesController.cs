﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VenusDigital.Areas.Admin.Models;
using VenusDigital.Data;
using VenusDigital.Models;

namespace VenusDigital.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GalleriesController : Controller
    {
        private readonly VenusDigitalContext _context;

        public GalleriesController(VenusDigitalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GalleriesViewModel Gallery { get; set; }

        #region GalleryIndex

        // GET: Admin/Galleries
        public async Task<IActionResult> Index(int pageId)
        {
            var galleries = _context.ProductGalleries
                .Include(p => p.Products);

            var allGalleries = await galleries.ToListAsync();
            //For Pagination
            int take = 12;
            int skip = (pageId - 1) * take;
            ViewBag.PageCount = (int)Math.Ceiling(allGalleries.Count() / (double)take);
            return View(allGalleries.Skip(skip).Take(take).ToList());

        }

        #endregion

        #region GalleryDetails

        // GET: Admin/Galleries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productGalleries = await _context.ProductGalleries
                .Include(p => p.Products)
                .FirstOrDefaultAsync(m => m.GalleryId == id);
            if (productGalleries == null)
            {
                return NotFound();
            }

            return View(productGalleries);
        }

        #endregion

        #region CreateGallery

        // GET: Admin/Galleries/Create
        public IActionResult Create(int productId)
        {
            return View();
        }

        // POST: Admin/Galleries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GalleryId,ProductId,ImageName,ImageRefersTo,ImageAltName")] ProductGalleries productGalleries, int productId)
        {

            if (ModelState.IsValid)
            {
                //Creating a unique name for image name and set it for file name 
                var imageGalleryName = Guid.NewGuid().ToString();
                if (Gallery.ImageName?.Length > 0)
                    productGalleries.ImageName = imageGalleryName
                                                 + Path.GetExtension(Gallery.ImageName.FileName);
                else
                {
                    productGalleries.ImageName = "Default.jpg";
                }
                _context.Add(productGalleries);
                await _context.SaveChangesAsync();

                if (Gallery.ImageName?.Length > 0)
                {
                    string filePath = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "Images",
                        "pics",
                        imageGalleryName
                        + Path.GetExtension(Gallery.ImageName.FileName)
                    );
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        Gallery.ImageName.CopyTo(stream);
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductInStock", productGalleries.ProductId);
            return View(productGalleries);
        }


        #endregion

        #region UpdateGallery

        // GET: Admin/Galleries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productGalleries = await _context.ProductGalleries.FindAsync(id);
            if (productGalleries == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductInStock", productGalleries.ProductId);
            return View(productGalleries);
        }

        // POST: Admin/Galleries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GalleryId,ProductId,ImageName,ImageRefersTo,ImageAltName")] ProductGalleries productGalleries)
        {
            if (id != productGalleries.GalleryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //Gathering current name
                    var currentName = _context.ProductGalleries.AsNoTracking()
                        .FirstOrDefault(pg => pg.GalleryId == id);

                    //Checking if user want to change the image
                    if (Gallery.ImageName != null)
                    {
                        string oldFilePath = Path.Combine(
                            Directory.GetCurrentDirectory(),
                            "wwwroot",
                            "Images",
                            "pics",
                            currentName.ImageName
                        );
                        //Deleting existed image
                        if (System.IO.File.Exists(oldFilePath))
                        {
                            System.IO.File.Delete(oldFilePath);
                        }

                        //Giving new name to photo and saving it on server
                        var newImgName = Guid.NewGuid().ToString();
                        string newFilePath = Path.Combine(
                            Directory.GetCurrentDirectory(),
                            "wwwroot",
                            "Images",
                            "pics",
                            newImgName + Path.GetExtension(Gallery.ImageName.FileName)
                        );


                        productGalleries.ImageName = newImgName
                                                     + Path.GetExtension(Gallery.ImageName.FileName);
                        await using var stream = new FileStream(newFilePath, FileMode.Create);
                        await Gallery.ImageName.CopyToAsync(stream);
                    }
                    else
                    {
                        productGalleries.ImageName = currentName.ImageName;
                    }

                    _context.Update(productGalleries);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductGalleriesExists(productGalleries.GalleryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "ProductId", "ProductInStock", productGalleries.ProductId);
            return View(productGalleries);
        }


        #endregion

        #region RemoveGallery

        // GET: Admin/Galleries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productGalleries = await _context.ProductGalleries
                .Include(p => p.Products)
                .FirstOrDefaultAsync(m => m.GalleryId == id);
            if (productGalleries == null)
            {
                return NotFound();
            }

            return View(productGalleries);
        }

        // POST: Admin/Galleries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productGalleries = await _context.ProductGalleries.FindAsync(id);

            //Gathering imgName and path
            var imgName=productGalleries.ImageName;
            string path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot",
                "Images",
                "pics",
                imgName
            );

            //Deleting existed image
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _context.ProductGalleries.Remove(productGalleries);


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        #endregion

        private bool ProductGalleriesExists(int id)
        {
            return _context.ProductGalleries.Any(e => e.GalleryId == id);
        }
    }
}

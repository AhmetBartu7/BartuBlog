using Bussiness.Abstract;
using Entities.DtoTable;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WebUI.Areas.admin.Controllers
{
    [Area("admin")]
    public class BloglarController : Controller
    {
        private readonly IBlogsManager manager;
        
        public BloglarController(IBlogsManager _manager)
        {
            manager = _manager;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index()
        { 
            return View(await manager.GetAllAsync());
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Insert(DtoBlogs data, IFormFile images) 
        {
            if (images !=null)
            {
                string DosyaUzantisi = System.IO.Path.GetExtension(images.FileName);
                if (DosyaUzantisi == ".jpg" || DosyaUzantisi == ".jpeg")
                {

                    string YeniAd = Guid.NewGuid() + DosyaUzantisi;
                    string DosyaYolu = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{YeniAd}");
                    
                    using (var stream = new FileStream(DosyaYolu, FileMode.Create))
                    {
                        await images.CopyToAsync(stream);
                    }
                    data.Images = YeniAd;
                    data.RelaseDate = DateTime.Now;

                    ViewBag.olumlu = manager.AddAsync(data).Result.Message;
                }
                else
                {
                    ViewBag.Uyari = "Lütfen JPG veya JPEG uzantılı Resim Seçiniz!";
                }
            }
            else
            {
                ViewBag.Uyari = "Lütfen Resim Seçiniz!";
            }



            return View(await manager.GetAllAsync());
        }
    }
}

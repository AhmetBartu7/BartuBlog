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
    public class HesabimController : Controller
    {
        private readonly IAccountsManager manager;

        public HesabimController(IAccountsManager _manager)
        {
            manager = _manager;
        }
        [HttpGet]
        public async  Task<IActionResult> Index()
        {
            return View(await manager.GetAllAsync());
        }
        [HttpGet]
       
        public async Task<IActionResult> Insert(int Id)
        {
            return View();
        }
        
        [HttpPost]
        
        public async Task<IActionResult> Insert(DtoMyAccounts data, IFormFile images)
        {
            if (images != null)
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

        [HttpGet]
        [Route("/admin/Hesabim/update/{Id}")]
        public async Task<IActionResult> Update(int Id)
        {
            return View(await manager.GetByIdAsync(Id));
        }
        [HttpPost]
        [Route("/admin/Hesabim/Update/{Id}")]
        public async Task<IActionResult> Update(DtoMyAccounts data, int Id, IFormFile images)
        {

            if (images != null)
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


                    ViewBag.olumlu = manager.UpdateAsync(data).Result.Message;
                }
                else
                {
                    ViewBag.Uyari = "Lütfen JPG veya JPEG uzantılı Resim Seçiniz!";
                }
            }
            else
            {
                
                ViewBag.olumlu = manager.UpdateAsync(data).Result.Message;
            }

            return View(await manager.GetByIdAsync(Id));
           
        }
        [HttpPost]
        [Route("/admin/Hesabim/Delete/{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            TempData["Mesaj"]= manager.DeleteAsync(Id).Result.Message;
            return Redirect("/admin/Hesabim");
        }
    }
}

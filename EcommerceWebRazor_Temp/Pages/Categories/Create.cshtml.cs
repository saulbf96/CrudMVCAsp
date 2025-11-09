using EcommerceWebRazor_Temp.Data;
using EcommerceWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcommerceWebRazor_Temp.Pages.Categories
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        [BindProperty]//aqui tomamos los datos del formulario y lo asiganmos a esta prop
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Categoria creada exitosamente";
            return RedirectToPage("Index"); //despues de recibir los datos redirecionamos al index 
        }
    }
}

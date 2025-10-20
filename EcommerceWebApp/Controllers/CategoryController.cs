using EcommerceWebApp.Data;
using EcommerceWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebApp.Controllers
{


    public class CategoryController : Controller
    {
        //Inyección de dependencias: se recibe el contexto de base de datos

        //declaramos una variable privada dentro del controlador  llamada _bd
        //rendoy significa que solo se puede asignar una vez 
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db) //este es nuestro contructor del controlador 
        {
            //asignamos db a nuestro parametros _db para poderlo usar en todos los metodos 
            _db = db;
        }
        public IActionResult Index()
        {
            //esta es la respuesta del controlador puede ser una vista, un redireccionamiento, un JSON, etc.
            //index es la pagina principal de este controlador 
            //aqui pasamos los datos del metodo antes de que lleguen a la vista 
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);//devuelve la vista correspondiente 
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create (Category category)
        {
            return View();
        }
    }
}

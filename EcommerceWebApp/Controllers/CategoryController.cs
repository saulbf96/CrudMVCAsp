using EcommerceWebApp.Data;
using EcommerceWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        [HttpPost]// este metodo es post para enviar un formulario desde la vista 
        public IActionResult Create (Category category) //aqui se reciben los parametros que escribe el usuario
        {
            if(category.Name == category.DisplayOrder.ToString())//si es igual name y display mandara mensaje de error 
            {
                ModelState.AddModelError("nombre","El nombre de categoria no debe ser el mismo que Orden de visialización.");
            }
            //validamos en la BD si existen duplicados 
            bool nameExist = _db.Categories.Any(c => c.Name.ToLower() == category.Name.ToLower());

            if (nameExist)
            {
                ModelState.AddModelError("Name", $"Ya existe una categoría con el nombre '{category.Name}'.");

            }
            bool displayExists = _db.Categories.Any(c => c.DisplayOrder == category.DisplayOrder);
            if (displayExists)
            {
                ModelState.AddModelError("DisplayOrder", $"Ya existe una categoría con el Orden de visualización '{category.DisplayOrder}'.");
            }
            

            if (ModelState.IsValid)// se verifica si los parametros cumple con als reglas required etc
            {
                if (!string.IsNullOrWhiteSpace(category.Name))
                {//aqui convertimos la primera letra mayuscula para gusradarla en la base de datos 
                    category.Name = char.ToUpper(category.Name[0]) + category.Name.Substring(1).ToLower();
                }
                _db.Categories.Add(category); // se agrega el objeto category al context db _db
                _db.SaveChanges();// se guardan cambios 
                //Aqui agregamos un mensaje temporal de guardado con exito 
                TempData["success"] = $"La categoria '{category.Name}' se ha guardado correctamente.";
                // return RedirectToAction("Index");// despues d eguardar regresa la misma vista 


                //pasamos los valores existentes  ala vista de visualizacion  dinamica como nombre y display 
                ViewBag.ExistingNames = _db.Categories.Select(c => c.Name.ToLower()).ToList();
                ViewBag.ExistingDisplayOrder = _db.Categories.Select(d => d.DisplayOrder).ToList();
                return View(category);
            }
            // Si hay errores, también actualizamos ViewBag para la validación dinámica
            ViewBag.ExistingNames = _db.Categories.Select(c => c.Name.ToLower()).ToList();
            ViewBag.ExistingDisplays = _db.Categories.Select(c => c.DisplayOrder).ToList();

            return View(category);
           
        }
    }
}

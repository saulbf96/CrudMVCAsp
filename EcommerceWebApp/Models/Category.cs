using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EcommerceWebApp.Models
{
    public class Category
    {
        //propiedades de categoria 
        [Key]//decimos que el atributo key se asigna a  Id es primary key de la tabla categoria 
        public int Id { get; set; } //ID de la categoria primary key 

        [Required(ErrorMessage ="El nombre de la categoria es obligatorio.")]// decimos con esta anotacion se requiere un nombre para una categoria 
        [MaxLength(30, ErrorMessage ="El nombre no puede tener más de 30 caracteres.")]
        [DisplayName("Nombre de Categoria")]//aqui le decimos que muestre nombre en el UI del cliente en lugar de Name
        [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$",ErrorMessage ="El nombre no puede tener caracteres númericos.")]//no acepta numeros
        public string Name { get; set; } // Nombre de categoria 
        [DisplayName("Orden de Visualización")]//aqui le decimos que muestre nombre en el UI del cliente en lugar de DisplayOrder
        [Required(ErrorMessage = "El orden de visualización es obligatorio.")]
        [Range(1,50, ErrorMessage ="El valor esta fuera del rango, debe de estar entre 1 y 50.") ]//si el rango es menor o mayor 
        [RegularExpression(@"^\d+$", ErrorMessage = "El orden de visualización solo puede contener números")]//no acepta caracteres alfanumericos
        public int? DisplayOrder { get; set; } //mostrar el orden en que se muestran categoria


    }
}

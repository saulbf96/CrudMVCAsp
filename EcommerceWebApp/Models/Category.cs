using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EcommerceWebApp.Models
{
    public class Category
    {
        //propiedades de categoria 
        [Key]//decimos que el atributo key se asigna a  Id es primary key de la tabla categoria 
        public int Id { get; set; } //ID de la categoria primary key 
        [Required]// decimos con esta anotacion se requiere un nombre para una categoria 
        [DisplayName("Nombre")]//aqui le decimos que muestre nombre en el UI del cliente en lugar de Name
        public string Name { get; set; } // Nombre de categoria 
        [DisplayName("Orden de Visualización")]//aqui le decimos que muestre nombre en el UI del cliente en lugar de DisplayOrder
        public int DisplayOrder { get; set; } //mostrar el orden en que se muestran categoria


    }
}

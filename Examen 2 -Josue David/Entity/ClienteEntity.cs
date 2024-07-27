using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen_2__Josue_David.Entity
{
    [Table("Cliente", Schema ="dto")]
    public class ClienteEntity { 
        [Key]
        [Column ("ClienteId")]
        public Guid ClienteId { get; set; }
        [Display (Name = "Nombre del Cliente")]
        [Required(ErrorMessage ="El {0} es requerido")]
        [Column("cliente_name")]
        public string ClienteName { get; set; }
        public virtual IEnumerable<PrestamoEntity> Pagos { get; set; } 


    }
}

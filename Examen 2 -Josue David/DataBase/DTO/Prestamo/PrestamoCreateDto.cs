using System.ComponentModel.DataAnnotations;

namespace Examen_2__Josue_David.DataBase.DTO.Prestamo
{
    public class PrestamoCreateDto
        
    {
        public Guid ClienteId { get; set; }
        [Display(Name ="Cantidad del Prestamo")]
        [Required(ErrorMessage ="La {0} es requerida")]
        public int Loan {  get; set; }

        [Display(Name = "Tasa de Intereses")]
        [Required(ErrorMessage ="La {0} es requerida")]
        public int InterestRate { get; set; }

        [Display(Name ="La cantida de comision")]
        [Required(ErrorMessage ="La {0} es requerida")]
        public int Commission {  get; set; }

        [Display(Name = "Tiempo del Prestamo")]
        [Required(ErrorMessage ="El {0} es requerido")]
        public int LoanTime { get; set; }
    }
}

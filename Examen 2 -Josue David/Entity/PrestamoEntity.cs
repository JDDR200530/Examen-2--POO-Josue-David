using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Examen_2__Josue_David.Entity
{
    [Table("plan_de_pago", Schema = "dto")]
    public class PrestamoEntity
    {
        [Key]
        [Column("Cliente_Id")]
        [ForeignKey(nameof(ClienteId))]
        public Guid ClienteId { get; set; }
        [Column("Prestamo_Id")]
        public Guid LoanId { get; set; }
        
        [Column("Fecha_Prestamo")]
        public DateTime LoanDate { get; set; }

        [Column("Tasa_de_Interes")]
        public int InterestRate { get; set; }

        [Column("Comision")]
        public int commission {  get; set; }

        [Column("Tiempo_del_Prestamo")]
        public int LoanTime { get; set; }




        public virtual ICollection<PlandePagoEntity>ClientesPlandePago { get; set; }
    }
}

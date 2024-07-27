using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen_2__Josue_David.Entity
{
    [Table("cliente_planepago", Schema = "dto")]
    public class PlandePagoEntity
    {
        [Key]

        [Column("Prestamo_Id")]
        [ForeignKey(nameof(LoanId))]
        public Guid LoanId { get; set; }
        [Column("Dia_de_Creacion")]
        [ForeignKey(nameof(LoanDate))]
        public DateTime LoanDate { get; set; }
        [Column("Fecha_de_Pago")]
        public DateTime Paymentdate {get; set; }
        [Column("Dias")]
        public int Day {  get; set; }
        [Column("Intereses")]
        public double Interests { get; set; }
        [Column("Principal")]
        public float Principal {  get; set; }
        [Column("Nivel_Pago_Sin_VSD")]
        public float levelPaymentWithoutVSD { get; set; }
        [Column("Nivel_Pago_Con_VSD")]
        public double levelPaymentWithSVSD { get; set; }
        [Column("Balance_Principal")]
        public float MainBalanceSheet { get; set; }
        public virtual PrestamoEntity PrestamoEntity { get; set; }
    }
}



namespace Examen_2__Josue_David.DataBase.DTO.PlandePago
{
    public class PlandePagoDto
    {
        public Guid LoanId { get; set; }

        public DateTime LoanDate { get; set; }

        public DateTime PaymentDate { get; set; }

        public int Day {  get; set; }

        public double Interests { get; set; }

        public float Principal {  get; set; }

        public float levelPaymentWithoutVSD { get; set; }
        public double levelPaymentWithSVSD { get; set; }    

        public float MainBalanceSheet { get; set; }
    }
}

namespace Examen_2__Josue_David.DataBase.DTO.Prestamo
{
    public class PrestamoDto
    {
        public Guid ClienteId { get; set; }

        public Guid LoanId { get; set; }

        public DateTime LoanDate { get; set; }

        public int Loan {  get; set; }

        public int InteresRate { get; set; }

        public int Commission {  get; set; }

        public int LoanTime { get; set; }


    }
}

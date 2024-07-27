//using Examen_2__Josue_David.Entity;
//using Examen_2__Josue_David.Service.Interface;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Examen_2__Josue_David.Service
//{
//    public class PlandePagoService : IPlandePagoService
//    {
//        private readonly LoanContext _context; 

//        public PlandePagoService(LoanContext context)
//        {
//            _context = context;
//        }

//        public void CreateLoan(ClienteEntity cliente, PrestamoEntity prestamo)
//        {
//            _context.Clientes.Add(cliente); 
//            _context.Prestamos.Add(prestamo);
//            _context.SaveChanges();

//            var cuotas = CalcularCuotas(prestamo);
//            _context.Cuotas.AddRange(cuotas);
//            _context.SaveChanges();
//        }

//        private List<PrestamoEntity> CalcularCuotas(PrestamoEntity prestamo)
//        {
//            var cuotas = new List<PrestamoEntity>();
//            var fecha = prestamo.FechaPrimerPago;
//            var monto = prestamo.Monto;
//            var tasaInteres = prestamo.TasaInteres / 100 / 12;
//            var plazo = prestamo.Plazo;

//            var cuotaNivelada = monto * (decimal)(tasaInteres * Math.Pow(1 + (double)tasaInteres, plazo) / (Math.Pow(1 + (double)tasaInteres, plazo) - 1));

//            for (int i = 0; i < plazo; i++)
//            {
//                var interes = monto * tasaInteres;
//                var principal = cuotaNivelada - interes;
//                monto -= principal;

//                cuotas.Add(new Cuota
//                {
//                    NumeroCuota = i + 1,
//                    FechaPago = fecha.AddMonths(i),
//                    Dias = (i == 0) ? (fecha.AddMonths(i).Day - fecha.Day) : DateTime.DaysInMonth(fecha.AddMonths(i).Year, fecha.AddMonths(i).Month),
//                    Interes = interes,
//                    Principal = principal,
//                    PagoNiveladoSinComision = cuotaNivelada,
//                    PagoNiveladoConComision = cuotaNivelada * 1.01m, // Asumimos una comisión del 1%
//                    SaldoPrincipal = monto
//                });
//            }

//            return cuotas;
//        }
//    }
//}

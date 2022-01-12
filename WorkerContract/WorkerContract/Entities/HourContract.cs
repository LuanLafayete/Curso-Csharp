using System;

namespace WorkerContract.Entities
{
    class HourContract
    {
        //Atributos
        public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //Construtor
        public HourContract()
        {
        }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //Método
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}

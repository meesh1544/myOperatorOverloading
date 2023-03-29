using System;
namespace myOperatorOverloading
{
    public class Cleaning
    {
        public DateTime CleaningDate { get; set; }
        public int CleaningDays { get; set; }
        public float CleaningTime { get; set;}

        public Cleaning()
        {
            CleaningDate = DateTime.Now;
            CleaningDays = 0;
            CleaningTime = 0;
        }
        public Cleaning(DateTime CleaningDate, int CleaningDays, float CleaningTime)
        {
            this.CleaningDate = CleaningDate;
            this.CleaningDays = CleaningDays;
            this.CleaningTime = CleaningTime;
        }
        public static Cleaning operator +(Cleaning lhs, Cleaning rhs)
        {
            return new Cleaning(DateTime.Now, lhs.CleaningDays + rhs.CleaningDays, lhs.CleaningTime + rhs.CleaningTime);
            
        }
        public static Cleaning operator -(Cleaning lhs, Cleaning rhs)
        {
            return new Cleaning(DateTime.Now, lhs.CleaningDays - rhs.CleaningDays, lhs.CleaningTime - rhs.CleaningTime);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cleaning day1 = new Cleaning(new DateTime(2023, 03, 1),2 , 12f);
            Cleaning day2 = new Cleaning(new DateTime(2023, 03, 2), 2, 16f);
            Cleaning daysUntilFinished = new Cleaning(new DateTime(2023, 03, 5),10, 50f);
            Cleaning TotalDays = new Cleaning();
            TotalDays += day1;
            TotalDays += day2;
            Console.WriteLine("----Current Days------- \n" +  TotalDays.CleaningDate + "\nHours: " + TotalDays.CleaningDays + "\nTime: " + TotalDays.CleaningTime);
            daysUntilFinished -= TotalDays;
            Console.WriteLine("\n----Days Left---- \n" + "Total Days Left:" + daysUntilFinished.CleaningDays  + "\nTime: " + daysUntilFinished.CleaningTime);
        }
    }
}
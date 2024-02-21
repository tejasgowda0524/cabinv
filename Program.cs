namespace abc
{
    public class InvoiceGenerator
    {
        public const double CostPerKilometer = 10.0;
        public const double CostPerMinute = 1.0;
        public const double MinimumFare = 5.0;

        public static double TotalFare(double distance, int timeInMinutes)
        {
            double fare = distance * CostPerKilometer + timeInMinutes * CostPerMinute;//d*km+t*

            return Math.Max(fare, MinimumFare);
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        
    }
}
        
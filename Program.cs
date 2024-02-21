
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
class Program
{
    static void Main(string[] args)
    {
        InvoiceGenerator invoiceGenerator = new InvoiceGenerator();

        // Example journey details: distance = 20 km, time = 30 minutes
        double distance = 20;
        int timeInMinutes = 30;

        double fare = invoiceGenerator.CalculateFare(distance, timeInMinutes);
        Console.WriteLine($"Total fare for the journey: Rs. {fare}");
    }
}

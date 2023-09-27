internal class Program
{
 static void Main(string[] args)
    {
        InsuranceBroker insuranceBroker = new InsuranceBroker("Mike", "Lowry");
        insuranceBroker.Sell();

        CarSalesman carSalesman = new CarSalesman("Chris", "Pratt");
        carSalesman.Sell();
    }
}
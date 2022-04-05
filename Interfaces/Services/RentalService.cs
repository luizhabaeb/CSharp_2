using INTERFACES__Solution_With_Interface.Entities;


namespace INTERFACES__Solution_With_Interface.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; } //cannot be changed

        public double PricePerDay { get; private set;} //cannot be changed

        private ITaxService _TaxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService;
        }


        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);  
            }

            double tax = _TaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax); 
        }
    }
}

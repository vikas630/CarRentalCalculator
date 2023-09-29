namespace CarRentalApp
{
    public partial class CarRental
    {
        partial void CalculateRentalCharge();

        // Default constructor
        public CarRental()
        {
            fields = new Fields();
            properties = new Properties();
        }

        // Overloaded constructor
        public CarRental(string nameOfCustomer, int endMiles, int numDays)
        {
            fields = new Fields
            {
                CustomerName = nameOfCustomer,
                DaysRented = numDays,
                EndOdometerReading = endMiles
            };

            properties = new Properties
            {
                CustomerName = nameOfCustomer,
                DaysRented = numDays,
                EndOdometerReading = endMiles
            };

            CalculateRentalCharge();
        }
    }
}

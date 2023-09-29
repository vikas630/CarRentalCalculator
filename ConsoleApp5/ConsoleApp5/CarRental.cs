namespace CarRentalApp
{
    public partial class CarRental
    {
        private Fields fields;
        private Properties properties;

        public string CustomerName
        {
            get { return properties.CustomerName; }
            set { properties.CustomerName = value; }
        }

        public decimal RentalCharge
        {
            get { return properties.RentalCharge; }
            private set { properties.RentalCharge = value; }
        }

        public int EndingOdometerReading
        {
            get { return properties.EndOdometerReading; }
            set
            {
                properties.EndOdometerReading = value;
                CalculateRentalCharge();
            }
        }

        public int BeginningOdometerReading
        {
            get { return properties.BeginOdometerReading; }
            set
            {
                properties.BeginOdometerReading = value;
                CalculateRentalCharge();
            }
        }

        public int NumberOfDaysRented
        {
            get { return properties.DaysRented; }
            set
            {
                properties.DaysRented = value;
                CalculateRentalCharge();
            }
        }

        partial void CalculateRentalCharge()
        {
            // Rental charge = $57.75 per day + $0.69 per mile
            RentalCharge = 57.75m * NumberOfDaysRented + 0.69m * (EndingOdometerReading - BeginningOdometerReading);
        }
    }
}

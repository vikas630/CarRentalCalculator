using System;
using System.Windows.Forms;

namespace CarRentalApp
{
    public class CarRentalForm : Form
    {
        private TextBox txtCustomerName;
        private TextBox txtBeginOdometer;
        private TextBox txtEndOdometer;
        private TextBox txtDaysRented;
        private Label label1;
        private Label lblRentalCharge;

        private readonly Properties properties = new Properties();

        public CarRentalForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Initialize controls
            txtCustomerName = new TextBox();
            txtBeginOdometer = new TextBox();
            txtEndOdometer = new TextBox();
            txtDaysRented = new TextBox();
            lblRentalCharge = new Label();

            Button btnCreateCarRental = new Button();
            btnCreateCarRental.Text = "Create Car Rental";
            btnCreateCarRental.Click += BtnCreateCarRental_Click;

            Button btnClear = new Button();
            btnClear.Text = "Clear/Reset";
            btnClear.Click += BtnClear_Click;

            Button btnExit = new Button();
            btnExit.Text = "Exit";
            btnExit.Click += BtnExit_Click;

            // Set form properties
            this.Text = "Car Rental Form";
            this.Size = new System.Drawing.Size(300, 250);

            // Set control positions
            txtCustomerName.Location = new System.Drawing.Point(10, 10);
            txtBeginOdometer.Location = new System.Drawing.Point(10, 40);
            txtEndOdometer.Location = new System.Drawing.Point(10, 70);
            txtDaysRented.Location = new System.Drawing.Point(10, 100);
            btnCreateCarRental.Location = new System.Drawing.Point(10, 130);
            btnClear.Location = new System.Drawing.Point(110, 130);
            btnExit.Location = new System.Drawing.Point(210, 130);
            lblRentalCharge.Location = new System.Drawing.Point(10, 160);

            // Add controls to form
            this.Controls.Add(txtCustomerName);
            this.Controls.Add(txtBeginOdometer);
            this.Controls.Add(txtEndOdometer);
            this.Controls.Add(txtDaysRented);
            this.Controls.Add(btnCreateCarRental);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnExit);
            this.Controls.Add(lblRentalCharge);
        }

        private void BtnCreateCarRental_Click(object sender, EventArgs e)
        {
            try
            {
                // Instantiate CarRental object
                CarRental carRental = new CarRental(
                    txtCustomerName.Text,
                    int.Parse(txtEndOdometer.Text),
                    int.Parse(txtDaysRented.Text)
                )
                {
                    BeginningOdometerReading = int.Parse(txtBeginOdometer.Text)
                };

                // Debugging statements
                Console.WriteLine($"Rental Charge: {carRental.RentalCharge}");
                //Properties.RentalCharge = lblRentalCharge;
                // Display rental charge in label
                // lblRentalCharge.Text = "Rental Charge: " + carRental.RentalCharge;
                lblRentalCharge.Text = "Charge:$"+carRental.RentalCharge.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating CarRental: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Clear or reset values
            txtCustomerName.Clear();
            txtBeginOdometer.Clear();
            txtEndOdometer.Clear();
            txtDaysRented.Clear();
            lblRentalCharge.Text = string.Empty;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Exit application
            Application.Exit();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            // 
            // CarRentalForm
            // 
            this.ClientSize = new System.Drawing.Size(1443, 602);
            this.Controls.Add(this.label1);
            this.Name = "CarRentalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}

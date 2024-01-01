using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class AddCarRecordForm : Form
    {
        private readonly CarRentalProjectDbEntities1 carRentalDb;
        public AddCarRecordForm()
        {
            InitializeComponent();
            carRentalDb = new CarRentalProjectDbEntities1();
        }
      
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Now.Date;
                string cstName = tbCustomerName.Text;
                string tCar = typeOfCar.Text;
                var dateOut = rentedDate.Value;
                var dateIn = returnedDate.Value;
                double cost = Convert.ToDouble(ctCost.Text);

                var isValid = true;
                var errorMessage = "";
                var error = "Errors:\n\r";
                int i = 0;
                if (string.IsNullOrEmpty(cstName) || string.IsNullOrEmpty(tCar))
                {
                    isValid = false;
                    i++;
                    errorMessage+=$"{i} Data are missing!\n\r";
                }

                if (dateOut > dateIn || dateOut<today || dateIn<today )
                {
                    isValid = false;
                    i++;
                    errorMessage+= $"\n\r {i} The choosen dates are not respected";
                }

                if (isValid)
                {
                    CarRental carrental = new CarRental();

                    carrental.costumerName =cstName;
                    carrental.cost = ((decimal)cost);
                    carrental.rentDate = dateOut;
                    carrental.returnDate =dateIn;
                    carrental.carType = (int)typeOfCar.SelectedValue;
                    
                    carRentalDb.CarRentals.Add(carrental);
                    carRentalDb.SaveChanges();

                    _ = MessageBox.Show($"Thank you for choosing us" +
                        $" .\n\r Customer Name: {cstName}\n\r Type of" +
                        $" Car: {tCar}\n\r Date of Rent: {dateIn} \n\r " +
                        $"Date of Return: {dateOut}\n\r The cost is: ${cost}" +
                        $" \n\r Please be at time!");
                }
                else
                {
                    MessageBox.Show(error+errorMessage);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Input fields was not in a correct format");
            }


           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var car = carRentalDb.Cars.ToList();
            typeOfCar.DisplayMember="name";
            typeOfCar.ValueMember = "id";
            typeOfCar.DataSource = car;

        }


    }
}

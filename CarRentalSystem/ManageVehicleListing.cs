using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalProjectDbEntities1 carRentalDb;
        public ManageVehicleListing()
        {
            InitializeComponent();
            carRentalDb=new CarRentalProjectDbEntities1();
        }

        private void dgCarrentalViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carRentalDb.Cars.ToList();
        }
    }
}

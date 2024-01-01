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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarRecordForm newRecordForm = new AddCarRecordForm();
            newRecordForm.MdiParent = this;
            newRecordForm.WindowState = FormWindowState.Maximized;
            newRecordForm.Show();
        }

    }
}

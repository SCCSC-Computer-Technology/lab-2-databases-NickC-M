using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Nicholas Chapman-Miller
 * Lab 2
 * CPT-206-A01H
 */
namespace NChapman_Miller_Lab_2_CPT206
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        private void butSortAsc_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.SortPopAsc(this.cityDBDataSet.City);
        }

        private void butSortDes_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.SortPopDesc(this.cityDBDataSet.City);
        }

        private void butTot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Total Population is " + this.cityTableAdapter.TotalPop());
        }

        private void butAvg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Average Population is " + this.cityTableAdapter.AvgPop());
        }

        private void butHigh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Highest Population is " + this.cityTableAdapter.MaxPop());
        }

        private void butLow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Lowest Population is " + this.cityTableAdapter.MinPop());
        }

        private void butSortCity_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.SortCity(this.cityDBDataSet.City);
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*** THANK YOU ***");
            this.Close();
        }
    }
}

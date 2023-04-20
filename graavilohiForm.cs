using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantForms
{
    public partial class graavilohiForm : Form
    {

        public graavilohiForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SalesCollection sales = new SalesCollection();

            graavilohiChart.Series["Sales"].Points.Clear();

            var saleGraavilohi = sales.array.Where(Sales => Sales.dishName == "Graavilohi");

            foreach (Sales sale in saleGraavilohi)
            {
                graavilohiChart.Series["Sales"].Points.AddXY(sale.monthName, sale.quantity);
            }
        }
    }
}

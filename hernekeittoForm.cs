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
    public partial class hernekeittoForm : Form
    {
        public hernekeittoForm()
        {
            InitializeComponent();
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            SalesCollection sales = new SalesCollection();

            hernekeittoChart.Series["Sales"].Points.Clear();

            var saleHernekeitto = sales.array.Where(Sales => Sales.dishName == "Hernekeitto");

            foreach (Sales sale in saleHernekeitto)
            {
                hernekeittoChart.Series["Sales"].Points.AddXY(sale.monthName, sale.quantity);
            }
        }
    }
}

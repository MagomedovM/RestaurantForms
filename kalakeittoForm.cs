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
    public partial class kalakeittoForm : Form
    {
        public kalakeittoForm()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            SalesCollection sales = new SalesCollection();

            kalakeittoChart.Series["Sales"].Points.Clear();

            var saleKalakeitto = sales.array.Where(Sales => Sales.dishName == "Kalakeitto");

            foreach (Sales sale in saleKalakeitto)
            {
                kalakeittoChart.Series["Sales"].Points.AddXY(sale.monthName, sale.quantity);
            }
        }
    }
}

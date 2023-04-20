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
    public partial class leipajuustoForm : Form
    {
        public leipajuustoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesCollection sales = new SalesCollection();

            leipajuustoChart.Series["Sales"].Points.Clear();

            var saleLeipajuusto = sales.array.Where(Sales => Sales.dishName == "Leipäjuusto");

            foreach (Sales sale in saleLeipajuusto)
            {
                leipajuustoChart.Series["Sales"].Points.AddXY(sale.monthName, sale.quantity);
            }          
        }
    }
}

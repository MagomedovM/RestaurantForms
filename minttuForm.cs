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
    public partial class minttuForm : Form
    {
        public minttuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesCollection sales = new SalesCollection();

            minttuChart.Series["Sales"].Points.Clear();

            var saleMinttu = sales.array.Where(Sales => Sales.dishName == "Minttu");

            foreach (Sales sale in saleMinttu)
            {
                minttuChart.Series["Sales"].Points.AddXY(sale.monthName, sale.quantity);
            }
        }
    }
}

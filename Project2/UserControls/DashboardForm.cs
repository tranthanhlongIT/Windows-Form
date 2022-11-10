using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project2.BUS;

namespace Project2.UserControls
{
    public partial class DashboardForm : UserControl
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
        }

        private void chartCustomer_Click(object sender, EventArgs e)
        {
            OrderBUS orderBUS = new OrderBUS();
            var q = orderBUS.GetAll().GroupBy(i => i.created_at).Select(g => new { total = g.Count(), Day = g.Key.Day }).ToList();

            chartCustomer.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            List<DateTime> dates = new List<DateTime>();
            DateTime dt = DateTime.Now;
            for (int i = 1; i < 31; i++)
                dates.Add(new DateTime(dt.Year, dt.Month, i));
            foreach (DateTime d in dates)
            {
                int index = -1;
                foreach (var i in q)
                {
                    if (i.Day == d.Day)
                    {
                        index = q.IndexOf(i);
                        break;
                    }
                }
                if (index != -1)
                    chartCustomer.Series["Customer"].Points.AddXY(d.Day, q[index].total);
                else chartCustomer.Series["Customer"].Points.AddXY(d.Day, 0);
                index = -1;
            }
        }
    }
}

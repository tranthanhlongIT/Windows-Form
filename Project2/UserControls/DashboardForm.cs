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
            RenderCustomerChart();
        }

        private void RenderCustomerChart()
        {
            List<DateTime> dates = new List<DateTime>();
            DateTime dt = DateTime.Now;

            chartCustomer.ChartAreas.FirstOrDefault().AxisX.Interval = 1;

            for (int i = 1; i < 31; i++)
                dates.Add(new DateTime(dt.Year, dt.Month, i));

            foreach (DateTime d in dates)
            {
                chartCustomer.Series["Customer"].Points.AddXY(d.Day, 0);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            chartCustomer.Series["Customer"].Points.Clear();

            List<DateTime> dates = new List<DateTime>();
            DateTime dt = dtpMonth.Value;

            chartCustomer.ChartAreas.FirstOrDefault().AxisX.Interval = 1;

            // Trả về dữ liệu total customer từng ngày trong tháng
            var q = OrderBUS.GetAllByMonth(dt.Month).GroupBy(i => new { Day = i.created_at.Day }).Select(g => new { total = g.Count(), day = g.Key.Day }).ToList();

            for (int i = 1; i <= 31; i++)
            {
                try
                {
                    dates.Add(new DateTime(dt.Year, dt.Month, i));
                }
                catch
                {
                    break;
                };
            }

            foreach (DateTime d in dates)
            {
                int index = -1;
                foreach (var i in q)
                {
                    if (i.day == d.Day)
                    {
                        index = q.IndexOf(i); // Lấy được từng dòng dữ liệu tháng có ngày trùng với ngày d
                        break;
                    }
                }

                if (index != -1)
                    chartCustomer.Series["Customer"].Points.AddXY(d.Day, q[index].total); // Truyền vào chart tổng khách hàng trong ngày đó
                else chartCustomer.Series["Customer"].Points.AddXY(d.Day, 0);
            }
        }
    }
}

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
        private List<DateTime> dates;
        private DateTime date;

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            SetCustomerChart();
            SetProductChart();
        }
        
        private void SetProductChart()
        {
            date = dtpMonth.Value;
            var q = OrderBUS.GetAllByMonthYear(date.Month, date.Year).GroupBy(o => new { Type = o.Product.Category.name }).Select(g => new { type = g.Key.Type, total = g.Count() }).ToList();
            foreach (var item in q)
            {
                chartProduct.Series["Product"].Points.AddXY(item.type, item.total);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SetCustomerChart();
        }

        private void dtpMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetCustomerChart();
                e.SuppressKeyPress = true;
            }
        }

        private void SetCustomerChart()
        {
            chartCustomer.Series["Customer"].Points.Clear();
            chartCustomer.ChartAreas.FirstOrDefault().AxisX.Interval = 1;

            dates = new List<DateTime>();
            date = dtpMonth.Value;

            // Trả về tổng khách hàng của từng ngày trong tháng
            var q = OrderBUS.GetAllByMonthYear(date.Month, date.Year).GroupBy(o => new { Day = o.created_at.Day }).Select(g => new { day = g.Key.Day, total = g.Count() }).ToList();

            for (int i = 1; i <= 31; i++)
            {
                try
                {
                    dates.Add(new DateTime(date.Year, date.Month, i));
                }
                catch
                {
                    break;
                };
            }

            foreach (DateTime d in dates)
            {
                int index = -1;
                foreach (var item in q)
                {
                    if (item.day == d.Day)
                    {
                        index = q.IndexOf(item); // Lấy được dòng dữ liệu có ngày trùng với ngày d
                        break;
                    }
                }

                if (index != -1)
                {
                    chartCustomer.Series["Customer"].Points.AddXY(d.Day, q[index].total); // Truyền vào chart tổng khách hàng trong ngày đó
                }
                else chartCustomer.Series["Customer"].Points.AddXY(d.Day, 0);
            }
        }
    }
}
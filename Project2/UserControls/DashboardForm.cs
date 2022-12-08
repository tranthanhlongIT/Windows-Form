using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            if (!this.DesignMode)
            {
                SetCustomerChart();
                SetProductChart();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SetCustomerChart();
            SetProductChart();
        }

        private void dtpMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetCustomerChart();
                SetProductChart();
                e.SuppressKeyPress = true;
            }
        }

        private void SetProductChart()
        {
            chartProduct.Series["Product"].Points.Clear();

            date = dtpMonth.Value;
            var q = OrderBUS.GetAllByMonthYear(date.Month, date.Year)
                .GroupBy(o => new { Type = o.Product.Category.name })
                .Select(g => new { type = g.Key.Type, total = g.Count() }).ToList();
            foreach (var item in q)
            {
                chartProduct.Series["Product"].Points.AddXY(item.type, item.total);
            }
        }

        private void SetCustomerChart()
        {
            chartCustomer.Series["Customer"].Points.Clear();
            chartCustomer.ChartAreas.FirstOrDefault().AxisX.Interval = 1;

            dates = new List<DateTime>();
            date = dtpMonth.Value;
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            var q = OrderBUS.GetAllByMonthYear(date.Month, date.Year)
                .GroupBy(o => new { Day = o.created_at.Day })
                .Select(g => new { day = g.Key.Day, total = g.Count() }).ToList();

            for (int i = 1; i <= daysInMonth; i++)
            {
                dates.Add(new DateTime(date.Year, date.Month, i));
            }

            foreach (DateTime d in dates)
            {
                int index = -1;
                foreach (var item in q)
                {
                    if (item.day == d.Day)
                    {
                        index = q.IndexOf(item);
                        break;
                    }
                }

                if (index != -1)
                {
                    chartCustomer.Series["Customer"].Points.AddXY(d.Day, q[index].total);
                }
                else chartCustomer.Series["Customer"].Points.AddXY(d.Day, 0);
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project2
{
    public partial class ManagementForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private int activeBtn;
        private Employee employee;

        public ManagementForm()
        {
            InitializeComponent();
        }

        public ManagementForm(Employee emp)
        {
            InitializeComponent();
            this.employee = emp;
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            SlidePanel(btnDashboard);
            ChangeButtonTextColor(1, btnDashboard, new List<Button> { btnProduct, btnEmployee, btnCategory, btnSell, btnHistory });
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X)
                    + e.X, (this.Location.Y - lastLocation.Y)
                    + e.Y);
                this.Update();
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SlidePanel(btnDashboard);
            ChangeButtonTextColor(1, btnDashboard, new List<Button> { btnProduct, btnEmployee, btnCategory, btnSell, btnHistory});
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SlidePanel(btnProduct);
            ChangeButtonTextColor(2, btnProduct, new List<Button> { btnDashboard, btnEmployee, btnCategory, btnSell, btnHistory });
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            SlidePanel(btnEmployee);
            ChangeButtonTextColor(3, btnEmployee, new List<Button> { btnDashboard, btnProduct, btnCategory, btnSell, btnHistory });
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            SlidePanel(btnCategory);
            ChangeButtonTextColor(4, btnCategory, new List<Button> { btnDashboard, btnProduct, btnEmployee, btnSell, btnHistory });
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            SlidePanel(btnSell);
            ChangeButtonTextColor(5, btnSell, new List<Button> { btnDashboard, btnProduct, btnEmployee, btnCategory, btnHistory });
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            SlidePanel(btnHistory);
            ChangeButtonTextColor(6, btnHistory, new List<Button> { btnDashboard, btnProduct, btnEmployee, btnCategory, btnSell });
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void btnRestoreDown_Click(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Maximized)
        //    {
        //        this.WindowState = FormWindowState.Normal;
        //    }
        //    else this.WindowState = FormWindowState.Maximized;
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.SteelBlue;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(activeBtn, 1))
                btnDashboard.ForeColor = Color.Black;
        }

        private void btnProduct_MouseEnter(object sender, EventArgs e)
        {
            btnProduct.ForeColor = Color.SteelBlue;
        }

        private void btnProduct_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(activeBtn, 2))
                btnProduct.ForeColor = Color.Black;
        }
        private void btnEmployee_MouseEnter(object sender, EventArgs e)
        {
            btnEmployee.ForeColor = Color.SteelBlue;
        }

        private void btnEmployee_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(activeBtn, 3))
                btnEmployee.ForeColor = Color.Black;
        }

        private void btnCategory_MouseEnter(object sender, EventArgs e)
        {
            btnCategory.ForeColor = Color.SteelBlue;
        }

        private void btnCategory_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(activeBtn, 4))
                btnCategory.ForeColor = Color.Black;
        }

        private void btnSell_MouseEnter(object sender, EventArgs e)
        {
            btnSell.ForeColor = Color.SteelBlue;
        }

        private void btnSell_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(activeBtn, 5))
                btnSell.ForeColor = Color.Black;
        }

        private void btnHistory_MouseEnter(object sender, EventArgs e)
        {
            btnHistory.ForeColor = Color.SteelBlue;
        }

        private void btnHistory_MouseLeave(object sender, EventArgs e)
        {
            if (!IsButtonActive(activeBtn, 6))
                btnHistory.ForeColor = Color.Black;
        }

        private void SlidePanel(Button btn)
        {
            pnlLineActive.Width = btn.Width;
            pnlLineActive.Left = btn.Left;
        }

        private void ChangeButtonTextColor(int btnIndex, Button btnActive, List<Button> listBtn)
        {
            activeBtn = btnIndex;
            btnActive.ForeColor = Color.SteelBlue;
            foreach (Button btn in listBtn)
            {
                btn.ForeColor = Color.Black;
            }
        }

        private bool IsButtonActive(int activeBtn, int btn)
        {
            if (activeBtn == btn)
                return true;
            return false;
        }
    }
}

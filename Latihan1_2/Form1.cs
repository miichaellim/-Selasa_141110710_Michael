﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calender_ValueChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (vScrollBar1.Value < vScrollBar2.Value)
            {
                min.Text = vScrollBar1.Value.ToString();
                max.Text = vScrollBar2.Value.ToString();
            }
            else
            {
                min.Text = vScrollBar2.Value.ToString();
                max.Text = vScrollBar1.Value.ToString();
            }

            DateTime tmp = new DateTime();
            tmp = new DateTime(DateTime.Today.Year + Math.Abs(vScrollBar1.Value - vScrollBar2.Value), DateTime.Today.Month, DateTime.Today.Day);
            calender.MinDate = DateTime.Today.Date;
            calender.MaxDate = tmp;

            lbl5.Text = Convert.ToString(DateTime.Today.Year + Math.Abs(vScrollBar1.Value - vScrollBar2.Value));
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            if (vScrollBar1.Value > vScrollBar2.Value)
            {
                min.Text = vScrollBar1.Value.ToString();
                max.Text = vScrollBar2.Value.ToString();
            }
            else
            {
                min.Text = vScrollBar2.Value.ToString();
                max.Text = vScrollBar1.Value.ToString();
            }

            DateTime tmp = new DateTime();
            tmp = new DateTime(DateTime.Today.Year + Math.Abs(vScrollBar1.Value - vScrollBar2.Value), DateTime.Today.Month, DateTime.Today.Day);
            calender.MinDate = DateTime.Today.Date;
            calender.MaxDate = tmp;

            lbl5.Text = Convert.ToString(DateTime.Today.Year + Math.Abs(vScrollBar1.Value - vScrollBar2.Value));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

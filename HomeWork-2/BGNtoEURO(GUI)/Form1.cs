﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGNtoEURO_GUI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertCurrency();
        }

        private void numericUpDownAmount_Click(object sender, EventArgs e)
        {

        }
        private void ConvertCurrency()
        {
            var BGN = this.numericUpDownAmount.Value;
            var EUR = BGN * 1.95583m;
            this.labelResult.Text = BGN + "BGN = " + Math.Round(EUR, 2) + "EUR";
        }
         }
}

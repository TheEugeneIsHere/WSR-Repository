﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeProject
{
    public partial class RunnerForm : MetroFramework.Forms.MetroForm
    {
        public RunnerForm()
        {
            InitializeComponent();
            this.Text = "MARATHON IS";
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorNet_Events
{
    public partial class Todos : Form
    {
        public Todos()
        {
            InitializeComponent();
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

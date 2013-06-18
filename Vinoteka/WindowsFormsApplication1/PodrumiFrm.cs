﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PodrumiFrm : Form
    {
        Podrum podrum;
        public PodrumiFrm()
        {
            InitializeComponent();
            podrum = new Podrum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            podrum.Adresa = adresa.Text;
            podrum.BrojMjesta = Convert.ToInt32(brojmjesta.Text);
            podrum.UnesiPodrum();
        }
    }
}

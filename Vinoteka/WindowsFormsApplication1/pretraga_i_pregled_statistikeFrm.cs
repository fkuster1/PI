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
    public partial class pretraga_i_pregled_statistikeFrm : Form
    {
        public pretraga_i_pregled_statistikeFrm()
        {
            InitializeComponent();
        }

        private void pretraga_i_pregled_statistike_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Bacve' table. You can move, or remove it, as needed.
            this.bacveTableAdapter.Fill(this.vinotekaDataSet1.Bacve);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Bacve' table. You can move, or remove it, as needed.
            //this.bacveTableAdapter.Fill(this.vinotekaDataSet1.Bacve);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vino' table. You can move, or remove it, as needed.
            this.vinoTableAdapter.Fill(this.vinotekaDataSet1.Vino);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Vinograd' table. You can move, or remove it, as needed.
            this.vinogradTableAdapter.Fill(this.vinotekaDataSet1.Vinograd);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Podrum' table. You can move, or remove it, as needed.
            this.podrumTableAdapter.Fill(this.vinotekaDataSet1.Podrum);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Obavljeni_poslovi' table. You can move, or remove it, as needed.
            this.obavljeni_posloviTableAdapter.Fill(this.vinotekaDataSet1.Obavljeni_poslovi);
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Poslovi' table. You can move, or remove it, as needed.
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            int podrum = (int)dataGridView3.CurrentRow.Cells[0].Value;
            this.bacveTableAdapter.PopuniBacve(vinotekaDataSet1.Bacve, podrum);
        }
    }
}

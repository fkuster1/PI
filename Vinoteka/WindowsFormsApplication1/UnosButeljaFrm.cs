using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class UnosButeljaFrm : Form
    {
        Butelje butelje;
        public UnosButeljaFrm()
        {
            InitializeComponent();
            this.CenterToScreen();
            butelje = new Butelje();

            //popunimo combobox bačvi
            var dataSource1 = new List<Comboi>();
            SqlDataReader myReader1 = Baza.Instance.DohvatiDataReader("SELECT Bacve.Id, 'Podrum:' + RTRIM(Podrum.Adresa) + ',  Id: ' + CAST(Bacve.Id AS VARCHAR(50)) AS nekaj FROM Bacve INNER JOIN Podrum ON Bacve.Podrum = Podrum.Id");
            if (myReader1.HasRows)
            {
                while (myReader1.Read())
                {
                    dataSource1.Add(new Comboi() { Name = myReader1[1].ToString(), Value = myReader1[0].ToString() });
                }
            }
            myReader1.Close();
            this.izbacve.DataSource = dataSource1;
            this.izbacve.DisplayMember = "Name";
            this.izbacve.ValueMember = "Value";
        }

        private void UnosButeljaFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vinotekaDataSet1.Bacve' table. You can move, or remove it, as needed.
            this.bacveTableAdapter.Fill(this.vinotekaDataSet1.Bacve);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            butelje.BrojButelji = Convert.ToInt32(brojbutelja.Text);
            butelje.Zapremnina = Convert.ToInt32(zapremnina.Text);
            butelje.SadrziVino = Convert.ToInt32(izbacve.SelectedValue);
            butelje.UnesiPodrum();
        }
    }
}

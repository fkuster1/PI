namespace WindowsFormsApplication1
{
    partial class UnosVinaFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.godina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.brlitara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vrstavina = new System.Windows.Forms.ComboBox();
            this.vrstavinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.vrsta_vinaTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.Vrsta_vinaTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kiselina = new System.Windows.Forms.TextBox();
            this.alkohol = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.vinovalozaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vinova_lozaTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.Vinova_lozaTableAdapter();
            this.vinovalozaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loze = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vrstavinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinovalozaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinovalozaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Godina proizvodnje";
            // 
            // godina
            // 
            this.godina.Location = new System.Drawing.Point(140, 40);
            this.godina.Name = "godina";
            this.godina.Size = new System.Drawing.Size(100, 20);
            this.godina.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj litara";
            // 
            // brlitara
            // 
            this.brlitara.Location = new System.Drawing.Point(140, 78);
            this.brlitara.Name = "brlitara";
            this.brlitara.Size = new System.Drawing.Size(100, 20);
            this.brlitara.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vrsta vina";
            // 
            // vrstavina
            // 
            this.vrstavina.DataSource = this.vrstavinaBindingSource;
            this.vrstavina.DisplayMember = "Ime";
            this.vrstavina.FormattingEnabled = true;
            this.vrstavina.Location = new System.Drawing.Point(140, 119);
            this.vrstavina.Name = "vrstavina";
            this.vrstavina.Size = new System.Drawing.Size(121, 21);
            this.vrstavina.TabIndex = 5;
            this.vrstavina.ValueMember = "Id";
            // 
            // vrstavinaBindingSource
            // 
            this.vrstavinaBindingSource.DataMember = "Vrsta_vina";
            this.vrstavinaBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // vinotekaDataSet1
            // 
            this.vinotekaDataSet1.DataSetName = "VinotekaDataSet1";
            this.vinotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vrsta_vinaTableAdapter
            // 
            this.vrsta_vinaTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kiselina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Alkohol";
            // 
            // kiselina
            // 
            this.kiselina.Location = new System.Drawing.Point(140, 162);
            this.kiselina.Name = "kiselina";
            this.kiselina.Size = new System.Drawing.Size(100, 20);
            this.kiselina.TabIndex = 8;
            // 
            // alkohol
            // 
            this.alkohol.Location = new System.Drawing.Point(140, 195);
            this.alkohol.Name = "alkohol";
            this.alkohol.Size = new System.Drawing.Size(100, 20);
            this.alkohol.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vinove loze";
            // 
            // vinovalozaBindingSource
            // 
            this.vinovalozaBindingSource.DataMember = "Vinova_loza";
            this.vinovalozaBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // vinova_lozaTableAdapter
            // 
            this.vinova_lozaTableAdapter.ClearBeforeFill = true;
            // 
            // vinovalozaBindingSource1
            // 
            this.vinovalozaBindingSource1.DataMember = "Vinova_loza";
            this.vinovalozaBindingSource1.DataSource = this.vinotekaDataSet1;
            // 
            // loze
            // 
            this.loze.FormattingEnabled = true;
            this.loze.Location = new System.Drawing.Point(140, 234);
            this.loze.Name = "loze";
            this.loze.Size = new System.Drawing.Size(260, 79);
            this.loze.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.vin;
            this.pictureBox1.Location = new System.Drawing.Point(281, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // UnosVinaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loze);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alkohol);
            this.Controls.Add(this.kiselina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vrstavina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brlitara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.godina);
            this.Controls.Add(this.label1);
            this.Name = "UnosVinaFrm";
            this.Text = "UnosVinaFrm";
            this.Load += new System.EventHandler(this.UnosVinaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vrstavinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinovalozaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinovalozaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox godina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brlitara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox vrstavina;
        private VinotekaDataSet1 vinotekaDataSet1;
        private System.Windows.Forms.BindingSource vrstavinaBindingSource;
        private VinotekaDataSet1TableAdapters.Vrsta_vinaTableAdapter vrsta_vinaTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kiselina;
        private System.Windows.Forms.TextBox alkohol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource vinovalozaBindingSource;
        private VinotekaDataSet1TableAdapters.Vinova_lozaTableAdapter vinova_lozaTableAdapter;
        private System.Windows.Forms.BindingSource vinovalozaBindingSource1;
        private System.Windows.Forms.CheckedListBox loze;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
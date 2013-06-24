namespace WindowsFormsApplication1
{
    partial class PosloviFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosloviFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trajanje = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.vinograd = new System.Windows.Forms.ComboBox();
            this.vinogradBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.vinogradTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.VinogradTableAdapter();
            this.podrum = new System.Windows.Forms.ComboBox();
            this.podrumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.podrumTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.PodrumTableAdapter();
            this.posao = new System.Windows.Forms.ComboBox();
            this.posloviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posloviTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.PosloviTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vinogradBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posloviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vinograd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podrum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(28, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(28, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opis posla";
            // 
            // opis
            // 
            this.opis.BackColor = System.Drawing.SystemColors.ControlDark;
            this.opis.Location = new System.Drawing.Point(124, 199);
            this.opis.Multiline = true;
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(434, 103);
            this.opis.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(31, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(31, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trajanje";
            // 
            // trajanje
            // 
            this.trajanje.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trajanje.Location = new System.Drawing.Point(124, 361);
            this.trajanje.Name = "trajanje";
            this.trajanje.Size = new System.Drawing.Size(138, 20);
            this.trajanje.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(273, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(273, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(12, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "FOI - 2013 Team Dignitas  ® All rights reserved";
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(124, 319);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(138, 20);
            this.datum.TabIndex = 15;
            // 
            // vinograd
            // 
            this.vinograd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.vinograd.DataSource = this.vinogradBindingSource;
            this.vinograd.DisplayMember = "Adresa";
            this.vinograd.FormattingEnabled = true;
            this.vinograd.Location = new System.Drawing.Point(122, 28);
            this.vinograd.Name = "vinograd";
            this.vinograd.Size = new System.Drawing.Size(140, 21);
            this.vinograd.TabIndex = 16;
            this.vinograd.ValueMember = "Id";
            this.vinograd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vinogradBindingSource
            // 
            this.vinogradBindingSource.DataMember = "Vinograd";
            this.vinogradBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // vinotekaDataSet1
            // 
            this.vinotekaDataSet1.DataSetName = "VinotekaDataSet1";
            this.vinotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vinogradTableAdapter
            // 
            this.vinogradTableAdapter.ClearBeforeFill = true;
            // 
            // podrum
            // 
            this.podrum.BackColor = System.Drawing.SystemColors.ControlDark;
            this.podrum.DataSource = this.podrumBindingSource;
            this.podrum.DisplayMember = "Adresa";
            this.podrum.FormattingEnabled = true;
            this.podrum.Location = new System.Drawing.Point(122, 85);
            this.podrum.Name = "podrum";
            this.podrum.Size = new System.Drawing.Size(140, 21);
            this.podrum.TabIndex = 17;
            this.podrum.ValueMember = "Id";
            // 
            // podrumBindingSource
            // 
            this.podrumBindingSource.DataMember = "Podrum";
            this.podrumBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // podrumTableAdapter
            // 
            this.podrumTableAdapter.ClearBeforeFill = true;
            // 
            // posao
            // 
            this.posao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.posao.DataSource = this.posloviBindingSource;
            this.posao.DisplayMember = "Ime";
            this.posao.FormattingEnabled = true;
            this.posao.Location = new System.Drawing.Point(122, 130);
            this.posao.Name = "posao";
            this.posao.Size = new System.Drawing.Size(140, 21);
            this.posao.TabIndex = 18;
            this.posao.ValueMember = "Id";
            // 
            // posloviBindingSource
            // 
            this.posloviBindingSource.DataMember = "Poslovi";
            this.posloviBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // posloviTableAdapter
            // 
            this.posloviTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.posao;
            this.pictureBox1.Location = new System.Drawing.Point(273, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // PosloviFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.posao);
            this.Controls.Add(this.podrum);
            this.Controls.Add(this.vinograd);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trajanje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PosloviFrm";
            this.Text = "Poslovi";
            this.Load += new System.EventHandler(this.Poslovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vinogradBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posloviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox opis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox trajanje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.ComboBox vinograd;
        private VinotekaDataSet1 vinotekaDataSet1;
        private System.Windows.Forms.BindingSource vinogradBindingSource;
        private VinotekaDataSet1TableAdapters.VinogradTableAdapter vinogradTableAdapter;
        private System.Windows.Forms.ComboBox podrum;
        private System.Windows.Forms.BindingSource podrumBindingSource;
        private VinotekaDataSet1TableAdapters.PodrumTableAdapter podrumTableAdapter;
        private System.Windows.Forms.ComboBox posao;
        private System.Windows.Forms.BindingSource posloviBindingSource;
        private VinotekaDataSet1TableAdapters.PosloviTableAdapter posloviTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
﻿namespace WindowsFormsApplication1
{
    partial class bacveFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bacveFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.proizvodac = new System.Windows.Forms.TextBox();
            this.zapremnina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.podrum = new System.Windows.Forms.ComboBox();
            this.podrumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.vrsta = new System.Windows.Forms.ComboBox();
            this.vrstabacviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.podrumTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.PodrumTableAdapter();
            this.vrsta_bacviTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.Vrsta_bacviTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.podrumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstabacviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(32, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proizvođač";
            // 
            // proizvodac
            // 
            this.proizvodac.BackColor = System.Drawing.SystemColors.ControlDark;
            this.proizvodac.Location = new System.Drawing.Point(127, 68);
            this.proizvodac.Name = "proizvodac";
            this.proizvodac.Size = new System.Drawing.Size(176, 20);
            this.proizvodac.TabIndex = 1;
            // 
            // zapremnina
            // 
            this.zapremnina.BackColor = System.Drawing.SystemColors.ControlDark;
            this.zapremnina.Location = new System.Drawing.Point(127, 110);
            this.zapremnina.Name = "zapremnina";
            this.zapremnina.Size = new System.Drawing.Size(176, 20);
            this.zapremnina.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(32, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zapremnina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(32, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vrsta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(32, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Podrum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(32, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "FOI - 2013 Team Dignitas  ® All rights reserved";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(32, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dodaj bačvu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(32, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // podrum
            // 
            this.podrum.DataSource = this.podrumBindingSource;
            this.podrum.DisplayMember = "Adresa";
            this.podrum.FormattingEnabled = true;
            this.podrum.Location = new System.Drawing.Point(127, 32);
            this.podrum.Name = "podrum";
            this.podrum.Size = new System.Drawing.Size(176, 21);
            this.podrum.TabIndex = 13;
            this.podrum.ValueMember = "Id";
            // 
            // podrumBindingSource
            // 
            this.podrumBindingSource.DataMember = "Podrum";
            this.podrumBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // vinotekaDataSet1
            // 
            this.vinotekaDataSet1.DataSetName = "VinotekaDataSet1";
            this.vinotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vrsta
            // 
            this.vrsta.DataSource = this.vrstabacviBindingSource;
            this.vrsta.DisplayMember = "Vrsta";
            this.vrsta.FormattingEnabled = true;
            this.vrsta.Location = new System.Drawing.Point(127, 158);
            this.vrsta.Name = "vrsta";
            this.vrsta.Size = new System.Drawing.Size(176, 21);
            this.vrsta.TabIndex = 14;
            this.vrsta.ValueMember = "Id";
            // 
            // vrstabacviBindingSource
            // 
            this.vrstabacviBindingSource.DataMember = "Vrsta_bacvi";
            this.vrstabacviBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // datum
            // 
            this.datum.Location = new System.Drawing.Point(127, 205);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(176, 20);
            this.datum.TabIndex = 15;
            // 
            // podrumTableAdapter
            // 
            this.podrumTableAdapter.ClearBeforeFill = true;
            // 
            // vrsta_bacviTableAdapter
            // 
            this.vrsta_bacviTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.bacva;
            this.pictureBox1.Location = new System.Drawing.Point(328, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // bacveFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(545, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.vrsta);
            this.Controls.Add(this.podrum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zapremnina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proizvodac);
            this.Controls.Add(this.label1);
            this.Name = "bacveFrm";
            this.Text = "Bačve";
            this.Load += new System.EventHandler(this.bacveFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.podrumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstabacviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox proizvodac;
        private System.Windows.Forms.TextBox zapremnina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox podrum;
        private System.Windows.Forms.ComboBox vrsta;
        private System.Windows.Forms.DateTimePicker datum;
        private VinotekaDataSet1 vinotekaDataSet1;
        private System.Windows.Forms.BindingSource podrumBindingSource;
        private VinotekaDataSet1TableAdapters.PodrumTableAdapter podrumTableAdapter;
        private System.Windows.Forms.BindingSource vrstabacviBindingSource;
        private VinotekaDataSet1TableAdapters.Vrsta_bacviTableAdapter vrsta_bacviTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
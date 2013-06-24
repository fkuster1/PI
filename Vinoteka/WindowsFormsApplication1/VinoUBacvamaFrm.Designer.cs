namespace WindowsFormsApplication1
{
    partial class VinoUBacvamaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VinoUBacvamaFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.brlitara = new System.Windows.Forms.TextBox();
            this.vino = new System.Windows.Forms.ComboBox();
            this.vinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.vinoTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.VinoTableAdapter();
            this.bacva = new System.Windows.Forms.ComboBox();
            this.bacveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bacveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bacveTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.BacveTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.preostalotxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.preostalooo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacveBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(352, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bačva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(352, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vino";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(352, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(409, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(352, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Broj litara";
            // 
            // brlitara
            // 
            this.brlitara.BackColor = System.Drawing.SystemColors.ControlDark;
            this.brlitara.Location = new System.Drawing.Point(484, 395);
            this.brlitara.Name = "brlitara";
            this.brlitara.Size = new System.Drawing.Size(277, 20);
            this.brlitara.TabIndex = 4;
            // 
            // vino
            // 
            this.vino.BackColor = System.Drawing.SystemColors.ControlDark;
            this.vino.DataSource = this.vinoBindingSource;
            this.vino.DisplayMember = "Id";
            this.vino.FormattingEnabled = true;
            this.vino.Location = new System.Drawing.Point(484, 321);
            this.vino.Name = "vino";
            this.vino.Size = new System.Drawing.Size(277, 21);
            this.vino.TabIndex = 5;
            this.vino.ValueMember = "Id";
            // 
            // vinoBindingSource
            // 
            this.vinoBindingSource.DataMember = "Vino";
            this.vinoBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // vinotekaDataSet1
            // 
            this.vinotekaDataSet1.DataSetName = "VinotekaDataSet1";
            this.vinotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vinoTableAdapter
            // 
            this.vinoTableAdapter.ClearBeforeFill = true;
            // 
            // bacva
            // 
            this.bacva.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bacva.DataSource = this.bacveBindingSource1;
            this.bacva.DisplayMember = "Id";
            this.bacva.FormattingEnabled = true;
            this.bacva.Location = new System.Drawing.Point(484, 285);
            this.bacva.Name = "bacva";
            this.bacva.Size = new System.Drawing.Size(277, 21);
            this.bacva.TabIndex = 6;
            this.bacva.ValueMember = "Id";
            this.bacva.SelectedIndexChanged += new System.EventHandler(this.bacva_SelectedIndexChanged);
            // 
            // bacveBindingSource1
            // 
            this.bacveBindingSource1.DataMember = "Bacve";
            this.bacveBindingSource1.DataSource = this.vinotekaDataSet1;
            // 
            // bacveBindingSource
            // 
            this.bacveBindingSource.DataMember = "Bacve";
            this.bacveBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // bacveTableAdapter
            // 
            this.bacveTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // preostalotxt
            // 
            this.preostalotxt.AutoSize = true;
            this.preostalotxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.preostalotxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preostalotxt.Location = new System.Drawing.Point(352, 363);
            this.preostalotxt.Name = "preostalotxt";
            this.preostalotxt.Size = new System.Drawing.Size(59, 15);
            this.preostalotxt.TabIndex = 8;
            this.preostalotxt.Text = "Preostalo: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(31, 733);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "FOI - 2013 Team Dignitas  ® All rights reserved";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(352, 666);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(409, 57);
            this.button2.TabIndex = 16;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // preostalooo
            // 
            this.preostalooo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.preostalooo.Location = new System.Drawing.Point(484, 358);
            this.preostalooo.Name = "preostalooo";
            this.preostalooo.Size = new System.Drawing.Size(277, 20);
            this.preostalooo.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(856, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(542, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // VinoUBacvamaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.preostalooo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.preostalotxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bacva);
            this.Controls.Add(this.vino);
            this.Controls.Add(this.brlitara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VinoUBacvamaFrm";
            this.Text = "VinuUBacvamaFrm";
            this.Load += new System.EventHandler(this.VinuUBacvamaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacveBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox brlitara;
        private System.Windows.Forms.ComboBox vino;
        private VinotekaDataSet1 vinotekaDataSet1;
        private System.Windows.Forms.BindingSource vinoBindingSource;
        private VinotekaDataSet1TableAdapters.VinoTableAdapter vinoTableAdapter;
        private System.Windows.Forms.ComboBox bacva;
        private System.Windows.Forms.BindingSource bacveBindingSource;
        private VinotekaDataSet1TableAdapters.BacveTableAdapter bacveTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label preostalotxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox preostalooo;
        private System.Windows.Forms.BindingSource bacveBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
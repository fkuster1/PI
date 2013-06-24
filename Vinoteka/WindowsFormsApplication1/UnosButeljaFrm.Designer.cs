namespace WindowsFormsApplication1
{
    partial class UnosButeljaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosButeljaFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.izbacve = new System.Windows.Forms.ComboBox();
            this.bacveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.bacveTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.BacveTableAdapter();
            this.brojbutelja = new System.Windows.Forms.TextBox();
            this.zapremnina = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bacveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(440, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iz bačve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(440, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zapremnina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(440, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj butelja";
            // 
            // izbacve
            // 
            this.izbacve.BackColor = System.Drawing.SystemColors.ControlDark;
            this.izbacve.DataSource = this.bacveBindingSource;
            this.izbacve.DisplayMember = "Id";
            this.izbacve.FormattingEnabled = true;
            this.izbacve.Location = new System.Drawing.Point(546, 176);
            this.izbacve.Name = "izbacve";
            this.izbacve.Size = new System.Drawing.Size(271, 21);
            this.izbacve.TabIndex = 3;
            this.izbacve.ValueMember = "Id";
            // 
            // bacveBindingSource
            // 
            this.bacveBindingSource.DataMember = "Bacve";
            this.bacveBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // vinotekaDataSet1
            // 
            this.vinotekaDataSet1.DataSetName = "VinotekaDataSet1";
            this.vinotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bacveTableAdapter
            // 
            this.bacveTableAdapter.ClearBeforeFill = true;
            // 
            // brojbutelja
            // 
            this.brojbutelja.BackColor = System.Drawing.SystemColors.ControlDark;
            this.brojbutelja.Location = new System.Drawing.Point(546, 208);
            this.brojbutelja.Name = "brojbutelja";
            this.brojbutelja.Size = new System.Drawing.Size(271, 20);
            this.brojbutelja.TabIndex = 4;
            // 
            // zapremnina
            // 
            this.zapremnina.BackColor = System.Drawing.SystemColors.ControlDark;
            this.zapremnina.Location = new System.Drawing.Point(546, 242);
            this.zapremnina.Name = "zapremnina";
            this.zapremnina.Size = new System.Drawing.Size(271, 20);
            this.zapremnina.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(440, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 73);
            this.button1.TabIndex = 6;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.butelja;
            this.pictureBox1.Location = new System.Drawing.Point(49, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(12, 746);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "FOI - 2013 Team Dignitas  ® All rights reserved";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(440, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(377, 78);
            this.button2.TabIndex = 16;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(926, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(428, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(533, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(360, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // UnosButeljaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zapremnina);
            this.Controls.Add(this.brojbutelja);
            this.Controls.Add(this.izbacve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnosButeljaFrm";
            this.Text = "UnosButeljaFrm";
            this.Load += new System.EventHandler(this.UnosButeljaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bacveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox izbacve;
        private VinotekaDataSet1 vinotekaDataSet1;
        private System.Windows.Forms.BindingSource bacveBindingSource;
        private VinotekaDataSet1TableAdapters.BacveTableAdapter bacveTableAdapter;
        private System.Windows.Forms.TextBox brojbutelja;
        private System.Windows.Forms.TextBox zapremnina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
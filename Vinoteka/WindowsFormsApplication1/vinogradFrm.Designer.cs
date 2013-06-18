namespace WindowsFormsApplication1
{
    partial class vinogradFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vinogradFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.TextBox();
            this.broj_cokota = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.datumSadnje = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj čokota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(26, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum sadnje";
            // 
            // adresa
            // 
            this.adresa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.adresa.Location = new System.Drawing.Point(111, 24);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(195, 20);
            this.adresa.TabIndex = 3;
            // 
            // broj_cokota
            // 
            this.broj_cokota.BackColor = System.Drawing.SystemColors.ControlDark;
            this.broj_cokota.Location = new System.Drawing.Point(111, 69);
            this.broj_cokota.Name = "broj_cokota";
            this.broj_cokota.Size = new System.Drawing.Size(195, 20);
            this.broj_cokota.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(416, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(416, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "FOI - 2013 Team Dignitas  ® All rights reserved";
            // 
            // datumSadnje
            // 
            this.datumSadnje.Location = new System.Drawing.Point(111, 122);
            this.datumSadnje.Name = "datumSadnje";
            this.datumSadnje.Size = new System.Drawing.Size(195, 20);
            this.datumSadnje.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // vinogradFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(663, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datumSadnje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.broj_cokota);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "vinogradFrm";
            this.Text = "Vinograd";
            this.Load += new System.EventHandler(this.vinograd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.TextBox broj_cokota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojcokotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemesadnjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datumSadnje;
        private System.Windows.Forms.Label label4;


    }
}
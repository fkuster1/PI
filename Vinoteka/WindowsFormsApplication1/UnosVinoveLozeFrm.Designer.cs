namespace WindowsFormsApplication1
{
    partial class UnosVinoveLozeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosVinoveLozeFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sorte = new System.Windows.Forms.ComboBox();
            this.sortaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.sortaTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.SortaTableAdapter();
            this.vinograd = new System.Windows.Forms.ComboBox();
            this.vinogradBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vinogradTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.VinogradTableAdapter();
            this.brojcokota = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sortaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinogradBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vinograd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(21, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj cokota";
            // 
            // sorte
            // 
            this.sorte.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sorte.DataSource = this.sortaBindingSource;
            this.sorte.DisplayMember = "Naziv";
            this.sorte.FormattingEnabled = true;
            this.sorte.Location = new System.Drawing.Point(106, 26);
            this.sorte.Name = "sorte";
            this.sorte.Size = new System.Drawing.Size(162, 21);
            this.sorte.TabIndex = 3;
            this.sorte.ValueMember = "Id";
            // 
            // sortaBindingSource
            // 
            this.sortaBindingSource.DataMember = "Sorta";
            this.sortaBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // vinotekaDataSet1
            // 
            this.vinotekaDataSet1.DataSetName = "VinotekaDataSet1";
            this.vinotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sortaTableAdapter
            // 
            this.sortaTableAdapter.ClearBeforeFill = true;
            // 
            // vinograd
            // 
            this.vinograd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.vinograd.DataSource = this.vinogradBindingSource;
            this.vinograd.DisplayMember = "Adresa";
            this.vinograd.FormattingEnabled = true;
            this.vinograd.Location = new System.Drawing.Point(106, 59);
            this.vinograd.Name = "vinograd";
            this.vinograd.Size = new System.Drawing.Size(162, 21);
            this.vinograd.TabIndex = 4;
            this.vinograd.ValueMember = "Id";
            // 
            // vinogradBindingSource
            // 
            this.vinogradBindingSource.DataMember = "Vinograd";
            this.vinogradBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // vinogradTableAdapter
            // 
            this.vinogradTableAdapter.ClearBeforeFill = true;
            // 
            // brojcokota
            // 
            this.brojcokota.BackColor = System.Drawing.SystemColors.ControlDark;
            this.brojcokota.Location = new System.Drawing.Point(106, 94);
            this.brojcokota.Name = "brojcokota";
            this.brojcokota.Size = new System.Drawing.Size(162, 20);
            this.brojcokota.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(21, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.loza;
            this.pictureBox1.Location = new System.Drawing.Point(311, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(12, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "FOI - 2013 Team Dignitas  ® All rights reserved";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(281, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UnosVinoveLozeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 233);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.brojcokota);
            this.Controls.Add(this.vinograd);
            this.Controls.Add(this.sorte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnosVinoveLozeFrm";
            this.Text = "UnosVinoveLozeFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UnosVinoveLozeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sortaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinogradBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sorte;
        private VinotekaDataSet1 vinotekaDataSet1;
        private System.Windows.Forms.BindingSource sortaBindingSource;
        private VinotekaDataSet1TableAdapters.SortaTableAdapter sortaTableAdapter;
        private System.Windows.Forms.ComboBox vinograd;
        private System.Windows.Forms.BindingSource vinogradBindingSource;
        private VinotekaDataSet1TableAdapters.VinogradTableAdapter vinogradTableAdapter;
        private System.Windows.Forms.TextBox brojcokota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}
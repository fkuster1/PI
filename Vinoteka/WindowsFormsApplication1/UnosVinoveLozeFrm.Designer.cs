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
            ((System.ComponentModel.ISupportInitialize)(this.sortaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinogradBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vinograd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj cokota";
            // 
            // sorte
            // 
            this.sorte.DataSource = this.sortaBindingSource;
            this.sorte.DisplayMember = "Naziv";
            this.sorte.FormattingEnabled = true;
            this.sorte.Location = new System.Drawing.Point(134, 41);
            this.sorte.Name = "sorte";
            this.sorte.Size = new System.Drawing.Size(121, 21);
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
            this.vinograd.DataSource = this.vinogradBindingSource;
            this.vinograd.DisplayMember = "Adresa";
            this.vinograd.FormattingEnabled = true;
            this.vinograd.Location = new System.Drawing.Point(134, 75);
            this.vinograd.Name = "vinograd";
            this.vinograd.Size = new System.Drawing.Size(121, 21);
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
            this.brojcokota.Location = new System.Drawing.Point(134, 101);
            this.brojcokota.Name = "brojcokota";
            this.brojcokota.Size = new System.Drawing.Size(121, 20);
            this.brojcokota.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.loza;
            this.pictureBox1.Location = new System.Drawing.Point(177, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UnosVinoveLozeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 300);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.brojcokota);
            this.Controls.Add(this.vinograd);
            this.Controls.Add(this.sorte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UnosVinoveLozeFrm";
            this.Text = "UnosVinoveLozeFrm";
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
    }
}
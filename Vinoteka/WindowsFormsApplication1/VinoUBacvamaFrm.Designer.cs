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
            this.bacveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bacveTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.BacveTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.preostalotxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bačva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vino";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Broj litara";
            // 
            // brlitara
            // 
            this.brlitara.Location = new System.Drawing.Point(69, 91);
            this.brlitara.Name = "brlitara";
            this.brlitara.Size = new System.Drawing.Size(100, 20);
            this.brlitara.TabIndex = 4;
            // 
            // vino
            // 
            this.vino.DataSource = this.vinoBindingSource;
            this.vino.DisplayMember = "Id";
            this.vino.FormattingEnabled = true;
            this.vino.Location = new System.Drawing.Point(69, 57);
            this.vino.Name = "vino";
            this.vino.Size = new System.Drawing.Size(121, 21);
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
            this.bacva.DataSource = this.bacveBindingSource;
            this.bacva.DisplayMember = "Id";
            this.bacva.FormattingEnabled = true;
            this.bacva.Location = new System.Drawing.Point(69, 21);
            this.bacva.Name = "bacva";
            this.bacva.Size = new System.Drawing.Size(121, 21);
            this.bacva.TabIndex = 6;
            this.bacva.ValueMember = "Id";
            this.bacva.SelectedIndexChanged += new System.EventHandler(this.bacva_SelectedIndexChanged);
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
            this.preostalotxt.Location = new System.Drawing.Point(211, 24);
            this.preostalotxt.Name = "preostalotxt";
            this.preostalotxt.Size = new System.Drawing.Size(57, 13);
            this.preostalotxt.TabIndex = 8;
            this.preostalotxt.Text = "Preostalo: ";
            // 
            // VinoUBacvamaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 258);
            this.Controls.Add(this.preostalotxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bacva);
            this.Controls.Add(this.vino);
            this.Controls.Add(this.brlitara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VinoUBacvamaFrm";
            this.Text = "VinuUBacvamaFrm";
            this.Load += new System.EventHandler(this.VinuUBacvamaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bacveBindingSource)).EndInit();
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
    }
}
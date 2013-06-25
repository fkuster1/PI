namespace WindowsFormsApplication1
{
    partial class ModifikacijaVinaFrm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label godina_proizvodnjeLabel;
            System.Windows.Forms.Label brojLitaraLabel;
            System.Windows.Forms.Label vrstaLabel;
            System.Windows.Forms.Label kiselinaLabel;
            System.Windows.Forms.Label alkoholLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifikacijaVinaFrm));
            this.button14 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alkoholTextBox = new System.Windows.Forms.TextBox();
            this.vinoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.kiselinaTextBox = new System.Windows.Forms.TextBox();
            this.vrstaTextBox = new System.Windows.Forms.TextBox();
            this.brojLitaraTextBox = new System.Windows.Forms.TextBox();
            this.godina_proizvodnjeTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.vinoTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.VinoTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.TableAdapterManager();
            this.vinoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vinoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            godina_proizvodnjeLabel = new System.Windows.Forms.Label();
            brojLitaraLabel = new System.Windows.Forms.Label();
            vrstaLabel = new System.Windows.Forms.Label();
            kiselinaLabel = new System.Windows.Forms.Label();
            alkoholLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vinoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinoBindingNavigator)).BeginInit();
            this.vinoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(28, 43);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // godina_proizvodnjeLabel
            // 
            godina_proizvodnjeLabel.AutoSize = true;
            godina_proizvodnjeLabel.Location = new System.Drawing.Point(28, 73);
            godina_proizvodnjeLabel.Name = "godina_proizvodnjeLabel";
            godina_proizvodnjeLabel.Size = new System.Drawing.Size(101, 13);
            godina_proizvodnjeLabel.TabIndex = 2;
            godina_proizvodnjeLabel.Text = "Godina proizvodnje:";
            // 
            // brojLitaraLabel
            // 
            brojLitaraLabel.AutoSize = true;
            brojLitaraLabel.Location = new System.Drawing.Point(28, 111);
            brojLitaraLabel.Name = "brojLitaraLabel";
            brojLitaraLabel.Size = new System.Drawing.Size(57, 13);
            brojLitaraLabel.TabIndex = 4;
            brojLitaraLabel.Text = "Broj Litara:";
            // 
            // vrstaLabel
            // 
            vrstaLabel.AutoSize = true;
            vrstaLabel.Location = new System.Drawing.Point(28, 151);
            vrstaLabel.Name = "vrstaLabel";
            vrstaLabel.Size = new System.Drawing.Size(34, 13);
            vrstaLabel.TabIndex = 6;
            vrstaLabel.Text = "Vrsta:";
            // 
            // kiselinaLabel
            // 
            kiselinaLabel.AutoSize = true;
            kiselinaLabel.Location = new System.Drawing.Point(28, 193);
            kiselinaLabel.Name = "kiselinaLabel";
            kiselinaLabel.Size = new System.Drawing.Size(46, 13);
            kiselinaLabel.TabIndex = 8;
            kiselinaLabel.Text = "Kiselina:";
            // 
            // alkoholLabel
            // 
            alkoholLabel.AutoSize = true;
            alkoholLabel.Location = new System.Drawing.Point(28, 233);
            alkoholLabel.Name = "alkoholLabel";
            alkoholLabel.Size = new System.Drawing.Size(45, 13);
            alkoholLabel.TabIndex = 10;
            alkoholLabel.Text = "Alkohol:";
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button14.Location = new System.Drawing.Point(399, 636);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(564, 53);
            this.button14.TabIndex = 17;
            this.button14.Text = "Zatvori";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(alkoholLabel);
            this.groupBox1.Controls.Add(this.alkoholTextBox);
            this.groupBox1.Controls.Add(kiselinaLabel);
            this.groupBox1.Controls.Add(this.kiselinaTextBox);
            this.groupBox1.Controls.Add(vrstaLabel);
            this.groupBox1.Controls.Add(this.vrstaTextBox);
            this.groupBox1.Controls.Add(brojLitaraLabel);
            this.groupBox1.Controls.Add(this.brojLitaraTextBox);
            this.groupBox1.Controls.Add(godina_proizvodnjeLabel);
            this.groupBox1.Controls.Add(this.godina_proizvodnjeTextBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Location = new System.Drawing.Point(42, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 260);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmjena";
            // 
            // alkoholTextBox
            // 
            this.alkoholTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vinoBindingSource, "Alkohol", true));
            this.alkoholTextBox.Location = new System.Drawing.Point(135, 226);
            this.alkoholTextBox.Name = "alkoholTextBox";
            this.alkoholTextBox.Size = new System.Drawing.Size(100, 20);
            this.alkoholTextBox.TabIndex = 11;
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
            // kiselinaTextBox
            // 
            this.kiselinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vinoBindingSource, "Kiselina", true));
            this.kiselinaTextBox.Location = new System.Drawing.Point(135, 186);
            this.kiselinaTextBox.Name = "kiselinaTextBox";
            this.kiselinaTextBox.Size = new System.Drawing.Size(100, 20);
            this.kiselinaTextBox.TabIndex = 9;
            // 
            // vrstaTextBox
            // 
            this.vrstaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vinoBindingSource, "Vrsta", true));
            this.vrstaTextBox.Location = new System.Drawing.Point(135, 148);
            this.vrstaTextBox.Name = "vrstaTextBox";
            this.vrstaTextBox.Size = new System.Drawing.Size(100, 20);
            this.vrstaTextBox.TabIndex = 7;
            // 
            // brojLitaraTextBox
            // 
            this.brojLitaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vinoBindingSource, "BrojLitara", true));
            this.brojLitaraTextBox.Location = new System.Drawing.Point(135, 108);
            this.brojLitaraTextBox.Name = "brojLitaraTextBox";
            this.brojLitaraTextBox.Size = new System.Drawing.Size(100, 20);
            this.brojLitaraTextBox.TabIndex = 5;
            // 
            // godina_proizvodnjeTextBox
            // 
            this.godina_proizvodnjeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vinoBindingSource, "Godina_proizvodnje", true));
            this.godina_proizvodnjeTextBox.Location = new System.Drawing.Point(135, 70);
            this.godina_proizvodnjeTextBox.Name = "godina_proizvodnjeTextBox";
            this.godina_proizvodnjeTextBox.Size = new System.Drawing.Size(100, 20);
            this.godina_proizvodnjeTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vinoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(135, 36);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // vinoTableAdapter
            // 
            this.vinoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BacveTableAdapter = null;
            this.tableAdapterManager.ButeljeTableAdapter = null;
            this.tableAdapterManager.Obavljeni_posloviTableAdapter = null;
            this.tableAdapterManager.PodrumTableAdapter = null;
            this.tableAdapterManager.PosloviTableAdapter = null;
            this.tableAdapterManager.SortaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.VinotekaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vino_je_odTableAdapter = null;
            this.tableAdapterManager.Vino_u_bacviTableAdapter = null;
            this.tableAdapterManager.VinogradTableAdapter = null;
            this.tableAdapterManager.VinoTableAdapter = this.vinoTableAdapter;
            this.tableAdapterManager.Vinova_lozaTableAdapter = null;
            this.tableAdapterManager.Vrsta_bacviTableAdapter = null;
            this.tableAdapterManager.Vrsta_vinaTableAdapter = null;
            // 
            // vinoBindingNavigator
            // 
            this.vinoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vinoBindingNavigator.BindingSource = this.vinoBindingSource;
            this.vinoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vinoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vinoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vinoBindingNavigatorSaveItem});
            this.vinoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vinoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vinoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vinoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vinoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vinoBindingNavigator.Name = "vinoBindingNavigator";
            this.vinoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vinoBindingNavigator.Size = new System.Drawing.Size(1350, 25);
            this.vinoBindingNavigator.TabIndex = 20;
            this.vinoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vinoBindingNavigatorSaveItem
            // 
            this.vinoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vinoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vinoBindingNavigatorSaveItem.Image")));
            this.vinoBindingNavigatorSaveItem.Name = "vinoBindingNavigatorSaveItem";
            this.vinoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vinoBindingNavigatorSaveItem.Text = "Save Data";
            this.vinoBindingNavigatorSaveItem.Click += new System.EventHandler(this.vinoBindingNavigatorSaveItem_Click);
            // 
            // ModifikacijaVinaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.vinoBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifikacijaVinaFrm";
            this.Text = "ModifikacijaVinaFrm";
            this.Load += new System.EventHandler(this.ModifikacijaVinaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vinoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinoBindingNavigator)).EndInit();
            this.vinoBindingNavigator.ResumeLayout(false);
            this.vinoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private VinotekaDataSet1 vinotekaDataSet1;
        private System.Windows.Forms.BindingSource vinoBindingSource;
        private VinotekaDataSet1TableAdapters.VinoTableAdapter vinoTableAdapter;
        private VinotekaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vinoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vinoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox alkoholTextBox;
        private System.Windows.Forms.TextBox kiselinaTextBox;
        private System.Windows.Forms.TextBox vrstaTextBox;
        private System.Windows.Forms.TextBox brojLitaraTextBox;
        private System.Windows.Forms.TextBox godina_proizvodnjeTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}
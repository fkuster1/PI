namespace WindowsFormsApplication1
{
    partial class ModifikacijaPodrumaFrm
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
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label broj_mjestaLabel;
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifikacijaPodrumaFrm));
            this.button14 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.podrumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.podrumTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.PodrumTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.TableAdapterManager();
            this.podrumBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.podrumBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.broj_mjestaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            adresaLabel = new System.Windows.Forms.Label();
            broj_mjestaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrumBindingNavigator)).BeginInit();
            this.podrumBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(17, 51);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 19;
            adresaLabel.Text = "Adresa:";
            // 
            // broj_mjestaLabel
            // 
            broj_mjestaLabel.AutoSize = true;
            broj_mjestaLabel.Location = new System.Drawing.Point(17, 77);
            broj_mjestaLabel.Name = "broj_mjestaLabel";
            broj_mjestaLabel.Size = new System.Drawing.Size(61, 13);
            broj_mjestaLabel.TabIndex = 20;
            broj_mjestaLabel.Text = "Broj mjesta:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(17, 29);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 22;
            idLabel.Text = "Id:";
            idLabel.Visible = false;
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button14.Location = new System.Drawing.Point(377, 682);
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
            this.pictureBox1.Location = new System.Drawing.Point(515, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // vinotekaDataSet1
            // 
            this.vinotekaDataSet1.DataSetName = "VinotekaDataSet1";
            this.vinotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BacveTableAdapter = null;
            this.tableAdapterManager.ButeljeTableAdapter = null;
            this.tableAdapterManager.Obavljeni_posloviTableAdapter = null;
            this.tableAdapterManager.PodrumTableAdapter = this.podrumTableAdapter;
            this.tableAdapterManager.PosloviTableAdapter = null;
            this.tableAdapterManager.SortaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.VinotekaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vino_je_odTableAdapter = null;
            this.tableAdapterManager.Vino_u_bacviTableAdapter = null;
            this.tableAdapterManager.VinogradTableAdapter = null;
            this.tableAdapterManager.VinoTableAdapter = null;
            this.tableAdapterManager.Vinova_lozaTableAdapter = null;
            this.tableAdapterManager.Vrsta_bacviTableAdapter = null;
            this.tableAdapterManager.Vrsta_vinaTableAdapter = null;
            // 
            // podrumBindingNavigator
            // 
            this.podrumBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.podrumBindingNavigator.BindingSource = this.podrumBindingSource;
            this.podrumBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.podrumBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.podrumBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.podrumBindingNavigatorSaveItem});
            this.podrumBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.podrumBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.podrumBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.podrumBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.podrumBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.podrumBindingNavigator.Name = "podrumBindingNavigator";
            this.podrumBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.podrumBindingNavigator.Size = new System.Drawing.Size(1370, 25);
            this.podrumBindingNavigator.TabIndex = 19;
            this.podrumBindingNavigator.Text = "bindingNavigator1";
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
            // podrumBindingNavigatorSaveItem
            // 
            this.podrumBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.podrumBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("podrumBindingNavigatorSaveItem.Image")));
            this.podrumBindingNavigatorSaveItem.Name = "podrumBindingNavigatorSaveItem";
            this.podrumBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.podrumBindingNavigatorSaveItem.Text = "Save Data";
            this.podrumBindingNavigatorSaveItem.Click += new System.EventHandler(this.podrumBindingNavigatorSaveItem_Click);
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podrumBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(66, 48);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresaTextBox.TabIndex = 20;
            // 
            // broj_mjestaTextBox
            // 
            this.broj_mjestaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podrumBindingSource, "Broj_mjesta", true));
            this.broj_mjestaTextBox.Location = new System.Drawing.Point(86, 74);
            this.broj_mjestaTextBox.Name = "broj_mjestaTextBox";
            this.broj_mjestaTextBox.Size = new System.Drawing.Size(80, 20);
            this.broj_mjestaTextBox.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.broj_mjestaTextBox);
            this.groupBox1.Controls.Add(broj_mjestaLabel);
            this.groupBox1.Controls.Add(this.adresaTextBox);
            this.groupBox1.Controls.Add(adresaLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 112);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmjena";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.podrumBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(66, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 23;
            // 
            // ModifikacijaPodrumaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.podrumBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifikacijaPodrumaFrm";
            this.Text = "ModifikacijaPodrumaFrm";
            this.Load += new System.EventHandler(this.ModifikacijaPodrumaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.podrumBindingNavigator)).EndInit();
            this.podrumBindingNavigator.ResumeLayout(false);
            this.podrumBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VinotekaDataSet1 vinotekaDataSet1;
        private System.Windows.Forms.BindingSource podrumBindingSource;
        private VinotekaDataSet1TableAdapters.PodrumTableAdapter podrumTableAdapter;
        private VinotekaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator podrumBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton podrumBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox broj_mjestaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idTextBox;
    }
}
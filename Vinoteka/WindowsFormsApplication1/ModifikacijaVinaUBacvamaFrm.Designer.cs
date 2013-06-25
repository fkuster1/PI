namespace WindowsFormsApplication1
{
    partial class ModifikacijaVinaUBacvamaFrm
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
            System.Windows.Forms.Label id_bacveLabel;
            System.Windows.Forms.Label id_vinaLabel;
            System.Windows.Forms.Label brojLitaraLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifikacijaVinaUBacvamaFrm));
            this.button14 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.brojLitaraTextBox = new System.Windows.Forms.TextBox();
            this.vino_u_bacviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.id_vinaTextBox = new System.Windows.Forms.TextBox();
            this.id_bacveTextBox = new System.Windows.Forms.TextBox();
            this.vino_u_bacviTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.Vino_u_bacviTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.TableAdapterManager();
            this.vino_u_bacviBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vino_u_bacviBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_bacveLabel = new System.Windows.Forms.Label();
            id_vinaLabel = new System.Windows.Forms.Label();
            brojLitaraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vino_u_bacviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vino_u_bacviBindingNavigator)).BeginInit();
            this.vino_u_bacviBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_bacveLabel
            // 
            id_bacveLabel.AutoSize = true;
            id_bacveLabel.Location = new System.Drawing.Point(22, 32);
            id_bacveLabel.Name = "id_bacveLabel";
            id_bacveLabel.Size = new System.Drawing.Size(52, 13);
            id_bacveLabel.TabIndex = 0;
            id_bacveLabel.Text = "Id bacve:";
            // 
            // id_vinaLabel
            // 
            id_vinaLabel.AutoSize = true;
            id_vinaLabel.Location = new System.Drawing.Point(32, 58);
            id_vinaLabel.Name = "id_vinaLabel";
            id_vinaLabel.Size = new System.Drawing.Size(42, 13);
            id_vinaLabel.TabIndex = 2;
            id_vinaLabel.Text = "Id vina:";
            // 
            // brojLitaraLabel
            // 
            brojLitaraLabel.AutoSize = true;
            brojLitaraLabel.Location = new System.Drawing.Point(17, 84);
            brojLitaraLabel.Name = "brojLitaraLabel";
            brojLitaraLabel.Size = new System.Drawing.Size(57, 13);
            brojLitaraLabel.TabIndex = 4;
            brojLitaraLabel.Text = "Broj Litara:";
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button14.Location = new System.Drawing.Point(461, 703);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(564, 53);
            this.button14.TabIndex = 18;
            this.button14.Text = "Zatvori";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(525, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(brojLitaraLabel);
            this.groupBox1.Controls.Add(this.brojLitaraTextBox);
            this.groupBox1.Controls.Add(id_vinaLabel);
            this.groupBox1.Controls.Add(this.id_vinaTextBox);
            this.groupBox1.Controls.Add(id_bacveLabel);
            this.groupBox1.Controls.Add(this.id_bacveTextBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 129);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmjena";
            // 
            // brojLitaraTextBox
            // 
            this.brojLitaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vino_u_bacviBindingSource, "BrojLitara", true));
            this.brojLitaraTextBox.Location = new System.Drawing.Point(80, 81);
            this.brojLitaraTextBox.Name = "brojLitaraTextBox";
            this.brojLitaraTextBox.Size = new System.Drawing.Size(100, 20);
            this.brojLitaraTextBox.TabIndex = 5;
            // 
            // vino_u_bacviBindingSource
            // 
            this.vino_u_bacviBindingSource.DataMember = "Vino_u_bacvi";
            this.vino_u_bacviBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // vinotekaDataSet1
            // 
            this.vinotekaDataSet1.DataSetName = "VinotekaDataSet1";
            this.vinotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_vinaTextBox
            // 
            this.id_vinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vino_u_bacviBindingSource, "Id_vina", true));
            this.id_vinaTextBox.Location = new System.Drawing.Point(80, 55);
            this.id_vinaTextBox.Name = "id_vinaTextBox";
            this.id_vinaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_vinaTextBox.TabIndex = 3;
            // 
            // id_bacveTextBox
            // 
            this.id_bacveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vino_u_bacviBindingSource, "Id_bacve", true));
            this.id_bacveTextBox.Location = new System.Drawing.Point(80, 29);
            this.id_bacveTextBox.Name = "id_bacveTextBox";
            this.id_bacveTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_bacveTextBox.TabIndex = 1;
            // 
            // vino_u_bacviTableAdapter
            // 
            this.vino_u_bacviTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Vino_u_bacviTableAdapter = this.vino_u_bacviTableAdapter;
            this.tableAdapterManager.VinogradTableAdapter = null;
            this.tableAdapterManager.VinoTableAdapter = null;
            this.tableAdapterManager.Vinova_lozaTableAdapter = null;
            this.tableAdapterManager.Vrsta_bacviTableAdapter = null;
            this.tableAdapterManager.Vrsta_vinaTableAdapter = null;
            // 
            // vino_u_bacviBindingNavigator
            // 
            this.vino_u_bacviBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vino_u_bacviBindingNavigator.BindingSource = this.vino_u_bacviBindingSource;
            this.vino_u_bacviBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vino_u_bacviBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vino_u_bacviBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vino_u_bacviBindingNavigatorSaveItem});
            this.vino_u_bacviBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vino_u_bacviBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vino_u_bacviBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vino_u_bacviBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vino_u_bacviBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vino_u_bacviBindingNavigator.Name = "vino_u_bacviBindingNavigator";
            this.vino_u_bacviBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vino_u_bacviBindingNavigator.Size = new System.Drawing.Size(1366, 25);
            this.vino_u_bacviBindingNavigator.TabIndex = 21;
            this.vino_u_bacviBindingNavigator.Text = "bindingNavigator1";
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
            // vino_u_bacviBindingNavigatorSaveItem
            // 
            this.vino_u_bacviBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vino_u_bacviBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vino_u_bacviBindingNavigatorSaveItem.Image")));
            this.vino_u_bacviBindingNavigatorSaveItem.Name = "vino_u_bacviBindingNavigatorSaveItem";
            this.vino_u_bacviBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vino_u_bacviBindingNavigatorSaveItem.Text = "Save Data";
            this.vino_u_bacviBindingNavigatorSaveItem.Click += new System.EventHandler(this.vino_u_bacviBindingNavigatorSaveItem_Click);
            // 
            // ModifikacijaVinaUBacvamaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.vino_u_bacviBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifikacijaVinaUBacvamaFrm";
            this.Text = "ModifikacijaVinaUBacvamaFrm";
            this.Load += new System.EventHandler(this.ModifikacijaVinaUBacvamaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vino_u_bacviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vino_u_bacviBindingNavigator)).EndInit();
            this.vino_u_bacviBindingNavigator.ResumeLayout(false);
            this.vino_u_bacviBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private VinotekaDataSet1 vinotekaDataSet1;
        private System.Windows.Forms.BindingSource vino_u_bacviBindingSource;
        private VinotekaDataSet1TableAdapters.Vino_u_bacviTableAdapter vino_u_bacviTableAdapter;
        private VinotekaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vino_u_bacviBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vino_u_bacviBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox brojLitaraTextBox;
        private System.Windows.Forms.TextBox id_vinaTextBox;
        private System.Windows.Forms.TextBox id_bacveTextBox;
    }
}
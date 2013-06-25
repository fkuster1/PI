namespace WindowsFormsApplication1
{
    partial class ModifikacijaButeljaFrm
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
            System.Windows.Forms.Label vino_iz_bacveLabel;
            System.Windows.Forms.Label brojButeljaLabel;
            System.Windows.Forms.Label zapremnina_buteljeLabel;
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifikacijaButeljaFrm));
            this.button14 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.buteljeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buteljeTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.ButeljeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.TableAdapterManager();
            this.buteljeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.buteljeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vino_iz_bacveTextBox = new System.Windows.Forms.TextBox();
            this.brojButeljaTextBox = new System.Windows.Forms.TextBox();
            this.zapremnina_buteljeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            vino_iz_bacveLabel = new System.Windows.Forms.Label();
            brojButeljaLabel = new System.Windows.Forms.Label();
            zapremnina_buteljeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buteljeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buteljeBindingNavigator)).BeginInit();
            this.buteljeBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vino_iz_bacveLabel
            // 
            vino_iz_bacveLabel.AutoSize = true;
            vino_iz_bacveLabel.Location = new System.Drawing.Point(21, 60);
            vino_iz_bacveLabel.Name = "vino_iz_bacveLabel";
            vino_iz_bacveLabel.Size = new System.Drawing.Size(74, 13);
            vino_iz_bacveLabel.TabIndex = 20;
            vino_iz_bacveLabel.Text = "Vino iz bacve:";
            // 
            // brojButeljaLabel
            // 
            brojButeljaLabel.AutoSize = true;
            brojButeljaLabel.Location = new System.Drawing.Point(21, 96);
            brojButeljaLabel.Name = "brojButeljaLabel";
            brojButeljaLabel.Size = new System.Drawing.Size(63, 13);
            brojButeljaLabel.TabIndex = 21;
            brojButeljaLabel.Text = "Broj Butelja:";
            // 
            // zapremnina_buteljeLabel
            // 
            zapremnina_buteljeLabel.AutoSize = true;
            zapremnina_buteljeLabel.Location = new System.Drawing.Point(21, 132);
            zapremnina_buteljeLabel.Name = "zapremnina_buteljeLabel";
            zapremnina_buteljeLabel.Size = new System.Drawing.Size(100, 13);
            zapremnina_buteljeLabel.TabIndex = 22;
            zapremnina_buteljeLabel.Text = "Zapremnina butelje:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(21, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 24;
            idLabel.Text = "Id:";
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button14.Location = new System.Drawing.Point(405, 669);
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
            this.pictureBox1.Location = new System.Drawing.Point(508, 107);
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
            // buteljeBindingSource
            // 
            this.buteljeBindingSource.DataMember = "Butelje";
            this.buteljeBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // buteljeTableAdapter
            // 
            this.buteljeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BacveTableAdapter = null;
            this.tableAdapterManager.ButeljeTableAdapter = this.buteljeTableAdapter;
            this.tableAdapterManager.Obavljeni_posloviTableAdapter = null;
            this.tableAdapterManager.PodrumTableAdapter = null;
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
            // buteljeBindingNavigator
            // 
            this.buteljeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.buteljeBindingNavigator.BindingSource = this.buteljeBindingSource;
            this.buteljeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.buteljeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.buteljeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.buteljeBindingNavigatorSaveItem});
            this.buteljeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.buteljeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.buteljeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.buteljeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.buteljeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.buteljeBindingNavigator.Name = "buteljeBindingNavigator";
            this.buteljeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.buteljeBindingNavigator.Size = new System.Drawing.Size(1366, 25);
            this.buteljeBindingNavigator.TabIndex = 19;
            this.buteljeBindingNavigator.Text = "bindingNavigator1";
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
            // buteljeBindingNavigatorSaveItem
            // 
            this.buteljeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buteljeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("buteljeBindingNavigatorSaveItem.Image")));
            this.buteljeBindingNavigatorSaveItem.Name = "buteljeBindingNavigatorSaveItem";
            this.buteljeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.buteljeBindingNavigatorSaveItem.Text = "Save Data";
            this.buteljeBindingNavigatorSaveItem.Click += new System.EventHandler(this.buteljeBindingNavigatorSaveItem_Click_1);
            // 
            // vino_iz_bacveTextBox
            // 
            this.vino_iz_bacveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buteljeBindingSource, "Vino_iz_bacve", true));
            this.vino_iz_bacveTextBox.Location = new System.Drawing.Point(127, 53);
            this.vino_iz_bacveTextBox.Name = "vino_iz_bacveTextBox";
            this.vino_iz_bacveTextBox.Size = new System.Drawing.Size(100, 20);
            this.vino_iz_bacveTextBox.TabIndex = 21;
            // 
            // brojButeljaTextBox
            // 
            this.brojButeljaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buteljeBindingSource, "BrojButelja", true));
            this.brojButeljaTextBox.Location = new System.Drawing.Point(127, 93);
            this.brojButeljaTextBox.Name = "brojButeljaTextBox";
            this.brojButeljaTextBox.Size = new System.Drawing.Size(100, 20);
            this.brojButeljaTextBox.TabIndex = 22;
            // 
            // zapremnina_buteljeTextBox
            // 
            this.zapremnina_buteljeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buteljeBindingSource, "Zapremnina_butelje", true));
            this.zapremnina_buteljeTextBox.Location = new System.Drawing.Point(127, 129);
            this.zapremnina_buteljeTextBox.Name = "zapremnina_buteljeTextBox";
            this.zapremnina_buteljeTextBox.Size = new System.Drawing.Size(100, 20);
            this.zapremnina_buteljeTextBox.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.vino_iz_bacveTextBox);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(vino_iz_bacveLabel);
            this.groupBox1.Controls.Add(zapremnina_buteljeLabel);
            this.groupBox1.Controls.Add(this.brojButeljaTextBox);
            this.groupBox1.Controls.Add(this.zapremnina_buteljeTextBox);
            this.groupBox1.Controls.Add(brojButeljaLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 171);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmjena";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buteljeBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(127, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 25;
            // 
            // ModifikacijaButeljaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buteljeBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button14);
            this.Name = "ModifikacijaButeljaFrm";
            this.Text = "ModifikacijaButeljaFrm";
            this.Load += new System.EventHandler(this.ModifikacijaButeljaFrm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buteljeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buteljeBindingNavigator)).EndInit();
            this.buteljeBindingNavigator.ResumeLayout(false);
            this.buteljeBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VinotekaDataSet1 vinotekaDataSet1;
        private System.Windows.Forms.BindingSource buteljeBindingSource;
        private VinotekaDataSet1TableAdapters.ButeljeTableAdapter buteljeTableAdapter;
        private VinotekaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator buteljeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton buteljeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vino_iz_bacveTextBox;
        private System.Windows.Forms.TextBox brojButeljaTextBox;
        private System.Windows.Forms.TextBox zapremnina_buteljeTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idTextBox;
    }
}
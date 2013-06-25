namespace WindowsFormsApplication1
{
    partial class ModifikacijaVinoveLozeFrm
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
            System.Windows.Forms.Label sortaLabel;
            System.Windows.Forms.Label brojCokotaLabel;
            System.Windows.Forms.Label vinogradLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifikacijaVinoveLozeFrm));
            this.button14 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vinogradTextBox = new System.Windows.Forms.TextBox();
            this.vinova_lozaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vinotekaDataSet1 = new WindowsFormsApplication1.VinotekaDataSet1();
            this.brojCokotaTextBox = new System.Windows.Forms.TextBox();
            this.sortaTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.vinova_lozaTableAdapter = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.Vinova_lozaTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.VinotekaDataSet1TableAdapters.TableAdapterManager();
            this.vinova_lozaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vinova_lozaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            sortaLabel = new System.Windows.Forms.Label();
            brojCokotaLabel = new System.Windows.Forms.Label();
            vinogradLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vinova_lozaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinova_lozaBindingNavigator)).BeginInit();
            this.vinova_lozaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(19, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // sortaLabel
            // 
            sortaLabel.AutoSize = true;
            sortaLabel.Location = new System.Drawing.Point(17, 48);
            sortaLabel.Name = "sortaLabel";
            sortaLabel.Size = new System.Drawing.Size(35, 13);
            sortaLabel.TabIndex = 2;
            sortaLabel.Text = "Sorta:";
            // 
            // brojCokotaLabel
            // 
            brojCokotaLabel.AutoSize = true;
            brojCokotaLabel.Location = new System.Drawing.Point(17, 74);
            brojCokotaLabel.Name = "brojCokotaLabel";
            brojCokotaLabel.Size = new System.Drawing.Size(65, 13);
            brojCokotaLabel.TabIndex = 4;
            brojCokotaLabel.Text = "Broj Cokota:";
            // 
            // vinogradLabel
            // 
            vinogradLabel.AutoSize = true;
            vinogradLabel.Location = new System.Drawing.Point(19, 100);
            vinogradLabel.Name = "vinogradLabel";
            vinogradLabel.Size = new System.Drawing.Size(52, 13);
            vinogradLabel.TabIndex = 6;
            vinogradLabel.Text = "Vinograd:";
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button14.Location = new System.Drawing.Point(436, 665);
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
            this.pictureBox1.Location = new System.Drawing.Point(533, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(vinogradLabel);
            this.groupBox1.Controls.Add(this.vinogradTextBox);
            this.groupBox1.Controls.Add(brojCokotaLabel);
            this.groupBox1.Controls.Add(this.brojCokotaTextBox);
            this.groupBox1.Controls.Add(sortaLabel);
            this.groupBox1.Controls.Add(this.sortaTextBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Location = new System.Drawing.Point(33, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 135);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmjena";
            // 
            // vinogradTextBox
            // 
            this.vinogradTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vinova_lozaBindingSource, "Vinograd", true));
            this.vinogradTextBox.Location = new System.Drawing.Point(95, 97);
            this.vinogradTextBox.Name = "vinogradTextBox";
            this.vinogradTextBox.Size = new System.Drawing.Size(100, 20);
            this.vinogradTextBox.TabIndex = 7;
            // 
            // vinova_lozaBindingSource
            // 
            this.vinova_lozaBindingSource.DataMember = "Vinova_loza";
            this.vinova_lozaBindingSource.DataSource = this.vinotekaDataSet1;
            // 
            // vinotekaDataSet1
            // 
            this.vinotekaDataSet1.DataSetName = "VinotekaDataSet1";
            this.vinotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brojCokotaTextBox
            // 
            this.brojCokotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vinova_lozaBindingSource, "BrojCokota", true));
            this.brojCokotaTextBox.Location = new System.Drawing.Point(95, 71);
            this.brojCokotaTextBox.Name = "brojCokotaTextBox";
            this.brojCokotaTextBox.Size = new System.Drawing.Size(100, 20);
            this.brojCokotaTextBox.TabIndex = 5;
            // 
            // sortaTextBox
            // 
            this.sortaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vinova_lozaBindingSource, "Sorta", true));
            this.sortaTextBox.Location = new System.Drawing.Point(95, 45);
            this.sortaTextBox.Name = "sortaTextBox";
            this.sortaTextBox.Size = new System.Drawing.Size(100, 20);
            this.sortaTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vinova_lozaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(95, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // vinova_lozaTableAdapter
            // 
            this.vinova_lozaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.VinoTableAdapter = null;
            this.tableAdapterManager.Vinova_lozaTableAdapter = this.vinova_lozaTableAdapter;
            this.tableAdapterManager.Vrsta_bacviTableAdapter = null;
            this.tableAdapterManager.Vrsta_vinaTableAdapter = null;
            // 
            // vinova_lozaBindingNavigator
            // 
            this.vinova_lozaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vinova_lozaBindingNavigator.BindingSource = this.vinova_lozaBindingSource;
            this.vinova_lozaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vinova_lozaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vinova_lozaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vinova_lozaBindingNavigatorSaveItem});
            this.vinova_lozaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vinova_lozaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vinova_lozaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vinova_lozaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vinova_lozaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vinova_lozaBindingNavigator.Name = "vinova_lozaBindingNavigator";
            this.vinova_lozaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vinova_lozaBindingNavigator.Size = new System.Drawing.Size(1350, 25);
            this.vinova_lozaBindingNavigator.TabIndex = 20;
            this.vinova_lozaBindingNavigator.Text = "bindingNavigator1";
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
            // vinova_lozaBindingNavigatorSaveItem
            // 
            this.vinova_lozaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vinova_lozaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vinova_lozaBindingNavigatorSaveItem.Image")));
            this.vinova_lozaBindingNavigatorSaveItem.Name = "vinova_lozaBindingNavigatorSaveItem";
            this.vinova_lozaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vinova_lozaBindingNavigatorSaveItem.Text = "Save Data";
            this.vinova_lozaBindingNavigatorSaveItem.Click += new System.EventHandler(this.vinova_lozaBindingNavigatorSaveItem_Click);
            // 
            // ModifikacijaVinoveLozeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.vinova_lozaBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifikacijaVinoveLozeFrm";
            this.Text = "ModifikacijaVinoveLozeFrm";
            this.Load += new System.EventHandler(this.ModifikacijaVinoveLozeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vinova_lozaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinotekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinova_lozaBindingNavigator)).EndInit();
            this.vinova_lozaBindingNavigator.ResumeLayout(false);
            this.vinova_lozaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private VinotekaDataSet1 vinotekaDataSet1;
        private System.Windows.Forms.BindingSource vinova_lozaBindingSource;
        private VinotekaDataSet1TableAdapters.Vinova_lozaTableAdapter vinova_lozaTableAdapter;
        private VinotekaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vinova_lozaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vinova_lozaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vinogradTextBox;
        private System.Windows.Forms.TextBox brojCokotaTextBox;
        private System.Windows.Forms.TextBox sortaTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}
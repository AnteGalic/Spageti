namespace Spageti
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pozadinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bojaSlovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemColorPickEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.spagetiDataSet = new Spageti.SpagetiDataSet();
            this.tableAdapterManager = new Spageti.SpagetiDataSetTableAdapters.TableAdapterManager();
            this.nazivArtiklaComboBox = new System.Windows.Forms.ComboBox();
            this.dbproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_productTableAdapter = new Spageti.SpagetiDataSetTableAdapters.db_productTableAdapter();
            this.prod_technologyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prod_technologyTableAdapter = new Spageti.SpagetiDataSetTableAdapters.prod_technologyTableAdapter();
            this.prod_technologyGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colprocessid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprocess_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prod_technology_linesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prod_technology_linesTableAdapter = new Spageti.SpagetiDataSetTableAdapters.prod_technology_linesTableAdapter();
            this.prod_technology_linesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperation_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloperation_description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.machine_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dbworkcenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.db_workcenterTableAdapter = new Spageti.SpagetiDataSetTableAdapters.db_workcenterTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spagetiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_technologyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_technologyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_technology_linesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_technology_linesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbworkcenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bojaToolStripMenuItem,
            this.izbrišiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 48);
            // 
            // bojaToolStripMenuItem
            // 
            this.bojaToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.bojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pozadinaToolStripMenuItem,
            this.obrubToolStripMenuItem,
            this.bojaSlovaToolStripMenuItem});
            this.bojaToolStripMenuItem.Name = "bojaToolStripMenuItem";
            this.bojaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.bojaToolStripMenuItem.Text = "Boja";
            // 
            // pozadinaToolStripMenuItem
            // 
            this.pozadinaToolStripMenuItem.Name = "pozadinaToolStripMenuItem";
            this.pozadinaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pozadinaToolStripMenuItem.Text = "Pozadina";
            this.pozadinaToolStripMenuItem.Click += new System.EventHandler(this.bojaPozadine);
            // 
            // obrubToolStripMenuItem
            // 
            this.obrubToolStripMenuItem.Name = "obrubToolStripMenuItem";
            this.obrubToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.obrubToolStripMenuItem.Text = "Obrub";
            this.obrubToolStripMenuItem.Click += new System.EventHandler(this.bojaBordera);
            // 
            // bojaSlovaToolStripMenuItem
            // 
            this.bojaSlovaToolStripMenuItem.Name = "bojaSlovaToolStripMenuItem";
            this.bojaSlovaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.bojaSlovaToolStripMenuItem.Text = "Boja Slova";
            this.bojaSlovaToolStripMenuItem.Click += new System.EventHandler(this.bojaSlova);
            // 
            // izbrišiToolStripMenuItem
            // 
            this.izbrišiToolStripMenuItem.Name = "izbrišiToolStripMenuItem";
            this.izbrišiToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.izbrišiToolStripMenuItem.Text = "Izbriši";
            this.izbrišiToolStripMenuItem.Click += new System.EventHandler(this.izbrisiButton);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemColorPickEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(1077, 128);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Buton";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Labela";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Dodaj novi buton";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemColorPickEdit1
            // 
            this.repositoryItemColorPickEdit1.AutoHeight = false;
            this.repositoryItemColorPickEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.repositoryItemColorPickEdit1.Name = "repositoryItemColorPickEdit1";
            // 
            // spagetiDataSet
            // 
            this.spagetiDataSet.DataSetName = "SpagetiDataSet";
            this.spagetiDataSet.EnforceConstraints = false;
            this.spagetiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ButonTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.db_productTableAdapter = null;
            this.tableAdapterManager.db_workcenterTableAdapter = null;
            this.tableAdapterManager.prod_technology_linesTableAdapter = null;
            this.tableAdapterManager.prod_technologyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Spageti.SpagetiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nazivArtiklaComboBox
            // 
            this.nazivArtiklaComboBox.DataSource = this.dbproductBindingSource;
            this.nazivArtiklaComboBox.DisplayMember = "aricle_name";
            this.nazivArtiklaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nazivArtiklaComboBox.FormattingEnabled = true;
            this.nazivArtiklaComboBox.Location = new System.Drawing.Point(12, 134);
            this.nazivArtiklaComboBox.Name = "nazivArtiklaComboBox";
            this.nazivArtiklaComboBox.Size = new System.Drawing.Size(417, 21);
            this.nazivArtiklaComboBox.TabIndex = 7;
            this.nazivArtiklaComboBox.ValueMember = "aricle_name";
            // 
            // dbproductBindingSource
            // 
            this.dbproductBindingSource.DataMember = "db_product";
            this.dbproductBindingSource.DataSource = this.spagetiDataSet;
            // 
            // db_productTableAdapter
            // 
            this.db_productTableAdapter.ClearBeforeFill = true;
            // 
            // prod_technologyBindingSource
            // 
            this.prod_technologyBindingSource.DataMember = "FK_db_product_prod_technology";
            this.prod_technologyBindingSource.DataSource = this.dbproductBindingSource;
            // 
            // prod_technologyTableAdapter
            // 
            this.prod_technologyTableAdapter.ClearBeforeFill = true;
            // 
            // prod_technologyGridControl
            // 
            this.prod_technologyGridControl.DataSource = this.prod_technologyBindingSource;
            gridLevelNode1.RelationName = "prod_technology_prod_technology_lines";
            this.prod_technologyGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.prod_technologyGridControl.Location = new System.Drawing.Point(12, 161);
            this.prod_technologyGridControl.MainView = this.gridView1;
            this.prod_technologyGridControl.MenuManager = this.ribbonControl1;
            this.prod_technologyGridControl.Name = "prod_technologyGridControl";
            this.prod_technologyGridControl.Size = new System.Drawing.Size(417, 214);
            this.prod_technologyGridControl.TabIndex = 9;
            this.prod_technologyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colprocessid,
            this.colprocess_name});
            this.gridView1.GridControl = this.prod_technologyGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colprocessid
            // 
            this.colprocessid.FieldName = "processid";
            this.colprocessid.Name = "colprocessid";
            this.colprocessid.OptionsColumn.AllowEdit = false;
            this.colprocessid.OptionsColumn.ReadOnly = true;
            this.colprocessid.Visible = true;
            this.colprocessid.VisibleIndex = 0;
            // 
            // colprocess_name
            // 
            this.colprocess_name.FieldName = "process_name";
            this.colprocess_name.Name = "colprocess_name";
            this.colprocess_name.OptionsColumn.AllowEdit = false;
            this.colprocess_name.OptionsColumn.ReadOnly = true;
            this.colprocess_name.Visible = true;
            this.colprocess_name.VisibleIndex = 1;
            // 
            // prod_technology_linesBindingSource
            // 
            this.prod_technology_linesBindingSource.DataMember = "prod_technology_prod_technology_lines";
            this.prod_technology_linesBindingSource.DataSource = this.prod_technologyBindingSource;
            // 
            // prod_technology_linesTableAdapter
            // 
            this.prod_technology_linesTableAdapter.ClearBeforeFill = true;
            // 
            // prod_technology_linesGridControl
            // 
            this.prod_technology_linesGridControl.DataSource = this.prod_technology_linesBindingSource;
            this.prod_technology_linesGridControl.Location = new System.Drawing.Point(12, 381);
            this.prod_technology_linesGridControl.MainView = this.gridView2;
            this.prod_technology_linesGridControl.MenuManager = this.ribbonControl1;
            this.prod_technology_linesGridControl.Name = "prod_technology_linesGridControl";
            this.prod_technology_linesGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemComboBox1});
            this.prod_technology_linesGridControl.Size = new System.Drawing.Size(417, 233);
            this.prod_technology_linesGridControl.TabIndex = 9;
            this.prod_technology_linesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.coloperation_name,
            this.coloperation_description,
            this.machine_id});
            this.gridView2.GridControl = this.prod_technology_linesGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colposition
            // 
            this.colposition.FieldName = "position";
            this.colposition.Name = "colposition";
            this.colposition.OptionsColumn.AllowEdit = false;
            this.colposition.OptionsColumn.ReadOnly = true;
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 2;
            // 
            // coloperation_name
            // 
            this.coloperation_name.FieldName = "operation_name";
            this.coloperation_name.Name = "coloperation_name";
            this.coloperation_name.OptionsColumn.AllowEdit = false;
            this.coloperation_name.OptionsColumn.ReadOnly = true;
            this.coloperation_name.Visible = true;
            this.coloperation_name.VisibleIndex = 0;
            // 
            // coloperation_description
            // 
            this.coloperation_description.FieldName = "operation_description";
            this.coloperation_description.Name = "coloperation_description";
            this.coloperation_description.OptionsColumn.AllowEdit = false;
            this.coloperation_description.OptionsColumn.ReadOnly = true;
            this.coloperation_description.Visible = true;
            this.coloperation_description.VisibleIndex = 1;
            // 
            // machine_id
            // 
            this.machine_id.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.machine_id.FieldName = "machine_id";
            this.machine_id.Name = "machine_id";
            this.machine_id.Visible = true;
            this.machine_id.VisibleIndex = 3;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.dbworkcenterBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "workcenter_id";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "workcenter_id";
            // 
            // dbworkcenterBindingSource
            // 
            this.dbworkcenterBindingSource.DataMember = "db_workcenter";
            this.dbworkcenterBindingSource.DataSource = this.spagetiDataSet;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // db_workcenterTableAdapter
            // 
            this.db_workcenterTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(447, 124);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(630, 510);
            this.panel1.TabIndex = 19;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(949, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Čekiraj Servus Mile";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(971, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1077, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prod_technology_linesGridControl);
            this.Controls.Add(this.prod_technologyGridControl);
            this.Controls.Add(this.nazivArtiklaComboBox);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.ShowMdiChildCaptionInParentTitle = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spagetiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_technologyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_technologyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_technology_linesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod_technology_linesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbworkcenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pozadinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbrišiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bojaSlovaToolStripMenuItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private SpagetiDataSet spagetiDataSet;
     //   private SpagetiDataSetTableAdapters.TehnoloskiListTehnologijaIDTableAdapter tehnoloskiListTehnologijaIDTableAdapter;
        private SpagetiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox nazivArtiklaComboBox;
        private System.Windows.Forms.BindingSource dbproductBindingSource;
        private SpagetiDataSetTableAdapters.db_productTableAdapter db_productTableAdapter;
        private System.Windows.Forms.BindingSource prod_technologyBindingSource;
        private SpagetiDataSetTableAdapters.prod_technologyTableAdapter prod_technologyTableAdapter;
        private DevExpress.XtraGrid.GridControl prod_technologyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colprocessid;
        private DevExpress.XtraGrid.Columns.GridColumn colprocess_name;
        private System.Windows.Forms.BindingSource prod_technology_linesBindingSource;
        private SpagetiDataSetTableAdapters.prod_technology_linesTableAdapter prod_technology_linesTableAdapter;
        private DevExpress.XtraGrid.GridControl prod_technology_linesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn coloperation_name;
        private DevExpress.XtraGrid.Columns.GridColumn coloperation_description;
        private DevExpress.XtraGrid.Columns.GridColumn machine_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource dbworkcenterBindingSource;
        private SpagetiDataSetTableAdapters.db_workcenterTableAdapter db_workcenterTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}


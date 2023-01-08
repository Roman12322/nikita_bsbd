namespace nikita
{
    partial class orders
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new nikita.Database1DataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new nikita.Database1DataSetTableAdapters.ordersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressfromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresstoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddriverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.catalogsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // catalogsToolStripMenuItem
            // 
            this.catalogsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarifToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.driversToolStripMenuItem});
            this.catalogsToolStripMenuItem.Name = "catalogsToolStripMenuItem";
            this.catalogsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.catalogsToolStripMenuItem.Text = "catalogs";
            // 
            // tarifToolStripMenuItem
            // 
            this.tarifToolStripMenuItem.Name = "tarifToolStripMenuItem";
            this.tarifToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tarifToolStripMenuItem.Text = "tarif";
            this.tarifToolStripMenuItem.Click += new System.EventHandler(this.tarifToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customersToolStripMenuItem.Text = "customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.driversToolStripMenuItem.Text = "drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idtarifDataGridViewTextBoxColumn,
            this.adressfromDataGridViewTextBoxColumn,
            this.adresstoDataGridViewTextBoxColumn,
            this.idcustomerDataGridViewTextBoxColumn,
            this.iddriverDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.database1DataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idtarifDataGridViewTextBoxColumn
            // 
            this.idtarifDataGridViewTextBoxColumn.DataPropertyName = "id_tarif";
            this.idtarifDataGridViewTextBoxColumn.HeaderText = "id_tarif";
            this.idtarifDataGridViewTextBoxColumn.Name = "idtarifDataGridViewTextBoxColumn";
            // 
            // adressfromDataGridViewTextBoxColumn
            // 
            this.adressfromDataGridViewTextBoxColumn.DataPropertyName = "adress_from";
            this.adressfromDataGridViewTextBoxColumn.HeaderText = "adress_from";
            this.adressfromDataGridViewTextBoxColumn.Name = "adressfromDataGridViewTextBoxColumn";
            // 
            // adresstoDataGridViewTextBoxColumn
            // 
            this.adresstoDataGridViewTextBoxColumn.DataPropertyName = "adress_to";
            this.adresstoDataGridViewTextBoxColumn.HeaderText = "adress_to";
            this.adresstoDataGridViewTextBoxColumn.Name = "adresstoDataGridViewTextBoxColumn";
            // 
            // idcustomerDataGridViewTextBoxColumn
            // 
            this.idcustomerDataGridViewTextBoxColumn.DataPropertyName = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.HeaderText = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.Name = "idcustomerDataGridViewTextBoxColumn";
            // 
            // iddriverDataGridViewTextBoxColumn
            // 
            this.iddriverDataGridViewTextBoxColumn.DataPropertyName = "id_driver";
            this.iddriverDataGridViewTextBoxColumn.HeaderText = "id_driver";
            this.iddriverDataGridViewTextBoxColumn.Name = "iddriverDataGridViewTextBoxColumn";
            // 
            // orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 194);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "orders";
            this.Text = "orders";
            this.Load += new System.EventHandler(this.orders_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Database1DataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtarifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresstoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddriverDataGridViewTextBoxColumn;
    }
}
namespace nikita
{
    partial class tarifs
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
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new nikita.Database1DataSet();
            this.tarifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarifTableAdapter = new nikita.Database1DataSetTableAdapters.tarifTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kidplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petplaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarif_categories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.show_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 17;
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
            this.ordersToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.driversToolStripMenuItem});
            this.catalogsToolStripMenuItem.Name = "catalogsToolStripMenuItem";
            this.catalogsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.catalogsToolStripMenuItem.Text = "catalogs";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordersToolStripMenuItem.Text = "orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
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
            this.costDataGridViewTextBoxColumn,
            this.kidplaceDataGridViewTextBoxColumn,
            this.petplaceDataGridViewTextBoxColumn,
            this.carclassDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tarifBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 280);
            this.dataGridView1.TabIndex = 18;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarifBindingSource
            // 
            this.tarifBindingSource.DataMember = "tarif";
            this.tarifBindingSource.DataSource = this.database1DataSet;
            // 
            // tarifTableAdapter
            // 
            this.tarifTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // kidplaceDataGridViewTextBoxColumn
            // 
            this.kidplaceDataGridViewTextBoxColumn.DataPropertyName = "kid_place";
            this.kidplaceDataGridViewTextBoxColumn.HeaderText = "kid_place";
            this.kidplaceDataGridViewTextBoxColumn.Name = "kidplaceDataGridViewTextBoxColumn";
            // 
            // petplaceDataGridViewTextBoxColumn
            // 
            this.petplaceDataGridViewTextBoxColumn.DataPropertyName = "pet_place";
            this.petplaceDataGridViewTextBoxColumn.HeaderText = "pet_place";
            this.petplaceDataGridViewTextBoxColumn.Name = "petplaceDataGridViewTextBoxColumn";
            // 
            // carclassDataGridViewTextBoxColumn
            // 
            this.carclassDataGridViewTextBoxColumn.DataPropertyName = "car_class";
            this.carclassDataGridViewTextBoxColumn.HeaderText = "car_class";
            this.carclassDataGridViewTextBoxColumn.Name = "carclassDataGridViewTextBoxColumn";
            // 
            // tarif_categories
            // 
            this.tarif_categories.FormattingEnabled = true;
            this.tarif_categories.Items.AddRange(new object[] {
            "with kid place",
            "with pet place",
            "luxury cars",
            "econom"});
            this.tarif_categories.Location = new System.Drawing.Point(348, 340);
            this.tarif_categories.Name = "tarif_categories";
            this.tarif_categories.Size = new System.Drawing.Size(209, 21);
            this.tarif_categories.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Типы тарифов для выбора";
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(13, 338);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(75, 23);
            this.show_button.TabIndex = 21;
            this.show_button.Text = "Show";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // tarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 385);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tarif_categories);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "tarifs";
            this.Text = "tarifs";
            this.Load += new System.EventHandler(this.tarifs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarifBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tarifBindingSource;
        private Database1DataSetTableAdapters.tarifTableAdapter tarifTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kidplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petplaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox tarif_categories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show_button;
    }
}
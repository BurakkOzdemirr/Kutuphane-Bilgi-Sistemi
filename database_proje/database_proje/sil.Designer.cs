namespace database_proje
{
    partial class sil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stokDataSet6 = new database_proje.stokDataSet6();
            this.ssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ssTableAdapter = new database_proje.stokDataSet6TableAdapters.ssTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.starih = new System.Windows.Forms.Label();
            this.skul = new System.Windows.Forms.Label();
            this.sskoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssmikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ektarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssaciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silmeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sstcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssubekoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skullaniciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sstarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sskoduDataGridViewTextBoxColumn,
            this.ssturuDataGridViewTextBoxColumn,
            this.ssadiDataGridViewTextBoxColumn,
            this.ssmikDataGridViewTextBoxColumn,
            this.ektarihiDataGridViewTextBoxColumn,
            this.Column2,
            this.Column3,
            this.ssaciklamaDataGridViewTextBoxColumn,
            this.Column1,
            this.silmeidDataGridViewTextBoxColumn,
            this.sstcDataGridViewTextBoxColumn,
            this.ssubekoduDataGridViewTextBoxColumn,
            this.skullaniciDataGridViewTextBoxColumn,
            this.sstarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ssBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(849, 160);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // stokDataSet6
            // 
            this.stokDataSet6.DataSetName = "stokDataSet6";
            this.stokDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ssBindingSource
            // 
            this.ssBindingSource.DataMember = "ss";
            this.ssBindingSource.DataSource = this.stokDataSet6;
            // 
            // ssTableAdapter
            // 
            this.ssTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(12, 195);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(62, 25);
            this.toolStrip1.TabIndex = 101;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "label1";
            // 
            // starih
            // 
            this.starih.AutoSize = true;
            this.starih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.starih.Location = new System.Drawing.Point(306, 195);
            this.starih.Name = "starih";
            this.starih.Size = new System.Drawing.Size(57, 20);
            this.starih.TabIndex = 102;
            this.starih.Text = "label1";
            // 
            // skul
            // 
            this.skul.AutoSize = true;
            this.skul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skul.Location = new System.Drawing.Point(657, 195);
            this.skul.Name = "skul";
            this.skul.Size = new System.Drawing.Size(57, 20);
            this.skul.TabIndex = 103;
            this.skul.Text = "label2";
            // 
            // sskoduDataGridViewTextBoxColumn
            // 
            this.sskoduDataGridViewTextBoxColumn.DataPropertyName = "sskodu";
            this.sskoduDataGridViewTextBoxColumn.HeaderText = "sskodu";
            this.sskoduDataGridViewTextBoxColumn.Name = "sskoduDataGridViewTextBoxColumn";
            this.sskoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.sskoduDataGridViewTextBoxColumn.Visible = false;
            // 
            // ssturuDataGridViewTextBoxColumn
            // 
            this.ssturuDataGridViewTextBoxColumn.DataPropertyName = "stokturu";
            this.ssturuDataGridViewTextBoxColumn.HeaderText = "Stok Türü";
            this.ssturuDataGridViewTextBoxColumn.Name = "ssturuDataGridViewTextBoxColumn";
            this.ssturuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ssadiDataGridViewTextBoxColumn
            // 
            this.ssadiDataGridViewTextBoxColumn.DataPropertyName = "ssadi";
            this.ssadiDataGridViewTextBoxColumn.HeaderText = "Stok Adı";
            this.ssadiDataGridViewTextBoxColumn.Name = "ssadiDataGridViewTextBoxColumn";
            this.ssadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ssmikDataGridViewTextBoxColumn
            // 
            this.ssmikDataGridViewTextBoxColumn.DataPropertyName = "ssmik";
            this.ssmikDataGridViewTextBoxColumn.HeaderText = "Stok Miktarı";
            this.ssmikDataGridViewTextBoxColumn.Name = "ssmikDataGridViewTextBoxColumn";
            this.ssmikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ektarihiDataGridViewTextBoxColumn
            // 
            this.ektarihiDataGridViewTextBoxColumn.DataPropertyName = "ektarihi";
            this.ektarihiDataGridViewTextBoxColumn.HeaderText = "Eklenme Tarihi";
            this.ektarihiDataGridViewTextBoxColumn.Name = "ektarihiDataGridViewTextBoxColumn";
            this.ektarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ad";
            this.Column2.HeaderText = "Ekleyen Kullanıcı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "subeadi";
            this.Column3.HeaderText = "Şube";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // ssaciklamaDataGridViewTextBoxColumn
            // 
            this.ssaciklamaDataGridViewTextBoxColumn.DataPropertyName = "ssaciklama";
            this.ssaciklamaDataGridViewTextBoxColumn.HeaderText = "Stok Açıklama";
            this.ssaciklamaDataGridViewTextBoxColumn.Name = "ssaciklamaDataGridViewTextBoxColumn";
            this.ssaciklamaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "silmeneden";
            this.Column1.HeaderText = "Silme Nedeni";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // silmeidDataGridViewTextBoxColumn
            // 
            this.silmeidDataGridViewTextBoxColumn.DataPropertyName = "silmeid";
            this.silmeidDataGridViewTextBoxColumn.HeaderText = "silmeid";
            this.silmeidDataGridViewTextBoxColumn.Name = "silmeidDataGridViewTextBoxColumn";
            this.silmeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.silmeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // sstcDataGridViewTextBoxColumn
            // 
            this.sstcDataGridViewTextBoxColumn.DataPropertyName = "sstc";
            this.sstcDataGridViewTextBoxColumn.HeaderText = "tc";
            this.sstcDataGridViewTextBoxColumn.Name = "sstcDataGridViewTextBoxColumn";
            this.sstcDataGridViewTextBoxColumn.ReadOnly = true;
            this.sstcDataGridViewTextBoxColumn.Visible = false;
            // 
            // ssubekoduDataGridViewTextBoxColumn
            // 
            this.ssubekoduDataGridViewTextBoxColumn.DataPropertyName = "ssubekodu";
            this.ssubekoduDataGridViewTextBoxColumn.HeaderText = "ssubekodu";
            this.ssubekoduDataGridViewTextBoxColumn.Name = "ssubekoduDataGridViewTextBoxColumn";
            this.ssubekoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.ssubekoduDataGridViewTextBoxColumn.Visible = false;
            // 
            // skullaniciDataGridViewTextBoxColumn
            // 
            this.skullaniciDataGridViewTextBoxColumn.DataPropertyName = "skullanici";
            this.skullaniciDataGridViewTextBoxColumn.HeaderText = "skullanici";
            this.skullaniciDataGridViewTextBoxColumn.Name = "skullaniciDataGridViewTextBoxColumn";
            this.skullaniciDataGridViewTextBoxColumn.ReadOnly = true;
            this.skullaniciDataGridViewTextBoxColumn.Visible = false;
            // 
            // sstarihDataGridViewTextBoxColumn
            // 
            this.sstarihDataGridViewTextBoxColumn.DataPropertyName = "sstarih";
            this.sstarihDataGridViewTextBoxColumn.HeaderText = "sstarih";
            this.sstarihDataGridViewTextBoxColumn.Name = "sstarihDataGridViewTextBoxColumn";
            this.sstarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.sstarihDataGridViewTextBoxColumn.Visible = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(873, 25);
            this.toolStrip2.TabIndex = 104;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::database_proje.Properties.Resources.arrow_curve_180;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 226);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.skul);
            this.Controls.Add(this.starih);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sil";
            this.Text = "sil";
            this.Load += new System.EventHandler(this.sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private stokDataSet6 stokDataSet6;
        private System.Windows.Forms.BindingSource ssBindingSource;
        private stokDataSet6TableAdapters.ssTableAdapter ssTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label starih;
        private System.Windows.Forms.Label skul;
        private System.Windows.Forms.DataGridViewTextBoxColumn sskoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssmikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ektarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssaciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn silmeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sstcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssubekoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skullaniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sstarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
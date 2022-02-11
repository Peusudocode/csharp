namespace DataRelation
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版者BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new DataRelation.Database1DataSet();
            this.出版者TableAdapter = new DataRelation.Database1DataSetTableAdapters.出版者TableAdapter();
            this.出版者書目BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.書目TableAdapter = new DataRelation.Database1DataSetTableAdapters.書目TableAdapter();
            this.書號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.書名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.書商DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.定價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.出版者BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.出版者書目BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "出版社";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.編號DataGridViewTextBoxColumn,
            this.出版者DataGridViewTextBoxColumn,
            this.電話DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.出版者BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 177);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "書目";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.書號DataGridViewTextBoxColumn,
            this.書名DataGridViewTextBoxColumn,
            this.作者DataGridViewTextBoxColumn,
            this.書商DataGridViewTextBoxColumn,
            this.定價DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.出版者書目BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 268);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(557, 182);
            this.dataGridView2.TabIndex = 1;
            // 
            // 編號DataGridViewTextBoxColumn
            // 
            this.編號DataGridViewTextBoxColumn.DataPropertyName = "編號";
            this.編號DataGridViewTextBoxColumn.HeaderText = "編號";
            this.編號DataGridViewTextBoxColumn.Name = "編號DataGridViewTextBoxColumn";
            // 
            // 出版者DataGridViewTextBoxColumn
            // 
            this.出版者DataGridViewTextBoxColumn.DataPropertyName = "出版者";
            this.出版者DataGridViewTextBoxColumn.HeaderText = "出版者";
            this.出版者DataGridViewTextBoxColumn.Name = "出版者DataGridViewTextBoxColumn";
            // 
            // 電話DataGridViewTextBoxColumn
            // 
            this.電話DataGridViewTextBoxColumn.DataPropertyName = "電話";
            this.電話DataGridViewTextBoxColumn.HeaderText = "電話";
            this.電話DataGridViewTextBoxColumn.Name = "電話DataGridViewTextBoxColumn";
            // 
            // 出版者BindingSource
            // 
            this.出版者BindingSource.DataMember = "出版者";
            this.出版者BindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 出版者TableAdapter
            // 
            this.出版者TableAdapter.ClearBeforeFill = true;
            // 
            // 出版者書目BindingSource
            // 
            this.出版者書目BindingSource.DataMember = "出版者_書目";
            this.出版者書目BindingSource.DataSource = this.出版者BindingSource;
            // 
            // 書目TableAdapter
            // 
            this.書目TableAdapter.ClearBeforeFill = true;
            // 
            // 書號DataGridViewTextBoxColumn
            // 
            this.書號DataGridViewTextBoxColumn.DataPropertyName = "書號";
            this.書號DataGridViewTextBoxColumn.HeaderText = "書號";
            this.書號DataGridViewTextBoxColumn.Name = "書號DataGridViewTextBoxColumn";
            // 
            // 書名DataGridViewTextBoxColumn
            // 
            this.書名DataGridViewTextBoxColumn.DataPropertyName = "書名";
            this.書名DataGridViewTextBoxColumn.HeaderText = "書名";
            this.書名DataGridViewTextBoxColumn.Name = "書名DataGridViewTextBoxColumn";
            // 
            // 作者DataGridViewTextBoxColumn
            // 
            this.作者DataGridViewTextBoxColumn.DataPropertyName = "作者";
            this.作者DataGridViewTextBoxColumn.HeaderText = "作者";
            this.作者DataGridViewTextBoxColumn.Name = "作者DataGridViewTextBoxColumn";
            // 
            // 書商DataGridViewTextBoxColumn
            // 
            this.書商DataGridViewTextBoxColumn.DataPropertyName = "書商";
            this.書商DataGridViewTextBoxColumn.HeaderText = "書商";
            this.書商DataGridViewTextBoxColumn.Name = "書商DataGridViewTextBoxColumn";
            // 
            // 定價DataGridViewTextBoxColumn
            // 
            this.定價DataGridViewTextBoxColumn.DataPropertyName = "定價";
            this.定價DataGridViewTextBoxColumn.HeaderText = "定價";
            this.定價DataGridViewTextBoxColumn.Name = "定價DataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 469);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.出版者BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.出版者書目BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource 出版者BindingSource;
        private Database1DataSetTableAdapters.出版者TableAdapter 出版者TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 出版者書目BindingSource;
        private Database1DataSetTableAdapters.書目TableAdapter 書目TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書商DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 定價DataGridViewTextBoxColumn;
    }
}


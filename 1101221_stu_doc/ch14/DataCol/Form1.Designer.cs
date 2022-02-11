namespace DataCol
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
            System.Windows.Forms.Label 姓名Label;
            System.Windows.Forms.Label 生日Label;
            System.Windows.Forms.Label 電話Label;
            System.Windows.Forms.Label 已婚Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.friendDataSet = new DataCol.friendDataSet();
            this.通訊錄BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.通訊錄TableAdapter = new DataCol.friendDataSetTableAdapters.通訊錄TableAdapter();
            this.tableAdapterManager = new DataCol.friendDataSetTableAdapters.TableAdapterManager();
            this.通訊錄BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.通訊錄BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.姓名TextBox = new System.Windows.Forms.TextBox();
            this.生日DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.電話TextBox = new System.Windows.Forms.TextBox();
            this.已婚CheckBox = new System.Windows.Forms.CheckBox();
            姓名Label = new System.Windows.Forms.Label();
            生日Label = new System.Windows.Forms.Label();
            電話Label = new System.Windows.Forms.Label();
            已婚Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.friendDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.通訊錄BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.通訊錄BindingNavigator)).BeginInit();
            this.通訊錄BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // 姓名Label
            // 
            姓名Label.AutoSize = true;
            姓名Label.Location = new System.Drawing.Point(29, 55);
            姓名Label.Name = "姓名Label";
            姓名Label.Size = new System.Drawing.Size(32, 12);
            姓名Label.TabIndex = 1;
            姓名Label.Text = "姓名:";
            // 
            // 生日Label
            // 
            生日Label.AutoSize = true;
            生日Label.Location = new System.Drawing.Point(29, 96);
            生日Label.Name = "生日Label";
            生日Label.Size = new System.Drawing.Size(32, 12);
            生日Label.TabIndex = 3;
            生日Label.Text = "生日:";
            // 
            // 電話Label
            // 
            電話Label.AutoSize = true;
            電話Label.Location = new System.Drawing.Point(29, 136);
            電話Label.Name = "電話Label";
            電話Label.Size = new System.Drawing.Size(32, 12);
            電話Label.TabIndex = 5;
            電話Label.Text = "電話:";
            // 
            // 已婚Label
            // 
            已婚Label.AutoSize = true;
            已婚Label.Location = new System.Drawing.Point(29, 182);
            已婚Label.Name = "已婚Label";
            已婚Label.Size = new System.Drawing.Size(32, 12);
            已婚Label.TabIndex = 7;
            已婚Label.Text = "已婚:";
            // 
            // friendDataSet
            // 
            this.friendDataSet.DataSetName = "friendDataSet";
            this.friendDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 通訊錄BindingSource
            // 
            this.通訊錄BindingSource.DataMember = "通訊錄";
            this.通訊錄BindingSource.DataSource = this.friendDataSet;
            // 
            // 通訊錄TableAdapter
            // 
            this.通訊錄TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DataCol.friendDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.通訊錄TableAdapter = this.通訊錄TableAdapter;
            // 
            // 通訊錄BindingNavigator
            // 
            this.通訊錄BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.通訊錄BindingNavigator.BindingSource = this.通訊錄BindingSource;
            this.通訊錄BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.通訊錄BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.通訊錄BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.通訊錄BindingNavigatorSaveItem});
            this.通訊錄BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.通訊錄BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.通訊錄BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.通訊錄BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.通訊錄BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.通訊錄BindingNavigator.Name = "通訊錄BindingNavigator";
            this.通訊錄BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.通訊錄BindingNavigator.Size = new System.Drawing.Size(331, 25);
            this.通訊錄BindingNavigator.TabIndex = 0;
            this.通訊錄BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
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
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // 通訊錄BindingNavigatorSaveItem
            // 
            this.通訊錄BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.通訊錄BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("通訊錄BindingNavigatorSaveItem.Image")));
            this.通訊錄BindingNavigatorSaveItem.Name = "通訊錄BindingNavigatorSaveItem";
            this.通訊錄BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.通訊錄BindingNavigatorSaveItem.Text = "儲存資料";
            this.通訊錄BindingNavigatorSaveItem.Click += new System.EventHandler(this.通訊錄BindingNavigatorSaveItem_Click);
            // 
            // 姓名TextBox
            // 
            this.姓名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.通訊錄BindingSource, "姓名", true));
            this.姓名TextBox.Location = new System.Drawing.Point(67, 52);
            this.姓名TextBox.Name = "姓名TextBox";
            this.姓名TextBox.Size = new System.Drawing.Size(100, 22);
            this.姓名TextBox.TabIndex = 2;
            // 
            // 生日DateTimePicker
            // 
            this.生日DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.通訊錄BindingSource, "生日", true));
            this.生日DateTimePicker.Location = new System.Drawing.Point(67, 92);
            this.生日DateTimePicker.Name = "生日DateTimePicker";
            this.生日DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.生日DateTimePicker.TabIndex = 4;
            // 
            // 電話TextBox
            // 
            this.電話TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.通訊錄BindingSource, "電話", true));
            this.電話TextBox.Location = new System.Drawing.Point(67, 133);
            this.電話TextBox.Name = "電話TextBox";
            this.電話TextBox.Size = new System.Drawing.Size(100, 22);
            this.電話TextBox.TabIndex = 6;
            // 
            // 已婚CheckBox
            // 
            this.已婚CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.通訊錄BindingSource, "已婚", true));
            this.已婚CheckBox.Location = new System.Drawing.Point(67, 177);
            this.已婚CheckBox.Name = "已婚CheckBox";
            this.已婚CheckBox.Size = new System.Drawing.Size(104, 24);
            this.已婚CheckBox.TabIndex = 8;
            this.已婚CheckBox.Text = "checkBox1";
            this.已婚CheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 234);
            this.Controls.Add(已婚Label);
            this.Controls.Add(this.已婚CheckBox);
            this.Controls.Add(電話Label);
            this.Controls.Add(this.電話TextBox);
            this.Controls.Add(生日Label);
            this.Controls.Add(this.生日DateTimePicker);
            this.Controls.Add(姓名Label);
            this.Controls.Add(this.姓名TextBox);
            this.Controls.Add(this.通訊錄BindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.friendDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.通訊錄BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.通訊錄BindingNavigator)).EndInit();
            this.通訊錄BindingNavigator.ResumeLayout(false);
            this.通訊錄BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private friendDataSet friendDataSet;
        private System.Windows.Forms.BindingSource 通訊錄BindingSource;
        private friendDataSetTableAdapters.通訊錄TableAdapter 通訊錄TableAdapter;
        private friendDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator 通訊錄BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton 通訊錄BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox 姓名TextBox;
        private System.Windows.Forms.DateTimePicker 生日DateTimePicker;
        private System.Windows.Forms.TextBox 電話TextBox;
        private System.Windows.Forms.CheckBox 已婚CheckBox;
    }
}


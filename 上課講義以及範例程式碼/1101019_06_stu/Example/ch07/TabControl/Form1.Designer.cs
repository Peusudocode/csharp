namespace TabControl
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdbM3 = new System.Windows.Forms.RadioButton();
            this.rdbＭ2 = new System.Windows.Forms.RadioButton();
            this.rdbＭ1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rdbS3 = new System.Windows.Forms.RadioButton();
            this.rdbS2 = new System.Windows.Forms.RadioButton();
            this.rdbS1 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rdbD4 = new System.Windows.Forms.RadioButton();
            this.rdbD3 = new System.Windows.Forms.RadioButton();
            this.rdbD2 = new System.Windows.Forms.RadioButton();
            this.rdbD1 = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.chkS = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "元";
            // 
            // txtAmt
            // 
            this.txtAmt.BackColor = System.Drawing.Color.Black;
            this.txtAmt.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmt.ForeColor = System.Drawing.Color.White;
            this.txtAmt.Location = new System.Drawing.Point(332, 152);
            this.txtAmt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.ReadOnly = true;
            this.txtAmt.Size = new System.Drawing.Size(94, 41);
            this.txtAmt.TabIndex = 33;
            this.txtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "＝";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(225, 158);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(54, 29);
            this.txtNum.TabIndex = 31;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "*  數量";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(74, 158);
            this.txtSum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(67, 29);
            this.txtSum.TabIndex = 29;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSum.TextChanged += new System.EventHandler(this.txtSum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "小計";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(15, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 124);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rdbM3);
            this.tabPage1.Controls.Add(this.rdbＭ2);
            this.tabPage1.Controls.Add(this.rdbＭ1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(446, 92);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主餐";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rdbM3
            // 
            this.rdbM3.AutoSize = true;
            this.rdbM3.Location = new System.Drawing.Point(12, 51);
            this.rdbM3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbM3.Name = "rdbM3";
            this.rdbM3.Size = new System.Drawing.Size(198, 22);
            this.rdbM3.TabIndex = 3;
            this.rdbM3.TabStop = true;
            this.rdbM3.Text = "C餐：三明治餐(50元)";
            this.rdbM3.UseVisualStyleBackColor = true;
            this.rdbM3.CheckedChanged += new System.EventHandler(this.rdbM3_CheckedChanged);
            // 
            // rdbＭ2
            // 
            this.rdbＭ2.AutoSize = true;
            this.rdbＭ2.Location = new System.Drawing.Point(236, 18);
            this.rdbＭ2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbＭ2.Name = "rdbＭ2";
            this.rdbＭ2.Size = new System.Drawing.Size(180, 22);
            this.rdbＭ2.TabIndex = 3;
            this.rdbＭ2.TabStop = true;
            this.rdbＭ2.Text = "B餐：漢堡餐(60元)";
            this.rdbＭ2.UseVisualStyleBackColor = true;
            this.rdbＭ2.CheckedChanged += new System.EventHandler(this.rdbM2_CheckedChanged);
            // 
            // rdbＭ1
            // 
            this.rdbＭ1.AutoSize = true;
            this.rdbＭ1.Checked = true;
            this.rdbＭ1.Location = new System.Drawing.Point(12, 18);
            this.rdbＭ1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbＭ1.Name = "rdbＭ1";
            this.rdbＭ1.Size = new System.Drawing.Size(181, 22);
            this.rdbＭ1.TabIndex = 2;
            this.rdbＭ1.TabStop = true;
            this.rdbＭ1.Text = "A餐：雞塊餐(75元)";
            this.rdbＭ1.UseVisualStyleBackColor = true;
            this.rdbＭ1.CheckedChanged += new System.EventHandler(this.rdbM1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rdbS3);
            this.tabPage2.Controls.Add(this.rdbS2);
            this.tabPage2.Controls.Add(this.rdbS1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(446, 92);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "副餐";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rdbS3
            // 
            this.rdbS3.AutoSize = true;
            this.rdbS3.Location = new System.Drawing.Point(225, 18);
            this.rdbS3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbS3.Name = "rdbS3";
            this.rdbS3.Size = new System.Drawing.Size(105, 22);
            this.rdbS3.TabIndex = 5;
            this.rdbS3.TabStop = true;
            this.rdbS3.Text = "生菜沙拉";
            this.rdbS3.UseVisualStyleBackColor = true;
            // 
            // rdbS2
            // 
            this.rdbS2.AutoSize = true;
            this.rdbS2.Location = new System.Drawing.Point(116, 18);
            this.rdbS2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbS2.Name = "rdbS2";
            this.rdbS2.Size = new System.Drawing.Size(69, 22);
            this.rdbS2.TabIndex = 4;
            this.rdbS2.TabStop = true;
            this.rdbS2.Text = "薯餅";
            this.rdbS2.UseVisualStyleBackColor = true;
            // 
            // rdbS1
            // 
            this.rdbS1.AutoSize = true;
            this.rdbS1.Checked = true;
            this.rdbS1.Location = new System.Drawing.Point(14, 18);
            this.rdbS1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbS1.Name = "rdbS1";
            this.rdbS1.Size = new System.Drawing.Size(69, 22);
            this.rdbS1.TabIndex = 3;
            this.rdbS1.TabStop = true;
            this.rdbS1.Text = "薯條";
            this.rdbS1.UseVisualStyleBackColor = true;
            this.rdbS1.CheckedChanged += new System.EventHandler(this.rdbS1_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rdbD4);
            this.tabPage3.Controls.Add(this.rdbD3);
            this.tabPage3.Controls.Add(this.rdbD2);
            this.tabPage3.Controls.Add(this.rdbD1);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(446, 92);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "飲料";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rdbD4
            // 
            this.rdbD4.AutoSize = true;
            this.rdbD4.Location = new System.Drawing.Point(273, 18);
            this.rdbD4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbD4.Name = "rdbD4";
            this.rdbD4.Size = new System.Drawing.Size(87, 22);
            this.rdbD4.TabIndex = 7;
            this.rdbD4.TabStop = true;
            this.rdbD4.Text = "冰咖啡";
            this.rdbD4.UseVisualStyleBackColor = true;
            // 
            // rdbD3
            // 
            this.rdbD3.AutoSize = true;
            this.rdbD3.Location = new System.Drawing.Point(174, 18);
            this.rdbD3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbD3.Name = "rdbD3";
            this.rdbD3.Size = new System.Drawing.Size(87, 22);
            this.rdbD3.TabIndex = 6;
            this.rdbD3.TabStop = true;
            this.rdbD3.Text = "鮮奶茶";
            this.rdbD3.UseVisualStyleBackColor = true;
            // 
            // rdbD2
            // 
            this.rdbD2.AutoSize = true;
            this.rdbD2.Location = new System.Drawing.Point(94, 18);
            this.rdbD2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbD2.Name = "rdbD2";
            this.rdbD2.Size = new System.Drawing.Size(69, 22);
            this.rdbD2.TabIndex = 5;
            this.rdbD2.TabStop = true;
            this.rdbD2.Text = "可樂";
            this.rdbD2.UseVisualStyleBackColor = true;
            // 
            // rdbD1
            // 
            this.rdbD1.AutoSize = true;
            this.rdbD1.Checked = true;
            this.rdbD1.Location = new System.Drawing.Point(15, 18);
            this.rdbD1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbD1.Name = "rdbD1";
            this.rdbD1.Size = new System.Drawing.Size(69, 22);
            this.rdbD1.TabIndex = 4;
            this.rdbD1.TabStop = true;
            this.rdbD1.Text = "雪碧";
            this.rdbD1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chkD);
            this.tabPage4.Controls.Add(this.chkS);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(446, 92);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "升級";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Location = new System.Drawing.Point(147, 20);
            this.chkD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(106, 22);
            this.chkD.TabIndex = 5;
            this.chkD.Text = "飲料加大";
            this.chkD.UseVisualStyleBackColor = true;
            this.chkD.CheckedChanged += new System.EventHandler(this.chkD_CheckedChanged);
            // 
            // chkS
            // 
            this.chkS.AutoSize = true;
            this.chkS.Location = new System.Drawing.Point(14, 20);
            this.chkS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkS.Name = "chkS";
            this.chkS.Size = new System.Drawing.Size(106, 22);
            this.chkS.TabIndex = 4;
            this.chkS.Text = "薯條加大";
            this.chkS.UseVisualStyleBackColor = true;
            this.chkS.CheckedChanged += new System.EventHandler(this.chkS_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 210);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "活力早餐店";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rdbＭ2;
        private System.Windows.Forms.RadioButton rdbＭ1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rdbS3;
        private System.Windows.Forms.RadioButton rdbS2;
        private System.Windows.Forms.RadioButton rdbS1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rdbD4;
        private System.Windows.Forms.RadioButton rdbD3;
        private System.Windows.Forms.RadioButton rdbD2;
        private System.Windows.Forms.RadioButton rdbD1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox chkD;
        private System.Windows.Forms.CheckBox chkS;
        private System.Windows.Forms.RadioButton rdbM3;

    }
}


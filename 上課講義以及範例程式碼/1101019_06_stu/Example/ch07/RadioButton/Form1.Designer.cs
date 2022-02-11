namespace RadioButton
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
            this.lblAns = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.lblOp = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAns
            // 
            this.lblAns.BackColor = System.Drawing.Color.DarkRed;
            this.lblAns.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAns.ForeColor = System.Drawing.Color.White;
            this.lblAns.Location = new System.Drawing.Point(158, 147);
            this.lblAns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(237, 48);
            this.lblAns.TabIndex = 27;
            this.lblAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(32, 153);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(93, 38);
            this.btnEqual.TabIndex = 26;
            this.btnEqual.Text = "＝";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // lblOp
            // 
            this.lblOp.Location = new System.Drawing.Point(160, 88);
            this.lblOp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(88, 34);
            this.lblOp.TabIndex = 25;
            this.lblOp.Text = "+";
            this.lblOp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(258, 88);
            this.txtN2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(118, 29);
            this.txtN2.TabIndex = 24;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(32, 88);
            this.txtN1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(118, 29);
            this.txtN1.TabIndex = 23;
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtN1.TextChanged += new System.EventHandler(this.txtN1_TextChanged);
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(324, 34);
            this.rdb4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(69, 22);
            this.rdb4.TabIndex = 22;
            this.rdb4.Text = "除法";
            this.rdb4.UseVisualStyleBackColor = true;
            this.rdb4.CheckedChanged += new System.EventHandler(this.rdb4_CheckedChanged);
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(226, 34);
            this.rdb3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(69, 22);
            this.rdb3.TabIndex = 21;
            this.rdb3.Text = "乘法";
            this.rdb3.UseVisualStyleBackColor = true;
            this.rdb3.CheckedChanged += new System.EventHandler(this.rdb3_CheckedChanged);
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(129, 34);
            this.rdb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(69, 22);
            this.rdb2.TabIndex = 20;
            this.rdb2.Text = "減法";
            this.rdb2.UseVisualStyleBackColor = true;
            this.rdb2.CheckedChanged += new System.EventHandler(this.rdb2_CheckedChanged);
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Checked = true;
            this.rdb1.Location = new System.Drawing.Point(32, 34);
            this.rdb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(69, 22);
            this.rdb1.TabIndex = 19;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "加法";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(674, 208);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 22);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 645);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.rdb4);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "四則運算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.CheckBox checkBox1;


    }
}


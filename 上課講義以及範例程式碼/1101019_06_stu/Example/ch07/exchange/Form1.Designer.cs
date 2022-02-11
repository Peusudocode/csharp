namespace exchange
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt50 = new System.Windows.Forms.TextBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.chk50 = new System.Windows.Forms.CheckBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(203, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "$1";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt1.Location = new System.Drawing.Point(200, 80);
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(40, 25);
            this.txt1.TabIndex = 20;
            // 
            // txt5
            // 
            this.txt5.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt5.Location = new System.Drawing.Point(138, 80);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(40, 25);
            this.txt5.TabIndex = 19;
            // 
            // txt10
            // 
            this.txt10.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt10.Location = new System.Drawing.Point(78, 80);
            this.txt10.Name = "txt10";
            this.txt10.ReadOnly = true;
            this.txt10.Size = new System.Drawing.Size(39, 25);
            this.txt10.TabIndex = 18;
            // 
            // txt50
            // 
            this.txt50.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt50.Location = new System.Drawing.Point(19, 80);
            this.txt50.Name = "txt50";
            this.txt50.ReadOnly = true;
            this.txt50.Size = new System.Drawing.Size(39, 25);
            this.txt50.TabIndex = 17;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk5.Location = new System.Drawing.Point(138, 55);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(40, 19);
            this.chk5.TabIndex = 16;
            this.chk5.Text = "$5";
            this.chk5.ThreeState = true;
            this.chk5.UseVisualStyleBackColor = true;
            this.chk5.CheckedChanged += new System.EventHandler(this.chk5_CheckedChanged);
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk10.Location = new System.Drawing.Point(78, 55);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(47, 19);
            this.chk10.TabIndex = 15;
            this.chk10.Text = "$10";
            this.chk10.UseVisualStyleBackColor = true;
            this.chk10.CheckedChanged += new System.EventHandler(this.chk10_CheckedChanged);
            // 
            // chk50
            // 
            this.chk50.AutoSize = true;
            this.chk50.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chk50.Location = new System.Drawing.Point(19, 55);
            this.chk50.Name = "chk50";
            this.chk50.Size = new System.Drawing.Size(47, 19);
            this.chk50.TabIndex = 14;
            this.chk50.Text = "$50";
            this.chk50.UseVisualStyleBackColor = true;
            this.chk50.CheckedChanged += new System.EventHandler(this.chk50_CheckedChanged);
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMoney.Location = new System.Drawing.Point(69, 13);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(88, 25);
            this.txtMoney.TabIndex = 13;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "金額：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 119);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt10);
            this.Controls.Add(this.txt50);
            this.Controls.Add(this.chk5);
            this.Controls.Add(this.chk10);
            this.Controls.Add(this.chk50);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "零錢兌換機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt50;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk10;
        private System.Windows.Forms.CheckBox chk50;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label1;

    }
}


namespace StreamReader1
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
            this.btnAll = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnChar = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(204, 87);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(80, 24);
            this.btnAll.TabIndex = 24;
            this.btnAll.Text = "整篇讀取";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnCls
            // 
            this.btnCls.Location = new System.Drawing.Point(204, 123);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(80, 24);
            this.btnCls.TabIndex = 23;
            this.btnCls.Text = "清除文字";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(204, 51);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(80, 24);
            this.btnLine.TabIndex = 22;
            this.btnLine.Text = "逐行讀取";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(204, 15);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(80, 24);
            this.btnChar.TabIndex = 21;
            this.btnChar.Text = "逐字元讀取";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // txtShow
            // 
            this.txtShow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtShow.Location = new System.Drawing.Point(12, 12);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShow.Size = new System.Drawing.Size(177, 135);
            this.txtShow.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 160);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.txtShow);
            this.Name = "Form1";
            this.Text = "StreamReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnChar;
        private System.Windows.Forms.TextBox txtShow;
    }
}


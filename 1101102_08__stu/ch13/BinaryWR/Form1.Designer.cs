namespace BinaryWR
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
            this.btnCls = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtPad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCls
            // 
            this.btnCls.Location = new System.Drawing.Point(185, 55);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(70, 24);
            this.btnCls.TabIndex = 15;
            this.btnCls.Text = "清除文字";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(185, 94);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(70, 24);
            this.btnRead.TabIndex = 14;
            this.btnRead.Text = "讀取檔案";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(185, 16);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(70, 24);
            this.btnWrite.TabIndex = 13;
            this.btnWrite.Text = "寫入檔案";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtPad
            // 
            this.txtPad.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPad.Location = new System.Drawing.Point(12, 12);
            this.txtPad.Multiline = true;
            this.txtPad.Name = "txtPad";
            this.txtPad.Size = new System.Drawing.Size(163, 130);
            this.txtPad.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 155);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtPad);
            this.Name = "Form1";
            this.Text = "BinaryWR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtPad;
    }
}


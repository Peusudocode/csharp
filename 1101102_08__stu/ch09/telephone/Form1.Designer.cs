namespace telephone
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
            this.vsbTel = new System.Windows.Forms.VScrollBar();
            this.hsbWidth = new System.Windows.Forms.HScrollBar();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vsbTel
            // 
            this.vsbTel.Location = new System.Drawing.Point(332, 9);
            this.vsbTel.Name = "vsbTel";
            this.vsbTel.Size = new System.Drawing.Size(17, 92);
            this.vsbTel.TabIndex = 1;
            this.vsbTel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbTel_Scroll);
            // 
            // hsbWidth
            // 
            this.hsbWidth.Location = new System.Drawing.Point(20, 132);
            this.hsbWidth.Name = "hsbWidth";
            this.hsbWidth.Size = new System.Drawing.Size(310, 17);
            this.hsbWidth.TabIndex = 2;
            this.hsbWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbWidth_Scroll);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("新細明體", 36F);
            this.txtTel.Location = new System.Drawing.Point(30, 36);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(100, 65);
            this.txtTel.TabIndex = 3;
            this.txtTel.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 176);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.hsbWidth);
            this.Controls.Add(this.vsbTel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vsbTel;
        private System.Windows.Forms.HScrollBar hsbWidth;
        private System.Windows.Forms.TextBox txtTel;
    }
}


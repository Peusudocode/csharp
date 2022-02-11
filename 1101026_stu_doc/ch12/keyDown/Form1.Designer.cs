namespace keyDown
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
            this.picP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picP)).BeginInit();
            this.SuspendLayout();
            // 
            // picP
            // 
            this.picP.Image = global::keyDown.Properties.Resources.pic;
            this.picP.Location = new System.Drawing.Point(174, 174);
            this.picP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picP.Name = "picP";
            this.picP.Size = new System.Drawing.Size(45, 45);
            this.picP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP.TabIndex = 1;
            this.picP.TabStop = false;
            this.picP.Click += new System.EventHandler(this.picP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 392);
            this.Controls.Add(this.picP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picP;
    }
}


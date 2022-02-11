namespace cs_FontColor
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.lblShow = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnFore = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.myColorDialog = new System.Windows.Forms.ColorDialog();
            this.myFontDialog = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShow.Location = new System.Drawing.Point(22, 26);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(280, 33);
            this.lblShow.TabIndex = 17;
            this.lblShow.Text = " VC# 2008是學習程式設計最佳的選擇";
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(217, 89);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(63, 26);
            this.btnFont.TabIndex = 16;
            this.btnFont.Text = "字型";
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnFore
            // 
            this.btnFore.Location = new System.Drawing.Point(35, 89);
            this.btnFore.Name = "btnFore";
            this.btnFore.Size = new System.Drawing.Size(64, 26);
            this.btnFore.TabIndex = 14;
            this.btnFore.Text = "前景色";
            this.btnFore.Click += new System.EventHandler(this.btnFore_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(128, 89);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 27);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "背景色";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // myFontDialog
            // 
            this.myFontDialog.ShowApply = true;
            this.myFontDialog.ShowHelp = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 149);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnFore);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblShow;
        internal System.Windows.Forms.Button btnFont;
        internal System.Windows.Forms.Button btnFore;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.ColorDialog myColorDialog;
        internal System.Windows.Forms.FontDialog myFontDialog;
    }
}


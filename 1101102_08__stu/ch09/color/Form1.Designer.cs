namespace color
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.tkbA = new System.Windows.Forms.TrackBar();
            this.tkbR = new System.Windows.Forms.TrackBar();
            this.tkbG = new System.Windows.Forms.TrackBar();
            this.tkbB = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tkbA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(246, 9);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(33, 12);
            this.lblA.TabIndex = 13;
            this.lblA.Text = "label5";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(25, 219);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(33, 12);
            this.lblB.TabIndex = 12;
            this.lblB.Text = "label4";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(25, 184);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(33, 12);
            this.lblG.TabIndex = 11;
            this.lblG.Text = "label3";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(25, 151);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(33, 12);
            this.lblR.TabIndex = 10;
            this.lblR.Text = "label2";
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor.Font = new System.Drawing.Font("新細明體", 16F);
            this.lblColor.Location = new System.Drawing.Point(38, 18);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(202, 115);
            this.lblColor.TabIndex = 9;
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tkbA
            // 
            this.tkbA.Location = new System.Drawing.Point(259, 24);
            this.tkbA.Maximum = 255;
            this.tkbA.Name = "tkbA";
            this.tkbA.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tkbA.Size = new System.Drawing.Size(45, 124);
            this.tkbA.TabIndex = 17;
            this.tkbA.TickFrequency = 10;
            this.tkbA.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tkbA.ValueChanged += new System.EventHandler(this.tkbA_ValueChanged);
            // 
            // tkbR
            // 
            this.tkbR.Location = new System.Drawing.Point(77, 151);
            this.tkbR.Maximum = 255;
            this.tkbR.Name = "tkbR";
            this.tkbR.Size = new System.Drawing.Size(163, 45);
            this.tkbR.TabIndex = 18;
            this.tkbR.TickFrequency = 10;
            this.tkbR.ValueChanged += new System.EventHandler(this.tkbR_ValueChanged);
            // 
            // tkbG
            // 
            this.tkbG.Location = new System.Drawing.Point(77, 184);
            this.tkbG.Maximum = 255;
            this.tkbG.Name = "tkbG";
            this.tkbG.Size = new System.Drawing.Size(163, 45);
            this.tkbG.TabIndex = 18;
            this.tkbG.TickFrequency = 10;
            this.tkbG.ValueChanged += new System.EventHandler(this.tkbG_ValueChanged);
            // 
            // tkbB
            // 
            this.tkbB.Location = new System.Drawing.Point(77, 219);
            this.tkbB.Maximum = 255;
            this.tkbB.Name = "tkbB";
            this.tkbB.Size = new System.Drawing.Size(163, 45);
            this.tkbB.TabIndex = 18;
            this.tkbB.TickFrequency = 10;
            this.tkbB.ValueChanged += new System.EventHandler(this.tkbB_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.tkbB);
            this.Controls.Add(this.tkbG);
            this.Controls.Add(this.tkbR);
            this.Controls.Add(this.tkbA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TrackBar tkbA;
        private System.Windows.Forms.TrackBar tkbR;
        private System.Windows.Forms.TrackBar tkbG;
        private System.Windows.Forms.TrackBar tkbB;

    }
}


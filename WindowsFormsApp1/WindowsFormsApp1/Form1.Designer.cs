namespace WindowsFormsApp1
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCal = new System.Windows.Forms.Button();
            this.Principal = new System.Windows.Forms.Label();
            this.Years = new System.Windows.Forms.Label();
            this.Rate = new System.Windows.Forms.Label();
            this.txtCapi = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(586, 215);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 0;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // Principal
            // 
            this.Principal.AutoSize = true;
            this.Principal.Location = new System.Drawing.Point(190, 90);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(70, 18);
            this.Principal.TabIndex = 1;
            this.Principal.Text = "Principal";
            // 
            // Years
            // 
            this.Years.AutoSize = true;
            this.Years.Location = new System.Drawing.Point(193, 182);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(49, 18);
            this.Years.TabIndex = 2;
            this.Years.Text = "Years";
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Location = new System.Drawing.Point(465, 101);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(66, 18);
            this.Rate.TabIndex = 3;
            this.Rate.Text = "Rate(%)";
            // 
            // txtCapi
            // 
            this.txtCapi.Location = new System.Drawing.Point(309, 90);
            this.txtCapi.Name = "txtCapi";
            this.txtCapi.Size = new System.Drawing.Size(100, 29);
            this.txtCapi.TabIndex = 4;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(309, 171);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 29);
            this.txtYear.TabIndex = 5;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(561, 98);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 29);
            this.txtRate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtCapi);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.Years);
            this.Controls.Add(this.Principal);
            this.Controls.Add(this.btnCal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label Principal;
        private System.Windows.Forms.Label Years;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.TextBox txtCapi;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label4;
    }
}


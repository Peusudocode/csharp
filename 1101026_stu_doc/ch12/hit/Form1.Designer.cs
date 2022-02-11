namespace hit
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
            this.components = new System.ComponentModel.Container();
            this.tmrT = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMiss = new System.Windows.Forms.Label();
            this.lblHit = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmrT
            // 
            this.tmrT.Tick += new System.EventHandler(this.tmrT_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblTime.Location = new System.Drawing.Point(33, 254);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 16);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "00.0秒";
            // 
            // lblMiss
            // 
            this.lblMiss.AutoSize = true;
            this.lblMiss.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblMiss.Location = new System.Drawing.Point(129, 254);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(88, 16);
            this.lblMiss.TabIndex = 16;
            this.lblMiss.Text = "失誤： 0 次";
            // 
            // lblHit
            // 
            this.lblHit.AutoSize = true;
            this.lblHit.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblHit.Location = new System.Drawing.Point(129, 226);
            this.lblHit.Name = "lblHit";
            this.lblHit.Size = new System.Drawing.Size(88, 16);
            this.lblHit.TabIndex = 15;
            this.lblHit.Text = "擊中： 0 次";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(35, 226);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("新細明體", 40F);
            this.btn9.Location = new System.Drawing.Point(167, 159);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 60);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "button1";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("新細明體", 40F);
            this.btn8.Location = new System.Drawing.Point(101, 159);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 60);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "button1";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("新細明體", 40F);
            this.btn7.Location = new System.Drawing.Point(35, 159);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 60);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "button1";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("新細明體", 40F);
            this.btn6.Location = new System.Drawing.Point(167, 93);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "button1";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("新細明體", 40F);
            this.btn5.Location = new System.Drawing.Point(101, 93);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "button1";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("新細明體", 40F);
            this.btn4.Location = new System.Drawing.Point(35, 93);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "button1";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("新細明體", 40F);
            this.btn3.Location = new System.Drawing.Point(167, 27);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "button1";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("新細明體", 40F);
            this.btn2.Location = new System.Drawing.Point(101, 27);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "button1";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("新細明體", 40F);
            this.btn1.Location = new System.Drawing.Point(35, 27);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 296);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMiss);
            this.Controls.Add(this.lblHit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "打地鼠";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrT;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMiss;
        private System.Windows.Forms.Label lblHit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
    }
}


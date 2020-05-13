namespace RandomNumberCounter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_cal_num = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(249, 380);
            this.textBox1.TabIndex = 1;
            // 
            // btn_cal_num
            // 
            this.btn_cal_num.Location = new System.Drawing.Point(39, 34);
            this.btn_cal_num.Name = "btn_cal_num";
            this.btn_cal_num.Size = new System.Drawing.Size(206, 54);
            this.btn_cal_num.TabIndex = 0;
            this.btn_cal_num.Text = "Find Frequency of Numbers";
            this.btn_cal_num.UseVisualStyleBackColor = true;
            this.btn_cal_num.Click += new System.EventHandler(this.btn_cal_num_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(39, 106);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(206, 54);
            this.clear_btn.TabIndex = 2;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_cal_num);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_cal_num;
        private System.Windows.Forms.Button clear_btn;
    }
}


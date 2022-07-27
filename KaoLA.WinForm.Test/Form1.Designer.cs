
namespace KaoLA.WinForm.Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.TextBox();
            this.BtnRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NUM = new System.Windows.Forms.TextBox();
            this.Msg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Stxt = new System.Windows.Forms.TextBox();
            this.Etxt = new System.Windows.Forms.TextBox();
            this.JsonTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OverTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // URL
            // 
            this.URL.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.URL.Location = new System.Drawing.Point(84, 19);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(519, 32);
            this.URL.TabIndex = 1;
            // 
            // BtnRequest
            // 
            this.BtnRequest.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRequest.Location = new System.Drawing.Point(624, 16);
            this.BtnRequest.Name = "BtnRequest";
            this.BtnRequest.Size = new System.Drawing.Size(75, 37);
            this.BtnRequest.TabIndex = 2;
            this.BtnRequest.Text = "提交";
            this.BtnRequest.UseVisualStyleBackColor = true;
            this.BtnRequest.Click += new System.EventHandler(this.BtnRequest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "并发请求";
            // 
            // NUM
            // 
            this.NUM.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NUM.Location = new System.Drawing.Point(123, 67);
            this.NUM.Name = "NUM";
            this.NUM.Size = new System.Drawing.Size(129, 32);
            this.NUM.TabIndex = 5;
            // 
            // Msg
            // 
            this.Msg.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Msg.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Msg.Location = new System.Drawing.Point(25, 148);
            this.Msg.Multiline = true;
            this.Msg.Name = "Msg";
            this.Msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Msg.Size = new System.Drawing.Size(752, 341);
            this.Msg.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(35, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(370, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "End";
            // 
            // Stxt
            // 
            this.Stxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Stxt.Location = new System.Drawing.Point(106, 112);
            this.Stxt.Name = "Stxt";
            this.Stxt.Size = new System.Drawing.Size(246, 28);
            this.Stxt.TabIndex = 9;
            // 
            // Etxt
            // 
            this.Etxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Etxt.Location = new System.Drawing.Point(426, 112);
            this.Etxt.Name = "Etxt";
            this.Etxt.Size = new System.Drawing.Size(241, 28);
            this.Etxt.TabIndex = 10;
            // 
            // JsonTxt
            // 
            this.JsonTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JsonTxt.Location = new System.Drawing.Point(793, 148);
            this.JsonTxt.Multiline = true;
            this.JsonTxt.Name = "JsonTxt";
            this.JsonTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.JsonTxt.Size = new System.Drawing.Size(223, 341);
            this.JsonTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(793, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Json Body";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(426, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "耗时";
            // 
            // OverTime
            // 
            this.OverTime.AutoSize = true;
            this.OverTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OverTime.Location = new System.Drawing.Point(508, 70);
            this.OverTime.Name = "OverTime";
            this.OverTime.Size = new System.Drawing.Size(67, 25);
            this.OverTime.TabIndex = 14;
            this.OverTime.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 501);
            this.Controls.Add(this.OverTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JsonTxt);
            this.Controls.Add(this.Etxt);
            this.Controls.Add(this.Stxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.NUM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRequest);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button BtnRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NUM;
        private System.Windows.Forms.TextBox Msg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Stxt;
        private System.Windows.Forms.TextBox Etxt;
        private System.Windows.Forms.TextBox JsonTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label OverTime;
    }
}


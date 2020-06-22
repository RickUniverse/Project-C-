namespace XiYiDian
{
    partial class Frm_tianjiayuangong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtshengid = new System.Windows.Forms.TextBox();
            this.rdinan = new System.Windows.Forms.RadioButton();
            this.rdinu = new System.Windows.Forms.RadioButton();
            this.txtiphone = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.dtruzhitime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(110, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加员工";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(115, 62);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "身份证号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "性别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "家庭住址：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "入职时间:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "电话号码：";
            // 
            // txtshengid
            // 
            this.txtshengid.Location = new System.Drawing.Point(115, 132);
            this.txtshengid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtshengid.Name = "txtshengid";
            this.txtshengid.Size = new System.Drawing.Size(100, 21);
            this.txtshengid.TabIndex = 8;
            // 
            // rdinan
            // 
            this.rdinan.AutoSize = true;
            this.rdinan.Checked = true;
            this.rdinan.Location = new System.Drawing.Point(118, 100);
            this.rdinan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdinan.Name = "rdinan";
            this.rdinan.Size = new System.Drawing.Size(35, 16);
            this.rdinan.TabIndex = 9;
            this.rdinan.TabStop = true;
            this.rdinan.Text = "男";
            this.rdinan.UseVisualStyleBackColor = true;
            // 
            // rdinu
            // 
            this.rdinu.AutoSize = true;
            this.rdinu.Location = new System.Drawing.Point(171, 100);
            this.rdinu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdinu.Name = "rdinu";
            this.rdinu.Size = new System.Drawing.Size(35, 16);
            this.rdinu.TabIndex = 10;
            this.rdinu.TabStop = true;
            this.rdinu.Text = "女";
            this.rdinu.UseVisualStyleBackColor = true;
            // 
            // txtiphone
            // 
            this.txtiphone.Location = new System.Drawing.Point(115, 166);
            this.txtiphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtiphone.Name = "txtiphone";
            this.txtiphone.Size = new System.Drawing.Size(100, 21);
            this.txtiphone.TabIndex = 11;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(115, 202);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 21);
            this.txtaddress.TabIndex = 12;
            // 
            // dtruzhitime
            // 
            this.dtruzhitime.Location = new System.Drawing.Point(115, 234);
            this.dtruzhitime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtruzhitime.Name = "dtruzhitime";
            this.dtruzhitime.Size = new System.Drawing.Size(186, 21);
            this.dtruzhitime.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(131, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "退出";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_tianjiayuangong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 323);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtruzhitime);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtiphone);
            this.Controls.Add(this.rdinu);
            this.Controls.Add(this.rdinan);
            this.Controls.Add(this.txtshengid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_tianjiayuangong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加员工";
            this.Load += new System.EventHandler(this.Frm_tianjiayuangong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtshengid;
        private System.Windows.Forms.RadioButton rdinan;
        private System.Windows.Forms.RadioButton rdinu;
        private System.Windows.Forms.TextBox txtiphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.DateTimePicker dtruzhitime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
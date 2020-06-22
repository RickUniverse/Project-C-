namespace XiYiDian
{
    partial class Frm_TianJiaYiFu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_zhekou = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_shuliang = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTi_shou = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.com_yifuzhonglei = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.com_yanse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.com_xiyifangshi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tex_beizhu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tex_benque = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lab_jiage = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_shuliang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_zhekou);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.num_shuliang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTi_shou);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.com_yifuzhonglei);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.com_yanse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.com_xiyifangshi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主要信息：";
            // 
            // lab_zhekou
            // 
            this.lab_zhekou.AutoSize = true;
            this.lab_zhekou.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_zhekou.ForeColor = System.Drawing.Color.Red;
            this.lab_zhekou.Location = new System.Drawing.Point(381, 118);
            this.lab_zhekou.Name = "lab_zhekou";
            this.lab_zhekou.Size = new System.Drawing.Size(62, 16);
            this.lab_zhekou.TabIndex = 6;
            this.lab_zhekou.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(323, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "折扣：";
            // 
            // num_shuliang
            // 
            this.num_shuliang.Enabled = false;
            this.num_shuliang.Location = new System.Drawing.Point(371, 77);
            this.num_shuliang.Name = "num_shuliang";
            this.num_shuliang.Size = new System.Drawing.Size(120, 21);
            this.num_shuliang.TabIndex = 5;
            this.num_shuliang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "衣服数量：";
            // 
            // dateTi_shou
            // 
            this.dateTi_shou.Location = new System.Drawing.Point(369, 34);
            this.dateTi_shou.Name = "dateTi_shou";
            this.dateTi_shou.Size = new System.Drawing.Size(150, 21);
            this.dateTi_shou.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "领取时间：";
            // 
            // com_yifuzhonglei
            // 
            this.com_yifuzhonglei.FormattingEnabled = true;
            this.com_yifuzhonglei.Location = new System.Drawing.Point(106, 73);
            this.com_yifuzhonglei.Name = "com_yifuzhonglei";
            this.com_yifuzhonglei.Size = new System.Drawing.Size(121, 20);
            this.com_yifuzhonglei.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "衣服种类：";
            // 
            // com_yanse
            // 
            this.com_yanse.FormattingEnabled = true;
            this.com_yanse.Location = new System.Drawing.Point(106, 111);
            this.com_yanse.Name = "com_yanse";
            this.com_yanse.Size = new System.Drawing.Size(121, 20);
            this.com_yanse.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "衣服颜色：";
            // 
            // com_xiyifangshi
            // 
            this.com_xiyifangshi.FormattingEnabled = true;
            this.com_xiyifangshi.Location = new System.Drawing.Point(106, 35);
            this.com_xiyifangshi.Name = "com_xiyifangshi";
            this.com_xiyifangshi.Size = new System.Drawing.Size(121, 20);
            this.com_xiyifangshi.TabIndex = 0;
            this.com_xiyifangshi.SelectedIndexChanged += new System.EventHandler(this.com_xiyifangshi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "洗衣方式：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tex_beizhu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tex_benque);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(13, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "其他：";
            // 
            // tex_beizhu
            // 
            this.tex_beizhu.Location = new System.Drawing.Point(230, 103);
            this.tex_beizhu.Multiline = true;
            this.tex_beizhu.Name = "tex_beizhu";
            this.tex_beizhu.Size = new System.Drawing.Size(113, 34);
            this.tex_beizhu.TabIndex = 3;
            this.tex_beizhu.Text = "无";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "备注：";
            // 
            // tex_benque
            // 
            this.tex_benque.Location = new System.Drawing.Point(206, 33);
            this.tex_benque.Multiline = true;
            this.tex_benque.Name = "tex_benque";
            this.tex_benque.Size = new System.Drawing.Size(141, 33);
            this.tex_benque.TabIndex = 2;
            this.tex_benque.Text = "无";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "衣服本身缺陷：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(33, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "衣服价格：";
            // 
            // lab_jiage
            // 
            this.lab_jiage.AutoSize = true;
            this.lab_jiage.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_jiage.Location = new System.Drawing.Point(118, 410);
            this.lab_jiage.Name = "lab_jiage";
            this.lab_jiage.Size = new System.Drawing.Size(0, 19);
            this.lab_jiage.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(239, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "添加衣物";
            // 
            // Frm_TianJiaYiFu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 468);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lab_jiage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_TianJiaYiFu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加衣物";
            this.Load += new System.EventHandler(this.Frm_TianJiaYiFu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_shuliang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTi_shou;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox com_yifuzhonglei;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox com_yanse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox com_xiyifangshi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tex_beizhu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tex_benque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lab_jiage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lab_zhekou;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_shuliang;
        private System.Windows.Forms.Label label6;
    }
}
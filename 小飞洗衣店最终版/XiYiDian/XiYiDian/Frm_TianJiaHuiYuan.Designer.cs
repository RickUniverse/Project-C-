namespace XiYiDian
{
    partial class Frm_TianJiaHuiYuan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_jine = new System.Windows.Forms.NumericUpDown();
            this.com_sex = new System.Windows.Forms.ComboBox();
            this.com_zhuangtai = new System.Windows.Forms.ComboBox();
            this.com_fenlei = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lab_zhekou = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dtie_daoqi = new System.Windows.Forms.DateTimePicker();
            this.dtime_dneji = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tex_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtime_shengri = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tex_phone = new System.Windows.Forms.TextBox();
            this.tex_beizhu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tex_zhiwei = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tex_id = new System.Windows.Forms.TextBox();
            this.tex_danwei = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tex_dizhi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_jine)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 399);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_jine);
            this.groupBox1.Controls.Add(this.com_sex);
            this.groupBox1.Controls.Add(this.com_zhuangtai);
            this.groupBox1.Controls.Add(this.com_fenlei);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lab_zhekou);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.dtie_daoqi);
            this.groupBox1.Controls.Add(this.dtime_dneji);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tex_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会员分类：";
            // 
            // num_jine
            // 
            this.num_jine.Location = new System.Drawing.Point(316, 109);
            this.num_jine.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_jine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_jine.Name = "num_jine";
            this.num_jine.Size = new System.Drawing.Size(85, 21);
            this.num_jine.TabIndex = 1;
            this.num_jine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // com_sex
            // 
            this.com_sex.FormattingEnabled = true;
            this.com_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.com_sex.Location = new System.Drawing.Point(97, 79);
            this.com_sex.Name = "com_sex";
            this.com_sex.Size = new System.Drawing.Size(43, 20);
            this.com_sex.TabIndex = 7;
            this.com_sex.Text = "男";
            // 
            // com_zhuangtai
            // 
            this.com_zhuangtai.Enabled = false;
            this.com_zhuangtai.FormattingEnabled = true;
            this.com_zhuangtai.Location = new System.Drawing.Point(95, 108);
            this.com_zhuangtai.Name = "com_zhuangtai";
            this.com_zhuangtai.Size = new System.Drawing.Size(121, 20);
            this.com_zhuangtai.TabIndex = 7;
            // 
            // com_fenlei
            // 
            this.com_fenlei.Enabled = false;
            this.com_fenlei.FormattingEnabled = true;
            this.com_fenlei.Location = new System.Drawing.Point(97, 23);
            this.com_fenlei.Name = "com_fenlei";
            this.com_fenlei.Size = new System.Drawing.Size(121, 20);
            this.com_fenlei.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(237, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(198, 14);
            this.label18.TabIndex = 4;
            this.label18.Text = "注：0.5为 五折，0.9为九折";
            // 
            // lab_zhekou
            // 
            this.lab_zhekou.AutoSize = true;
            this.lab_zhekou.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_zhekou.Location = new System.Drawing.Point(290, 31);
            this.lab_zhekou.Name = "lab_zhekou";
            this.lab_zhekou.Size = new System.Drawing.Size(71, 16);
            this.lab_zhekou.TabIndex = 5;
            this.lab_zhekou.Text = "label14";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(243, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "折扣：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(241, 111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 14);
            this.label19.TabIndex = 0;
            this.label19.Text = "充值金额：";
            // 
            // dtie_daoqi
            // 
            this.dtie_daoqi.Location = new System.Drawing.Point(534, 101);
            this.dtie_daoqi.Name = "dtie_daoqi";
            this.dtie_daoqi.Size = new System.Drawing.Size(150, 21);
            this.dtie_daoqi.TabIndex = 3;
            this.dtie_daoqi.Value = new System.DateTime(2030, 4, 2, 16, 11, 0, 0);
            // 
            // dtime_dneji
            // 
            this.dtime_dneji.Location = new System.Drawing.Point(534, 47);
            this.dtime_dneji.Name = "dtime_dneji";
            this.dtime_dneji.Size = new System.Drawing.Size(150, 21);
            this.dtime_dneji.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "会员分类：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "会员姓名：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(466, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "到期日期：";
            // 
            // tex_name
            // 
            this.tex_name.Location = new System.Drawing.Point(97, 52);
            this.tex_name.Name = "tex_name";
            this.tex_name.Size = new System.Drawing.Size(100, 21);
            this.tex_name.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "性别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "会员状态：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(466, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "登记日期：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dtime_shengri);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tex_phone);
            this.groupBox2.Controls.Add(this.tex_beizhu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tex_zhiwei);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tex_id);
            this.groupBox2.Controls.Add(this.tex_danwei);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tex_dizhi);
            this.groupBox2.Location = new System.Drawing.Point(3, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 221);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "详细信息：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "添加会员";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtime_shengri
            // 
            this.dtime_shengri.Location = new System.Drawing.Point(99, 58);
            this.dtime_shengri.Name = "dtime_shengri";
            this.dtime_shengri.Size = new System.Drawing.Size(146, 21);
            this.dtime_shengri.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-65, -18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "label2";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(-18, -22);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "会员电话：";
            // 
            // tex_phone
            // 
            this.tex_phone.Location = new System.Drawing.Point(96, 29);
            this.tex_phone.Name = "tex_phone";
            this.tex_phone.Size = new System.Drawing.Size(124, 21);
            this.tex_phone.TabIndex = 0;
            this.tex_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_phone_KeyPress);
            // 
            // tex_beizhu
            // 
            this.tex_beizhu.Location = new System.Drawing.Point(436, 29);
            this.tex_beizhu.Multiline = true;
            this.tex_beizhu.Name = "tex_beizhu";
            this.tex_beizhu.Size = new System.Drawing.Size(177, 94);
            this.tex_beizhu.TabIndex = 6;
            this.tex_beizhu.Text = "无";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "会员生日：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(389, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "备注：";
            // 
            // tex_zhiwei
            // 
            this.tex_zhiwei.Location = new System.Drawing.Point(96, 174);
            this.tex_zhiwei.Name = "tex_zhiwei";
            this.tex_zhiwei.Size = new System.Drawing.Size(149, 21);
            this.tex_zhiwei.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "身份证号：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "职位：";
            // 
            // tex_id
            // 
            this.tex_id.Location = new System.Drawing.Point(96, 87);
            this.tex_id.Name = "tex_id";
            this.tex_id.Size = new System.Drawing.Size(184, 21);
            this.tex_id.TabIndex = 2;
            // 
            // tex_danwei
            // 
            this.tex_danwei.Location = new System.Drawing.Point(96, 145);
            this.tex_danwei.Name = "tex_danwei";
            this.tex_danwei.Size = new System.Drawing.Size(247, 21);
            this.tex_danwei.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "详细住址：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "工作单位：";
            // 
            // tex_dizhi
            // 
            this.tex_dizhi.Location = new System.Drawing.Point(96, 116);
            this.tex_dizhi.Name = "tex_dizhi";
            this.tex_dizhi.Size = new System.Drawing.Size(247, 21);
            this.tex_dizhi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "会员信息";
            // 
            // Frm_TianJiaHuiYuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_TianJiaHuiYuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加会员";
            this.Load += new System.EventHandler(this.Frm_TianJiaHuiYuan_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_jine)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tex_beizhu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tex_zhiwei;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tex_danwei;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tex_dizhi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tex_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tex_phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tex_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtie_daoqi;
        private System.Windows.Forms.DateTimePicker dtime_dneji;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtime_shengri;
        private System.Windows.Forms.ComboBox com_sex;
        private System.Windows.Forms.ComboBox com_zhuangtai;
        private System.Windows.Forms.ComboBox com_fenlei;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lab_zhekou;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown num_jine;
    }
}
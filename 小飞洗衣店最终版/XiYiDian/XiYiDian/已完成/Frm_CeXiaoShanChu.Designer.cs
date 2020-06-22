namespace XiYiDian
{
    partial class Frm_CeXiaoShanChu
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lab_kazhuang = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lab_zonge = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lab_yue = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lab_lian = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lab_huiming = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lab_huibian = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_shuliang = new System.Windows.Forms.NumericUpDown();
            this.lab_zhuangtai = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_shishou = new System.Windows.Forms.Label();
            this.lab_yingshou = new System.Windows.Forms.Label();
            this.lab_shuliang = new System.Windows.Forms.Label();
            this.lab_riqi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_danHao = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_shuliang)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 394);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "删除(撤销)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(5, 223);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(650, 164);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "详细信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Location = new System.Drawing.Point(5, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(640, 144);
            this.dataGridView1.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "YiFuBianHao";
            this.dataGridViewTextBoxColumn1.HeaderText = "衣服编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 93;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "yifuname";
            this.dataGridViewTextBoxColumn17.HeaderText = "衣服名称";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 94;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "QuYiTime";
            this.dataGridViewTextBoxColumn18.HeaderText = "取衣时间";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 93;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "DanJia";
            this.dataGridViewTextBoxColumn19.HeaderText = "类型单价";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 93;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "leixing";
            this.dataGridViewTextBoxColumn20.HeaderText = "洗衣方式";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 94;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "YiZhuangTai";
            this.dataGridViewTextBoxColumn2.HeaderText = "衣服状态";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 93;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "YanSeName";
            this.dataGridViewTextBoxColumn21.HeaderText = "颜色";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 93;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BenShenQueXian";
            this.dataGridViewTextBoxColumn3.HeaderText = "本身缺陷";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 94;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "XiHouQueXian";
            this.dataGridViewTextBoxColumn4.HeaderText = "洗后缺陷";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 93;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lab_kazhuang);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lab_zonge);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lab_yue);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lab_lian);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lab_huiming);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lab_huibian);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(5, 125);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(650, 93);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "会员信息";
            // 
            // lab_kazhuang
            // 
            this.lab_kazhuang.AutoSize = true;
            this.lab_kazhuang.ForeColor = System.Drawing.Color.Black;
            this.lab_kazhuang.Location = new System.Drawing.Point(520, 59);
            this.lab_kazhuang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_kazhuang.Name = "lab_kazhuang";
            this.lab_kazhuang.Size = new System.Drawing.Size(41, 12);
            this.lab_kazhuang.TabIndex = 0;
            this.lab_kazhuang.Text = "label1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(233, 33);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "会员名称：";
            // 
            // lab_zonge
            // 
            this.lab_zonge.AutoSize = true;
            this.lab_zonge.ForeColor = System.Drawing.Color.Red;
            this.lab_zonge.Location = new System.Drawing.Point(307, 59);
            this.lab_zonge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_zonge.Name = "lab_zonge";
            this.lab_zonge.Size = new System.Drawing.Size(41, 12);
            this.lab_zonge.TabIndex = 0;
            this.lab_zonge.Text = "label1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 33);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "会员编号：";
            // 
            // lab_yue
            // 
            this.lab_yue.AutoSize = true;
            this.lab_yue.ForeColor = System.Drawing.Color.Red;
            this.lab_yue.Location = new System.Drawing.Point(95, 59);
            this.lab_yue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_yue.Name = "lab_yue";
            this.lab_yue.Size = new System.Drawing.Size(41, 12);
            this.lab_yue.TabIndex = 0;
            this.lab_yue.Text = "label1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(447, 33);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "联系电话：";
            // 
            // lab_lian
            // 
            this.lab_lian.AutoSize = true;
            this.lab_lian.ForeColor = System.Drawing.Color.Black;
            this.lab_lian.Location = new System.Drawing.Point(520, 33);
            this.lab_lian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_lian.Name = "lab_lian";
            this.lab_lian.Size = new System.Drawing.Size(41, 12);
            this.lab_lian.TabIndex = 0;
            this.lab_lian.Text = "label1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 59);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "卡内余额：";
            // 
            // lab_huiming
            // 
            this.lab_huiming.AutoSize = true;
            this.lab_huiming.ForeColor = System.Drawing.Color.Black;
            this.lab_huiming.Location = new System.Drawing.Point(307, 33);
            this.lab_huiming.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_huiming.Name = "lab_huiming";
            this.lab_huiming.Size = new System.Drawing.Size(41, 12);
            this.lab_huiming.TabIndex = 0;
            this.lab_huiming.Text = "label1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(233, 59);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "消费总额：";
            // 
            // lab_huibian
            // 
            this.lab_huibian.AutoSize = true;
            this.lab_huibian.ForeColor = System.Drawing.Color.Black;
            this.lab_huibian.Location = new System.Drawing.Point(95, 33);
            this.lab_huibian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_huibian.Name = "lab_huibian";
            this.lab_huibian.Size = new System.Drawing.Size(41, 12);
            this.lab_huibian.TabIndex = 0;
            this.lab_huibian.Text = "label1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(447, 59);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 0;
            this.label20.Text = "卡的状态：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.num_shuliang);
            this.groupBox1.Controls.Add(this.lab_zhuangtai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lab_shishou);
            this.groupBox1.Controls.Add(this.lab_yingshou);
            this.groupBox1.Controls.Add(this.lab_shuliang);
            this.groupBox1.Controls.Add(this.lab_riqi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(650, 82);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(418, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "删除/撤销数量:";
            // 
            // num_shuliang
            // 
            this.num_shuliang.Enabled = false;
            this.num_shuliang.Location = new System.Drawing.Point(513, 51);
            this.num_shuliang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_shuliang.Name = "num_shuliang";
            this.num_shuliang.Size = new System.Drawing.Size(46, 21);
            this.num_shuliang.TabIndex = 0;
            this.num_shuliang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lab_zhuangtai
            // 
            this.lab_zhuangtai.AutoSize = true;
            this.lab_zhuangtai.ForeColor = System.Drawing.Color.Red;
            this.lab_zhuangtai.Location = new System.Drawing.Point(518, 29);
            this.lab_zhuangtai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_zhuangtai.Name = "lab_zhuangtai";
            this.lab_zhuangtai.Size = new System.Drawing.Size(41, 12);
            this.lab_zhuangtai.TabIndex = 1;
            this.lab_zhuangtai.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "衣服状态：";
            // 
            // lab_shishou
            // 
            this.lab_shishou.AutoSize = true;
            this.lab_shishou.ForeColor = System.Drawing.Color.Black;
            this.lab_shishou.Location = new System.Drawing.Point(307, 56);
            this.lab_shishou.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_shishou.Name = "lab_shishou";
            this.lab_shishou.Size = new System.Drawing.Size(41, 12);
            this.lab_shishou.TabIndex = 0;
            this.lab_shishou.Text = "label1";
            // 
            // lab_yingshou
            // 
            this.lab_yingshou.AutoSize = true;
            this.lab_yingshou.ForeColor = System.Drawing.Color.Red;
            this.lab_yingshou.Location = new System.Drawing.Point(95, 56);
            this.lab_yingshou.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_yingshou.Name = "lab_yingshou";
            this.lab_yingshou.Size = new System.Drawing.Size(41, 12);
            this.lab_yingshou.TabIndex = 0;
            this.lab_yingshou.Text = "label1";
            // 
            // lab_shuliang
            // 
            this.lab_shuliang.AutoSize = true;
            this.lab_shuliang.ForeColor = System.Drawing.Color.Black;
            this.lab_shuliang.Location = new System.Drawing.Point(307, 29);
            this.lab_shuliang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_shuliang.Name = "lab_shuliang";
            this.lab_shuliang.Size = new System.Drawing.Size(41, 12);
            this.lab_shuliang.TabIndex = 0;
            this.lab_shuliang.Text = "label1";
            // 
            // lab_riqi
            // 
            this.lab_riqi.AutoSize = true;
            this.lab_riqi.ForeColor = System.Drawing.Color.Black;
            this.lab_riqi.Location = new System.Drawing.Point(95, 29);
            this.lab_riqi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_riqi.Name = "lab_riqi";
            this.lab_riqi.Size = new System.Drawing.Size(41, 12);
            this.lab_riqi.TabIndex = 0;
            this.lab_riqi.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "支付费用：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "单价：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "收衣数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "取衣日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "订单号：";
            // 
            // lab_danHao
            // 
            this.lab_danHao.AutoSize = true;
            this.lab_danHao.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_danHao.ForeColor = System.Drawing.Color.Red;
            this.lab_danHao.Location = new System.Drawing.Point(312, 9);
            this.lab_danHao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_danHao.Name = "lab_danHao";
            this.lab_danHao.Size = new System.Drawing.Size(62, 16);
            this.lab_danHao.TabIndex = 9;
            this.lab_danHao.Text = "label1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 1;
            this.button4.Text = "退款";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Frm_CeXiaoShanChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 436);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_danHao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_CeXiaoShanChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "退款/撤销";
            this.Load += new System.EventHandler(this.Frm_CeXiaoShanChu_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_shuliang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lab_kazhuang;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lab_zonge;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lab_yue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lab_lian;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lab_huiming;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lab_huibian;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_zhuangtai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_shishou;
        private System.Windows.Forms.Label lab_yingshou;
        private System.Windows.Forms.Label lab_shuliang;
        private System.Windows.Forms.Label lab_riqi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_danHao;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_shuliang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
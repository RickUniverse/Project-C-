namespace XiYiDian
{
    partial class Frm_FanHuiChongXi
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_xiangqing = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Button();
            this.btnfhcx = new System.Windows.Forms.Button();
            this.num_shuliang = new System.Windows.Forms.NumericUpDown();
            this.dateTime_xinquyi = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lab_zhuangtaia = new System.Windows.Forms.Label();
            this.lab_dianhua = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lab_yue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lab_zonge = new System.Windows.Forms.Label();
            this.lab_huibian = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lab_huiming = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_zhifu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_dangqianxi = new System.Windows.Forms.Label();
            this.lab_yingshou = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_shuliang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xiangqing)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_shuliang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_xiangqing);
            this.groupBox4.Location = new System.Drawing.Point(11, 241);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(590, 139);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "订单详情";
            // 
            // dgv_xiangqing
            // 
            this.dgv_xiangqing.AllowUserToAddRows = false;
            this.dgv_xiangqing.AllowUserToDeleteRows = false;
            this.dgv_xiangqing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_xiangqing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column11});
            this.dgv_xiangqing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_xiangqing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgv_xiangqing.Location = new System.Drawing.Point(2, 14);
            this.dgv_xiangqing.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_xiangqing.Name = "dgv_xiangqing";
            this.dgv_xiangqing.ReadOnly = true;
            this.dgv_xiangqing.RowHeadersVisible = false;
            this.dgv_xiangqing.RowTemplate.Height = 27;
            this.dgv_xiangqing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_xiangqing.Size = new System.Drawing.Size(586, 123);
            this.dgv_xiangqing.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "YiFuName";
            this.Column1.HeaderText = "衣服名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LeiXing";
            this.Column2.HeaderText = "类型";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BenShenQueXian";
            this.Column5.HeaderText = "衣服瑕疵";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Name";
            this.Column6.HeaderText = "颜色";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SheKou";
            this.Column7.HeaderText = "折扣";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ShiShouJinE";
            this.Column8.HeaderText = "折后价";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "JiaGe";
            this.Column10.HeaderText = "单价";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "BeiZhu";
            this.Column11.HeaderText = "备注";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lbltc);
            this.groupBox3.Controls.Add(this.btnfhcx);
            this.groupBox3.Controls.Add(this.num_shuliang);
            this.groupBox3.Controls.Add(this.dateTime_xinquyi);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(11, 175);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(590, 60);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "返回重洗设置信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(273, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "重洗数量:";
            // 
            // lbltc
            // 
            this.lbltc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbltc.Location = new System.Drawing.Point(520, 21);
            this.lbltc.Margin = new System.Windows.Forms.Padding(2);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(66, 28);
            this.lbltc.TabIndex = 3;
            this.lbltc.Text = "退出";
            this.lbltc.UseVisualStyleBackColor = true;
            this.lbltc.Click += new System.EventHandler(this.lbltc_Click);
            // 
            // btnfhcx
            // 
            this.btnfhcx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnfhcx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfhcx.Location = new System.Drawing.Point(419, 20);
            this.btnfhcx.Margin = new System.Windows.Forms.Padding(2);
            this.btnfhcx.Name = "btnfhcx";
            this.btnfhcx.Size = new System.Drawing.Size(71, 28);
            this.btnfhcx.TabIndex = 2;
            this.btnfhcx.Text = "确定重洗";
            this.btnfhcx.UseVisualStyleBackColor = true;
            this.btnfhcx.Click += new System.EventHandler(this.btnfhcx_Click);
            // 
            // num_shuliang
            // 
            this.num_shuliang.Enabled = false;
            this.num_shuliang.Location = new System.Drawing.Point(338, 25);
            this.num_shuliang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_shuliang.Name = "num_shuliang";
            this.num_shuliang.Size = new System.Drawing.Size(45, 21);
            this.num_shuliang.TabIndex = 1;
            this.num_shuliang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTime_xinquyi
            // 
            this.dateTime_xinquyi.Location = new System.Drawing.Point(86, 25);
            this.dateTime_xinquyi.Margin = new System.Windows.Forms.Padding(2);
            this.dateTime_xinquyi.Name = "dateTime_xinquyi";
            this.dateTime_xinquyi.Size = new System.Drawing.Size(151, 21);
            this.dateTime_xinquyi.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 29);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "新取衣日期：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lab_zhuangtaia);
            this.groupBox2.Controls.Add(this.lab_dianhua);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lab_yue);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lab_zonge);
            this.groupBox2.Controls.Add(this.lab_huibian);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lab_huiming);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(11, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(590, 80);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "会员信息";
            // 
            // lab_zhuangtaia
            // 
            this.lab_zhuangtaia.AutoSize = true;
            this.lab_zhuangtaia.Location = new System.Drawing.Point(458, 56);
            this.lab_zhuangtaia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_zhuangtaia.Name = "lab_zhuangtaia";
            this.lab_zhuangtaia.Size = new System.Drawing.Size(41, 12);
            this.lab_zhuangtaia.TabIndex = 0;
            this.lab_zhuangtaia.Text = "label1";
            // 
            // lab_dianhua
            // 
            this.lab_dianhua.AutoSize = true;
            this.lab_dianhua.Location = new System.Drawing.Point(458, 26);
            this.lab_dianhua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_dianhua.Name = "lab_dianhua";
            this.lab_dianhua.Size = new System.Drawing.Size(41, 12);
            this.lab_dianhua.TabIndex = 0;
            this.lab_dianhua.Text = "label1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 56);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "卡内余额：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(382, 56);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "会员卡状态：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "会员编号：";
            // 
            // lab_yue
            // 
            this.lab_yue.AutoSize = true;
            this.lab_yue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lab_yue.Location = new System.Drawing.Point(85, 56);
            this.lab_yue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_yue.Name = "lab_yue";
            this.lab_yue.Size = new System.Drawing.Size(41, 12);
            this.lab_yue.TabIndex = 0;
            this.lab_yue.Text = "label1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(393, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "联系电话：";
            // 
            // lab_zonge
            // 
            this.lab_zonge.AutoSize = true;
            this.lab_zonge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lab_zonge.Location = new System.Drawing.Point(266, 56);
            this.lab_zonge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_zonge.Name = "lab_zonge";
            this.lab_zonge.Size = new System.Drawing.Size(41, 12);
            this.lab_zonge.TabIndex = 0;
            this.lab_zonge.Text = "label1";
            // 
            // lab_huibian
            // 
            this.lab_huibian.AutoSize = true;
            this.lab_huibian.Location = new System.Drawing.Point(85, 26);
            this.lab_huibian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_huibian.Name = "lab_huibian";
            this.lab_huibian.Size = new System.Drawing.Size(41, 12);
            this.lab_huibian.TabIndex = 0;
            this.lab_huibian.Text = "label1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(200, 56);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "消费总额：";
            // 
            // lab_huiming
            // 
            this.lab_huiming.AutoSize = true;
            this.lab_huiming.Location = new System.Drawing.Point(266, 26);
            this.lab_huiming.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_huiming.Name = "lab_huiming";
            this.lab_huiming.Size = new System.Drawing.Size(41, 12);
            this.lab_huiming.TabIndex = 0;
            this.lab_huiming.Text = "label1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "会员名称：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_zhifu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lab_dangqianxi);
            this.groupBox1.Controls.Add(this.lab_yingshou);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lab_shuliang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(590, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "洗衣单信息";
            // 
            // lab_zhifu
            // 
            this.lab_zhifu.AutoSize = true;
            this.lab_zhifu.Location = new System.Drawing.Point(458, 47);
            this.lab_zhifu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_zhifu.Name = "lab_zhifu";
            this.lab_zhifu.Size = new System.Drawing.Size(41, 12);
            this.lab_zhifu.TabIndex = 0;
            this.lab_zhifu.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "支付费用：";
            // 
            // lab_dangqianxi
            // 
            this.lab_dangqianxi.AutoSize = true;
            this.lab_dangqianxi.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_dangqianxi.ForeColor = System.Drawing.Color.Red;
            this.lab_dangqianxi.Location = new System.Drawing.Point(262, 17);
            this.lab_dangqianxi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_dangqianxi.Name = "lab_dangqianxi";
            this.lab_dangqianxi.Size = new System.Drawing.Size(62, 16);
            this.lab_dangqianxi.TabIndex = 0;
            this.lab_dangqianxi.Text = "label1";
            // 
            // lab_yingshou
            // 
            this.lab_yingshou.AutoSize = true;
            this.lab_yingshou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lab_yingshou.Location = new System.Drawing.Point(266, 47);
            this.lab_yingshou.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_yingshou.Name = "lab_yingshou";
            this.lab_yingshou.Size = new System.Drawing.Size(41, 12);
            this.lab_yingshou.TabIndex = 0;
            this.lab_yingshou.Text = "label1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(176, 17);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 16);
            this.label20.TabIndex = 0;
            this.label20.Text = "当前洗衣单";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "单价：";
            // 
            // lab_shuliang
            // 
            this.lab_shuliang.AutoSize = true;
            this.lab_shuliang.Location = new System.Drawing.Point(85, 47);
            this.lab_shuliang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_shuliang.Name = "lab_shuliang";
            this.lab_shuliang.Size = new System.Drawing.Size(41, 12);
            this.lab_shuliang.TabIndex = 0;
            this.lab_shuliang.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "收衣数量：";
            // 
            // Frm_FanHuiChongXi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 390);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_FanHuiChongXi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "返回重洗";
            this.Load += new System.EventHandler(this.Frm_FanHuiChongXi_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xiangqing)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_shuliang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button lbltc;
        private System.Windows.Forms.Button btnfhcx;
        private System.Windows.Forms.DateTimePicker dateTime_xinquyi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lab_zhuangtaia;
        private System.Windows.Forms.Label lab_dianhua;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lab_yue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lab_zonge;
        private System.Windows.Forms.Label lab_huibian;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lab_huiming;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_zhifu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_dangqianxi;
        private System.Windows.Forms.Label lab_yingshou;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_shuliang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_xiangqing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_shuliang;
    }
}
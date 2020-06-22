namespace XiYiDian
{
    partial class Frm_yuangongguanli
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
            this.txtxianshibianhao = new System.Windows.Forms.TextBox();
            this.btnchaxunyuangong = new System.Windows.Forms.Button();
            this.btnchaxunquanbu = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btntianjia = new System.Windows.Forms.Button();
            this.lvixianshi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "输入员工编号";
            // 
            // txtxianshibianhao
            // 
            this.txtxianshibianhao.Location = new System.Drawing.Point(95, 49);
            this.txtxianshibianhao.Name = "txtxianshibianhao";
            this.txtxianshibianhao.Size = new System.Drawing.Size(100, 21);
            this.txtxianshibianhao.TabIndex = 2;
            // 
            // btnchaxunyuangong
            // 
            this.btnchaxunyuangong.Location = new System.Drawing.Point(201, 49);
            this.btnchaxunyuangong.Name = "btnchaxunyuangong";
            this.btnchaxunyuangong.Size = new System.Drawing.Size(75, 23);
            this.btnchaxunyuangong.TabIndex = 3;
            this.btnchaxunyuangong.Text = "查询员工";
            this.btnchaxunyuangong.UseVisualStyleBackColor = true;
            this.btnchaxunyuangong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnchaxunquanbu
            // 
            this.btnchaxunquanbu.Location = new System.Drawing.Point(280, 49);
            this.btnchaxunquanbu.Name = "btnchaxunquanbu";
            this.btnchaxunquanbu.Size = new System.Drawing.Size(89, 23);
            this.btnchaxunquanbu.TabIndex = 4;
            this.btnchaxunquanbu.Text = "查询全部员工";
            this.btnchaxunquanbu.UseVisualStyleBackColor = true;
            this.btnchaxunquanbu.Click += new System.EventHandler(this.btnchaxunquanbu_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(373, 48);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 24);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "删除员工";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btntianjia
            // 
            this.btntianjia.Location = new System.Drawing.Point(452, 49);
            this.btntianjia.Name = "btntianjia";
            this.btntianjia.Size = new System.Drawing.Size(75, 23);
            this.btntianjia.TabIndex = 6;
            this.btntianjia.Text = "添加员工";
            this.btntianjia.UseVisualStyleBackColor = true;
            this.btntianjia.Click += new System.EventHandler(this.button4_Click);
            // 
            // lvixianshi
            // 
            this.lvixianshi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvixianshi.FullRowSelect = true;
            this.lvixianshi.Location = new System.Drawing.Point(6, 93);
            this.lvixianshi.Name = "lvixianshi";
            this.lvixianshi.Size = new System.Drawing.Size(600, 254);
            this.lvixianshi.TabIndex = 9;
            this.lvixianshi.UseCompatibleStateImageBehavior = false;
            this.lvixianshi.View = System.Windows.Forms.View.Details;
            this.lvixianshi.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.lvixianshi.Click += new System.EventHandler(this.lvixianshi_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "电话";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "身份证号";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "入职时间";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "地址";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "曾就职单位";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "洗衣件数";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "洗坏件";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "工资";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "实际工资";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "工资结算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Frm_yuangongguanli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvixianshi);
            this.Controls.Add(this.btntianjia);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnchaxunquanbu);
            this.Controls.Add(this.btnchaxunyuangong);
            this.Controls.Add(this.txtxianshibianhao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Frm_yuangongguanli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工管理";
            this.Load += new System.EventHandler(this.Frm_yuangongguanli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtxianshibianhao;
        private System.Windows.Forms.Button btnchaxunyuangong;
        private System.Windows.Forms.Button btnchaxunquanbu;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btntianjia;
        private System.Windows.Forms.ListView lvixianshi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button button1;
    }
}
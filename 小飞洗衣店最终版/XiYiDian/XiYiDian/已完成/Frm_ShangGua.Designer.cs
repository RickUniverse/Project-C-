namespace XiYiDian
{
    partial class Frm_ShangGua
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
            this.com_zhuangtai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_danhao = new System.Windows.Forms.Label();
            this.tex_dingdan = new System.Windows.Forms.TextBox();
            this.com_yuangong = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "洗衣员工：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "衣服状态：";
            // 
            // com_zhuangtai
            // 
            this.com_zhuangtai.Enabled = false;
            this.com_zhuangtai.FormattingEnabled = true;
            this.com_zhuangtai.Location = new System.Drawing.Point(160, 177);
            this.com_zhuangtai.Name = "com_zhuangtai";
            this.com_zhuangtai.Size = new System.Drawing.Size(121, 20);
            this.com_zhuangtai.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "衣服编号：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(149, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "上挂衣服";
            // 
            // lab_danhao
            // 
            this.lab_danhao.AutoSize = true;
            this.lab_danhao.Location = new System.Drawing.Point(160, 69);
            this.lab_danhao.Name = "lab_danhao";
            this.lab_danhao.Size = new System.Drawing.Size(23, 12);
            this.lab_danhao.TabIndex = 4;
            this.lab_danhao.Text = "lab";
            // 
            // tex_dingdan
            // 
            this.tex_dingdan.Location = new System.Drawing.Point(160, 65);
            this.tex_dingdan.Name = "tex_dingdan";
            this.tex_dingdan.Size = new System.Drawing.Size(100, 21);
            this.tex_dingdan.TabIndex = 0;
            // 
            // com_yuangong
            // 
            this.com_yuangong.FormattingEnabled = true;
            this.com_yuangong.Location = new System.Drawing.Point(160, 120);
            this.com_yuangong.Name = "com_yuangong";
            this.com_yuangong.Size = new System.Drawing.Size(121, 20);
            this.com_yuangong.TabIndex = 0;
            // 
            // Frm_ShangGua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 336);
            this.Controls.Add(this.com_yuangong);
            this.Controls.Add(this.tex_dingdan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_danhao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.com_zhuangtai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_ShangGua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "上挂衣服";
            this.Load += new System.EventHandler(this.Frm_ShangGua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox com_zhuangtai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_danhao;
        private System.Windows.Forms.TextBox tex_dingdan;
        private System.Windows.Forms.ComboBox com_yuangong;
    }
}
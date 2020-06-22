namespace SuDaExpress
{
    partial class TianJiaYuanGong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TianJiaYuanGong));
            this.label1 = new System.Windows.Forms.Label();
            this.tex_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tex_phone = new System.Windows.Forms.TextBox();
            this.time_lantime = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tex_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(106, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // tex_name
            // 
            this.tex_name.Location = new System.Drawing.Point(168, 48);
            this.tex_name.Name = "tex_name";
            this.tex_name.Size = new System.Drawing.Size(100, 21);
            this.tex_name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(106, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "电话：";
            // 
            // tex_phone
            // 
            this.tex_phone.Location = new System.Drawing.Point(168, 129);
            this.tex_phone.Name = "tex_phone";
            this.tex_phone.Size = new System.Drawing.Size(100, 21);
            this.tex_phone.TabIndex = 2;
            this.tex_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_id_KeyPress);
            // 
            // time_lantime
            // 
            this.time_lantime.Enabled = false;
            this.time_lantime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_lantime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.time_lantime.Location = new System.Drawing.Point(136, 180);
            this.time_lantime.Name = "time_lantime";
            this.time_lantime.Size = new System.Drawing.Size(200, 21);
            this.time_lantime.TabIndex = 10;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label29.Location = new System.Drawing.Point(53, 185);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 14);
            this.label29.TabIndex = 9;
            this.label29.Text = "入职时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(106, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "身份证号：";
            // 
            // tex_id
            // 
            this.tex_id.Location = new System.Drawing.Point(168, 87);
            this.tex_id.Name = "tex_id";
            this.tex_id.Size = new System.Drawing.Size(100, 21);
            this.tex_id.TabIndex = 1;
            this.tex_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_id_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(168, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "员工添加";
            // 
            // TianJiaYuanGong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 281);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time_lantime);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.tex_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tex_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tex_name);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TianJiaYuanGong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加员工";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tex_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tex_phone;
        private System.Windows.Forms.DateTimePicker time_lantime;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tex_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}
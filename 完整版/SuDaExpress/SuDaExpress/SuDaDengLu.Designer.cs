namespace SuDaExpress
{
    partial class SuDaDengLu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuDaDengLu));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.最小化UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最大化OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.推出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.but_tuichu = new System.Windows.Forms.Button();
            this.but_denglu = new System.Windows.Forms.Button();
            this.comb_leixing = new System.Windows.Forms.ComboBox();
            this.tex_pwd = new System.Windows.Forms.TextBox();
            this.tex_uid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_mimatishi = new System.Windows.Forms.Label();
            this.lab_zhanghaotishi = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "速达快递";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.最小化UToolStripMenuItem,
            this.最大化OToolStripMenuItem,
            this.推出XToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            // 
            // 最小化UToolStripMenuItem
            // 
            this.最小化UToolStripMenuItem.Name = "最小化UToolStripMenuItem";
            this.最小化UToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.最小化UToolStripMenuItem.Text = "最小化&U";
            this.最小化UToolStripMenuItem.Click += new System.EventHandler(this.最小化UToolStripMenuItem_Click);
            // 
            // 最大化OToolStripMenuItem
            // 
            this.最大化OToolStripMenuItem.Name = "最大化OToolStripMenuItem";
            this.最大化OToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.最大化OToolStripMenuItem.Text = "最大化&O";
            this.最大化OToolStripMenuItem.Click += new System.EventHandler(this.最大化OToolStripMenuItem_Click);
            // 
            // 推出XToolStripMenuItem
            // 
            this.推出XToolStripMenuItem.Name = "推出XToolStripMenuItem";
            this.推出XToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.推出XToolStripMenuItem.Text = "推出&X";
            this.推出XToolStripMenuItem.Click += new System.EventHandler(this.推出XToolStripMenuItem_Click);
            // 
            // but_tuichu
            // 
            this.but_tuichu.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_tuichu.Location = new System.Drawing.Point(258, 205);
            this.but_tuichu.Name = "but_tuichu";
            this.but_tuichu.Size = new System.Drawing.Size(85, 33);
            this.but_tuichu.TabIndex = 12;
            this.but_tuichu.Text = "退出";
            this.but_tuichu.UseVisualStyleBackColor = true;
            this.but_tuichu.Click += new System.EventHandler(this.but_tuichu_Click);
            // 
            // but_denglu
            // 
            this.but_denglu.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_denglu.Location = new System.Drawing.Point(89, 205);
            this.but_denglu.Name = "but_denglu";
            this.but_denglu.Size = new System.Drawing.Size(85, 33);
            this.but_denglu.TabIndex = 11;
            this.but_denglu.Text = "登陆";
            this.but_denglu.UseVisualStyleBackColor = true;
            this.but_denglu.Click += new System.EventHandler(this.but_denglu_Click);
            // 
            // comb_leixing
            // 
            this.comb_leixing.FormattingEnabled = true;
            this.comb_leixing.Items.AddRange(new object[] {
            "跳蚤用户",
            "管理员"});
            this.comb_leixing.Location = new System.Drawing.Point(209, 148);
            this.comb_leixing.Name = "comb_leixing";
            this.comb_leixing.Size = new System.Drawing.Size(121, 20);
            this.comb_leixing.TabIndex = 10;
            this.comb_leixing.Text = "请选择";
            // 
            // tex_pwd
            // 
            this.tex_pwd.Location = new System.Drawing.Point(177, 105);
            this.tex_pwd.Name = "tex_pwd";
            this.tex_pwd.PasswordChar = '*';
            this.tex_pwd.Size = new System.Drawing.Size(121, 21);
            this.tex_pwd.TabIndex = 9;
            this.tex_pwd.TextChanged += new System.EventHandler(this.tex_pwd_TextChanged);
            // 
            // tex_uid
            // 
            this.tex_uid.Location = new System.Drawing.Point(177, 61);
            this.tex_uid.Name = "tex_uid";
            this.tex_uid.Size = new System.Drawing.Size(121, 21);
            this.tex_uid.TabIndex = 5;
            this.tex_uid.TextChanged += new System.EventHandler(this.tex_uid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(121, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "登陆类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(121, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(121, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "账号：";
            // 
            // lab_mimatishi
            // 
            this.lab_mimatishi.AutoSize = true;
            this.lab_mimatishi.BackColor = System.Drawing.Color.Transparent;
            this.lab_mimatishi.Font = new System.Drawing.Font("黑体", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_mimatishi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_mimatishi.Location = new System.Drawing.Point(304, 110);
            this.lab_mimatishi.Name = "lab_mimatishi";
            this.lab_mimatishi.Size = new System.Drawing.Size(60, 10);
            this.lab_mimatishi.TabIndex = 8;
            this.lab_mimatishi.Text = "请输入密码";
            // 
            // lab_zhanghaotishi
            // 
            this.lab_zhanghaotishi.AutoSize = true;
            this.lab_zhanghaotishi.BackColor = System.Drawing.Color.Transparent;
            this.lab_zhanghaotishi.Font = new System.Drawing.Font("黑体", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_zhanghaotishi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_zhanghaotishi.Location = new System.Drawing.Point(304, 67);
            this.lab_zhanghaotishi.Name = "lab_zhanghaotishi";
            this.lab_zhanghaotishi.Size = new System.Drawing.Size(60, 10);
            this.lab_zhanghaotishi.TabIndex = 8;
            this.lab_zhanghaotishi.Text = "请输入账号";
            // 
            // SuDaDengLu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(445, 261);
            this.Controls.Add(this.but_tuichu);
            this.Controls.Add(this.but_denglu);
            this.Controls.Add(this.comb_leixing);
            this.Controls.Add(this.tex_pwd);
            this.Controls.Add(this.tex_uid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_zhanghaotishi);
            this.Controls.Add(this.lab_mimatishi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SuDaDengLu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuDaDengLu";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 最小化UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最大化OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 推出XToolStripMenuItem;
        private System.Windows.Forms.Button but_tuichu;
        private System.Windows.Forms.Button but_denglu;
        private System.Windows.Forms.ComboBox comb_leixing;
        private System.Windows.Forms.TextBox tex_pwd;
        private System.Windows.Forms.TextBox tex_uid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_mimatishi;
        private System.Windows.Forms.Label lab_zhanghaotishi;
    }
}
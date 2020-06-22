using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDaExpress
{
    public partial class TianJiaYuanGong : Form
    {
        public TianJiaYuanGong()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            if (PanDuan2())
            {
                string sql = string.Format("insert Staff values('{0}','{1}','{2}','{3}',0,0,0)",tex_name.Text, time_lantime.Text.ToString(), tex_id.Text,tex_phone.Text);
                int lingshi = db.JiRu(sql);
                if (lingshi > 0)
                {
                    MessageBox.Show("添加新员工成功", "提示");
                    tex_name.Text = "";
                    tex_id.Text = "";
                    tex_phone.Text = "";
                }
            }
        }
        public bool PanDuan2()
        {
            if (tex_name.Text == "")
            {
                MessageBox.Show("请输入名字", "提示");
                this.tex_name.Focus();
                return false;
            }
            if (tex_id.Text == "")
            {
                MessageBox.Show("请输入ID","提示");
                this.tex_id.Focus();
                return false;
            }
            if (tex_phone.Text == "")
            {
                MessageBox.Show("请输入电话", "提示");
                this.tex_phone.Focus();
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tex_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XiYiDian
{
    public partial class Frm_DengLu : Form
    {
        public Frm_DengLu()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            if (JK())
            {
                DengLu();
            }
        }
        public void DengLu()
        {
            if(cob_leixing.Text == "管理员")
            {
                string sql = string.Format("select COUNT(*) from admin where uid = {0} and pwd = '{1}'", tex_uid.Text,tex_pwd.Text);
                int enq = Convert.ToInt32(db.GetOne(sql));
                if(enq > 0)
                {
                    //MessageBox.Show("登陆成功！");
                    this.Hide();
                    Frm_XiYiZongChuangTics frm = new Frm_XiYiZongChuangTics();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("账号或密码错误！");
                }
            }
            else
            {
                string sql = string.Format("select count(*) from adminyuangong where uid = {0} and pwd = '{1}'", tex_uid.Text, tex_pwd.Text);
                int enq = Convert.ToInt32(db.GetOne(sql));
                if (enq > 0)
                {
                    MessageBox.Show("登陆成功！");
                }
                else
                {
                    MessageBox.Show("账号或密码错误！");
                }
            }
        }
        public bool JK()
        {
            if(tex_uid.Text == "")
            {
                MessageBox.Show("请输入账号");
                tex_uid.Focus();
                return false;
            }
            if (tex_pwd.Text == "")
            {
                MessageBox.Show("请输入密码");
                tex_pwd.Focus();
                return false;
            }
            if (cob_leixing.Text == "请选择...")
            {
                MessageBox.Show("请选择类型");
                cob_leixing.Focus();
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDaExpress
{
    public partial class TiaoZaoXiuGaiZiLiao : Form
    {
        public TiaoZaoXiuGaiZiLiao()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void TiaoZaoXiuGaiZiLiao_Load(object sender, EventArgs e)
        {
            TiaoJiaoLoad();
        }
        public void TiaoJiaoLoad()
        {
            string sql = string.Format("select * from [User] where useruid = {0}",ChuangDi.TiaoZaoUid);
            SqlDataReader sdr = db.GetSet(sql);
            sdr.Read();
            textBox1.Text = sdr["UserUid"].ToString();
            tex_pwd.Text = sdr["Userpwd"].ToString();
            tex_name.Text = sdr["Name"].ToString();
            tex_id.Text = sdr["ID"].ToString();
            tex_phone.Text = sdr["PhoneorMail"].ToString();
            tex_shouhuoaddress.Text = sdr["ShouAddress"].ToString();
        }
        public void XiuGai()
        {
            string sql4 = string.Format("update [user] set UserPwd  = '{0}' , Name = '{1}' , ID = '{2}' , PhoneorMail = '{3}' , ShouAddress = '{4}' where useruid = {5} ", tex_pwd.Text, tex_name.Text,tex_id.Text,tex_phone.Text,tex_shouhuoaddress.Text,ChuangDi.TiaoZaoUid);
            int enq = db.JiRu(sql4);
            if (enq == 1)
            {
                MessageBox.Show("修改成功", "提示");
                TiaoJiaoLoad();
            }
            else
            {
                MessageBox.Show("修改失败", "提示");
            }
        }
        public bool PanDuan()
        {
            if (tex_pwd.Text == "")
            {
                MessageBox.Show("密码不能为空", "提示");
                tex_pwd.Focus();
                return false;
            }
            if (tex_name.Text == "")
            {
                MessageBox.Show("姓名不能为空", "提示");
                tex_name.Focus();
                return false;
            }
            if (tex_phone.Text == "")
            {
                MessageBox.Show("联系方式不能为空", "提示");
                tex_phone.Focus();
                return false;
            }
            if (tex_shouhuoaddress.Text == "")
            {
                MessageBox.Show("收获地址不能为空", "提示");
                tex_shouhuoaddress.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MiMa())
            {
                if (PanDuan())
                {
                    XiuGai();
                }
            }
            else
            {
                MessageBox.Show("密码长度不够", "提示");
            }
        }

        private void tex_pwd_TextChanged(object sender, EventArgs e)
        {
            MiMa();
        }
        public bool MiMa()
        {
            if(tex_pwd.Text.Length >= 6)
            {
                label7.ForeColor = Color.Black;
                label7.Text = "密码";
                return true;
            }
            else
            {
                label7.ForeColor = Color.Red;
                label7.Text = "密码长度必须大于6";
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

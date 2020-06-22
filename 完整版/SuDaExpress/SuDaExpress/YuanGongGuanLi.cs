using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuDaExpress
{
    public partial class YuanGongGuanLi : Form
    {
        public YuanGongGuanLi()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            if (!PanDuan())
            {
                ChaXun();
            }
        }

        private void YuanGongGuanLi_Load(object sender, EventArgs e)
        {
            ChaXunQuanBu();
        }
        public void ChaXunQuanBu()
        {
            listView1.Items.Clear();
            string sql = "select * from staff";
            SqlDataReader sdr = db.GetSet(sql);
            while (sdr.Read())
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = sdr["StaffNo"].ToString();
                //lv.ImageIndex = 1;
                lv.SubItems.Add(sdr["StaffName"].ToString());
                lv.SubItems.Add(sdr["RuZhiTime"].ToString());
                lv.SubItems.Add(sdr["Phone"].ToString());
                lv.SubItems.Add(sdr["ID"].ToString());
                lv.SubItems.Add(sdr["KuaiDiJian"].ToString());
                lv.SubItems.Add(sdr["Wages"].ToString());
                lv.SubItems.Add(sdr["TouSuCiShu"].ToString());
                listView1.Items.Add(lv);
            }
            sdr.Close();
        }
        public void ChaXun()
        {
            listView1.Items.Clear();
            string sql = string.Format("select * from staff where StaffNo = {0}", Convert.ToInt32(tex_yuangongbianhao.Text));
            SqlDataReader sdr = db.GetSet(sql);
            sdr.Read();
                ListViewItem lv = new ListViewItem();
                lv.Text = sdr["StaffNo"].ToString();
                lv.ImageIndex = 1;
                lv.SubItems.Add(sdr["StaffName"].ToString());
                lv.SubItems.Add(sdr["RuZhiTime"].ToString());
                lv.SubItems.Add(sdr["Phone"].ToString());
                lv.SubItems.Add(sdr["ID"].ToString());
                lv.SubItems.Add(sdr["KuaiDiJian"].ToString());
                lv.SubItems.Add(sdr["Wages"].ToString());
                lv.SubItems.Add(sdr["TouSuCiShu"].ToString());
                listView1.Items.Add(lv);
            sdr.Close();
        }
        public bool PanDuan()
        {
            //判断为空
            string sql = string.Format("select count(*) from Staff where StaffNo = {0}", tex_yuangongbianhao.Text);
            if (tex_yuangongbianhao.Text == "")
            {
                MessageBox.Show("请输入员工号", "提示");
                this.tex_yuangongbianhao.Focus();
            }
            else if (tex_yuangongbianhao.Text != "")
            {
                int lingshi = Convert.ToInt32(db.GetOne(sql));
                if (lingshi > 0)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("员工号输入错误或无此员工", "提示");
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!PanDuan())
            {
                DialogResult dialogResult = MessageBox.Show(tex_yuangongbianhao.Text, "确认删除员工：", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if(dialogResult == DialogResult.OK)
                {
                    string sql = string.Format("select * from staff where staffno = {0}", int.Parse(tex_yuangongbianhao.Text));
                    SqlDataReader sdr = db.GetSet(sql);
                    sdr.Read();
                    if (Convert.ToInt32(sdr["Wages"])> 0 || Convert.ToInt32(sdr["KuaiDiJian"]) > 0)
                    {
                        MessageBox.Show("该员工还有工资未结算，请先结算工资！", "提示");
                        YuanGongJieSuan ygjs = new YuanGongJieSuan();
                        ygjs.Show();
                    }
                    else
                    {
                        string lingshistr1 = string.Format("delete from staff where staffno = {0}", int.Parse(tex_yuangongbianhao.Text));
                        int lingshi1 = db.JiRu(lingshistr1);
                        if (lingshi1 > 0)
                        {
                            MessageBox.Show("已删除该员工", "提示");
                            listView1.Items.Clear();
                        }
                    }
                }
            }
        }
        //添加员工
        private void button3_Click(object sender, EventArgs e)
        {
            TianJiaYuanGong tjyg = new TianJiaYuanGong();
            tjyg.Show();
        }

        private void tex_yuangongbianhao_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            ChaXunQuanBu();
        }
    }
}

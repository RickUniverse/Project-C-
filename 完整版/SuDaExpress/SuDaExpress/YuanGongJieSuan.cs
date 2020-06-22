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
    public partial class YuanGongJieSuan : Form
    {
        public YuanGongJieSuan()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            if (!PanDuanChaXun())
            {
                string sql = string.Format("select * from Staff where StaffNo = {0}", int.Parse(tex_yuangonghao.Text));
                SqlDataReader sdr = db.GetSet(sql);
                sdr.Read();
                lab_leiji.Text = sdr["KuaiDiJian"].ToString();
                lab_beitousu.Text = sdr["TouSuCiShu"].ToString();
                int gongzi = Convert.ToInt32(sdr["KuaiDiJian"]) - Convert.ToInt32(sdr["TouSuCiShu"]);
                lab_gongzi.Text = gongzi.ToString();
            }
        }
        public bool PanDuanChaXun()
        {
            string sql = string.Format("select count(*) from Staff where StaffNo = {0}", int.Parse(tex_yuangonghao.Text));
            if (tex_yuangonghao.Text == "")
            {
                MessageBox.Show("请输入员工号", "提示");
                this.tex_yuangonghao.Focus();
            }
            else if (tex_yuangonghao.Text != "")
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
            if(tex_yuangonghao.Text == "")
            {
                MessageBox.Show("请输入员工号", "提示");
            }
            else
            {
                if (!PanDuanChaXun())
                {
                    string sql4 = string.Format("update staff set kuaidijian = 0 where staffno = '{0}'", int.Parse(tex_yuangonghao.Text));
                    int enq = db.JiRu(sql4);
                    string sql1 = string.Format("update staff set Wages = 0 where staffno = '{0}'", int.Parse(tex_yuangonghao.Text));
                    int en1 = db.JiRu(sql1);
                    string sql2 = string.Format("update staff set TouSuCiShu = 0 where staffno = '{0}'", int.Parse(tex_yuangonghao.Text));
                    int en2 = db.JiRu(sql2);
                    if (enq == 1 && en1 == 1 & en2 == 1)
                    {
                        MessageBox.Show("结算成功！", "提示");
                        this.Close();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

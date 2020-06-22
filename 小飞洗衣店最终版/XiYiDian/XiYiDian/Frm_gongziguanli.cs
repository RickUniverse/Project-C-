using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace XiYiDian
{
    public partial class Frm_gongziguanli : Form
    {
        public Frm_gongziguanli()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        //public bool PanDuanChaXun()
        //{
        //    string sql = string.Format("select count(*) from YuanGong where YuanGongID = {0}", int.Parse(txtyuangongId.Text));
        //    if (txtyuangongId.Text == "")
        //    {
        //        MessageBox.Show("请输入员工号", "提示");
        //        this.txtyuangongId.Focus();
        //    }
        //    else if (txtyuangongId.Text != "")
        //    {
        //        int lingshi = Convert.ToInt32(db.GetOne(sql));
        //        if (lingshi > 0)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            MessageBox.Show("员工号输入错误或无此员工", "提示");
        //        }
        //    }
        //    return true;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //if (txtyuangongId.Text == "")
            //{
            //    MessageBox.Show("请输入员工号", "提示");
            //}
            //else
            //{
            //    if (!PanDuanChaXun())
            //    {
            //        string sql4 = string.Format("update YuanGong set XiYiJianShu = 0 where YuanGongId = '{0}'", int.Parse(txtyuangongId.Text));
            //        int enq = db.JiRu(sql4);
            //        string sql1 = string.Format("update YuanGong set XiHuaiJian = 0 where YuanGongId = '{0}'", int.Parse(txtyuangongId.Text));
            //        int en1 = db.JiRu(sql1);
            //        string sql2 = string.Format("update YuanGong set ShiJiGongZi = 0 where YuanGongId = '{0}'", int.Parse(txtyuangongId.Text));
            //        int en2 = db.JiRu(sql2);
            //        if (enq == 1 && en1 == 1 & en2 == 1)
            //        {
            //            MessageBox.Show("结算成功！", "提示");
            //            this.Close();
            //        }
            //    }
            //}
            double panduan =  double.Parse(lab_gongzi.Text);
            if (panduan <= 0)
            {
                MessageBox.Show("工资不足！", "提示");
            }
            else
            {
                string sql1 = string.Format("update YuanGong set XiYiJianShu = 0 , XiHuaiJian = 0 , GongZi = 0 , ShiJiGongZi = 0 where YuanGongId = '{0}'", int.Parse(txtyuangongId.Text));
                int en1 = db.Update(sql1);
                if(en1 > 0)
                {
                    DialogResult result = MessageBox.Show("确认结算!", "提示!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        string str = $"结算成功：工资为{lab_gongzi.Text}元。";
                        MessageBox.Show(str, "提示");
                        string sql = string.Format("select * from YuanGong where YuanGongID = {0}", txtyuangongId.Text);
                        DataTable dt = db.GetData(sql);
                        labxiyijianshu.Text = dt.Rows[0]["XiYiJianShu"].ToString();
                        double gongzi = double.Parse(labxiyijianshu.Text) / 10 * 1;
                        lab_gongzi.Text = gongzi.ToString();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出!", "提示!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtyuangongId.Text == "")
            {
                MessageBox.Show("请输入员工号", "提示");
                this.txtyuangongId.Focus();
                return;
            }
            else
            {
                string sql2 = $"select count(*) from YuanGong where YuanGongID = {txtyuangongId.Text}";
                int nq = Convert.ToInt32(db.GetOne(sql2));
                if(nq > 0)
                {
                    string sql = string.Format("select * from YuanGong where YuanGongID = {0}", txtyuangongId.Text);
                    DataTable dt = db.GetData(sql);
                    labxiyijianshu.Text = dt.Rows[0]["XiYiJianShu"].ToString();
                    double gongzi = double.Parse(labxiyijianshu.Text) / 10 * 1;
                    lab_gongzi.Text = gongzi.ToString();
                }
                else
                {
                    MessageBox.Show("员工号输入错误，或无此员工", "提示");
                }
            }
        }
    }
}

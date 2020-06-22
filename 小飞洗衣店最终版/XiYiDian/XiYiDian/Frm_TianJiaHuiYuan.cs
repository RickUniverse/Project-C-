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

namespace XiYiDian
{
    public partial class Frm_TianJiaHuiYuan : Form
    {
        public Frm_TianJiaHuiYuan()
        {
            InitializeComponent();
        }
        public string name;
        DBHelper db = new DBHelper();
        private void Frm_TianJiaHuiYuan_Load(object sender, EventArgs e)
        {
            CobTian();
            tex_name.Text = name;
        }
        //复选框添加
        public void CobTian()
        {
            //分类
            DataTable dt = db.GetData("select * from HuiYuanZhongLei");
            com_fenlei.DataSource = dt;
            com_fenlei.DisplayMember = "HuiYuanZhongLeiName";
            com_fenlei.ValueMember = "HuiYuanZhongLeiID";
            lab_zhekou.Text = dt.Rows[0][2].ToString();

            //状态
            DataTable dt2 = db.GetData("select * from HuiYuanZhuangTai");
            com_zhuangtai.DataSource = dt2;
            com_zhuangtai.DisplayMember = "HuiYuanZhuangTai";
            com_zhuangtai.ValueMember = "HuiYuanZhuanTaiID";
        }
        /// <summary>
        /// 添加会员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (NoNull())
            {
                if (PanDuan())
                {
                    Tian();
                }
            }
        }
        //不能为空
        public bool NoNull()
        {
            if(tex_name.Text == "")
            {
                MessageBox.Show("请输入姓名");
                tex_name.Focus();
                return false;
            }
            if (num_jine.Value == 0)
            {
                MessageBox.Show("请输入充值金额");
                num_jine.Focus();
                return false;
            }
            if (tex_phone.Text == "")
            {
                MessageBox.Show("联系方式不能为空！");
                tex_phone.Focus();
                return false;
            }
            
            return true;
        }
        //充值金额判断
        public bool PanDuan()
        {
            if (num_jine.Value < 100)
            {
                MessageBox.Show("充值金额不能小于100");
                return false;
            }
            return true;
        }
        //添加
        public void Tian()
        {
            string sql2 = $"insert HuiYuanTime values('{dtime_dneji.Value}','{dtie_daoqi.Value}')";
            int enq = db.Update(sql2);
            if (enq > 0)
            {
                DataTable dt = db.GetData("select * from HuiYuanTime order by ShiJianID DESC");
                string bianhao = dt.Rows[0][0].ToString();
                string sql = $"insert HuiYuan values('{tex_name.Text}','{com_sex.Text}',{com_fenlei.SelectedValue},'{tex_phone.Text}',{bianhao},0,{num_jine.Value},{com_zhuangtai.SelectedValue},'{dtime_shengri.Value}','{tex_id.Text}','{tex_dizhi.Text}','{tex_danwei.Text}','{tex_zhiwei.Text}','{tex_beizhu.Text}')";
                int enq2 = db.Update(sql);
                if (enq2 > 0)
                {
                    MessageBox.Show("添加会员成功！");
                    DataTable dt3 = db.GetData("select * from HuiYuan order by huiyuanID DESC");
                    string bianhao2 = dt3.Rows[0][0].ToString();
                    MessageBox.Show(bianhao2,"你的会员号为");
                }
            }
            else
            {
                MessageBox.Show("时间添加失败！");
            }
            
        }
        //输入限制
        private void tex_phone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

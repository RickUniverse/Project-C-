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
    public partial class Frm_ShangGua : Form
    {
        public Frm_ShangGua()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        public string dingDan;
        private void Frm_ShangGua_Load(object sender, EventArgs e)
        {
            TianCob();
        }
        public void TianCob()
        {
            lab_danhao.Text = dingDan;
            tex_dingdan.Text = dingDan;
            string sqlyz = $"select * from YiFuZhuangTai";
            DataTable dtyz = db.GetData(sqlyz);
            com_zhuangtai.DataSource = dtyz;
            com_zhuangtai.DisplayMember = "YiZhuangTai";
            com_zhuangtai.ValueMember = "YiFuZhuangTaiID";
            com_zhuangtai.SelectedValue = 2;

            string sql = $"select * from YuanGong";
            DataTable dt = db.GetData(sql);
            com_yuangong.DataSource = dt;
            com_yuangong.DisplayMember = "Name";
            com_yuangong.ValueMember = "YuanGongID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NoNull())
            {
                if (ChaYuan())
                {
                    string str = "衣服状态为："+com_zhuangtai.Text;
                    DialogResult dr = MessageBox.Show(str, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    if(dr == DialogResult.OK)
                    {
                        UpDate();
                    }
                }
            }
        }
        public bool NoNull()
        {
            if (tex_dingdan.Text == "")
            {
                MessageBox.Show("请输入订单号");
                tex_dingdan.Focus();
                return false;
            }
            return true;
        }
        public bool ChaYuan()
        {
            string sql2 = $"select COUNT(*) from DingDanXiangXi where YiFuBianHao = {tex_dingdan.Text}";
            int getOne2 = Convert.ToInt32(db.GetOne(sql2));
            if (getOne2 > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("没有此订单！");
                return false;
            }
            
            return false;
        }
        public void UpDate()
        {
            //if(radio_shi.Checked == true)
            //{
            //    string sql4 = $"select * from YuanGong where YuanGongID = {com_yuangong.SelectedValue}";
            //    DataTable dt4 = db.GetData(sql4);
            //    int xiHuai = int.Parse(dt4.Rows[0]["XiHuaiJian"].ToString());

            //    string sql = $"update YuanGong set xihuaijian = {xiHuai+1} where YuanGongID = {com_yuangong.SelectedValue}";
            //    int enq = db.Update(sql);
            //    if (enq > 0)
            //    {
            //        string sql2 = $"update ShouQuYiFu set YiFuZhuangTai = {com_zhuangtai.SelectedValue} , XiHouQueXian = '{text_quexian.Text}', XiYiYuanGong = '{com_yuangong.SelectedValue}' where ShouQuYiFuID = {tex_dingdan.Text}";
            //        int enq2 = db.Update(sql2);
            //        if (enq2 > 0)
            //        {
            //            MessageBox.Show("上挂成功！");
            //        }
            //    }
            //}
            //else
            //{
                string sql2 = $"update DingDanXiangXi set YiFuZhuangTai = {com_zhuangtai.SelectedValue} , XiYiYuanGong = '{com_yuangong.SelectedValue}' where YiFuBianHao = {tex_dingdan.Text}";
                int enq2 = db.Update(sql2);
                if (enq2 > 0)
                {
                    MessageBox.Show("上挂成功！");
                    this.Close();
                }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

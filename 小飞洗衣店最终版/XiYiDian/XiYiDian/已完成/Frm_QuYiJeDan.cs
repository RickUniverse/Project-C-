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
    public partial class Frm_QuYiJeDan : Form
    {
        public Frm_QuYiJeDan()
        {
            InitializeComponent();
        }
        public string danHao;
        public string DingDanHao;
        DBHelper db = new DBHelper();
        private void Frm_QuYiJeDan_Load(object sender, EventArgs e)
        {
            LTian();
        }
        public void LTian()
        {
            string sql = $"select * from DingDanXiangXi as ddxx inner join ShouQuYiFu as sqyf on sqyf.ShouQuYiFuID = ddxx.SuoShuDingDan inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai inner join XiYiFangShi as xyfs on xyfs.LeiXingID = ddxx.XiFangShi inner join YiFuZhongLei as yfzl on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei inner join YiFuYanSe as yfys on yfys.YanSeID = ddxx.YanSe where ddxx.YiFuBianHao = {danHao}";
            DataTable dt = db.GetData(sql);
            lab_riqi.Text = dt.Rows[0]["QuYiTime"].ToString();
            lab_shuliang.Text = dt.Rows[0]["ShuLiang"].ToString();
            lab_zhuangtai.Text = dt.Rows[0]["YiZhuangTai"].ToString();
            lab_yingshou.Text = dt.Rows[0]["YingShouJinE"].ToString();
            lab_shishou.Text = dt.Rows[0]["ShiShouJinE"].ToString();
            lab_huibian.Text = dt.Rows[0]["HuiYuanID"].ToString();
            lab_huiming.Text = dt.Rows[0]["HuiYuanRenName"].ToString();
            lab_lian.Text = dt.Rows[0]["HuiYuanPhone"].ToString();
            lab_yue.Text = dt.Rows[0]["YuE"].ToString();
            lab_zonge.Text = dt.Rows[0]["XiaoFeiZongE"].ToString();
            lab_kazhuang.Text = dt.Rows[0]["HuiYuanZhuangTai"].ToString();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            lab_danHao.Text = danHao;

            num_shuliang.Maximum = int.Parse(lab_shuliang.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lab_zhuangtai.Text == "已取走")
            {
                MessageBox.Show("已完成该订单！");
                return;
            }
            if (lab_zhuangtai.Text == "未完成")
            {
                MessageBox.Show("该衣服还未完成！");
                return;
            }
            DialogResult dr = MessageBox.Show("确定收取？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                ShouQu();
            }
        }

        public void ShouQu()
        {
            
            string sql = $"select count(*) from DingDanXiangXi as ddxx inner join ShouQuYiFu as sqyf on sqyf.ShouQuYiFuID = ddxx.SuoShuDingDan inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai where sqyf.ShouQuYiFuID = {DingDanHao} and ddxx.YiFuZhuangTai = 3";
            string sql3 = $"update DingDanXiangXi set YiFuZhuangTai = 3 where YiFuBianHao = {danHao}";
            int getOne = Convert.ToInt32(db.GetOne(sql));
            string sql4 = $"select count(*) from DingDanXiangXi as ddxx inner join ShouQuYiFu as sqyf on sqyf.ShouQuYiFuID = ddxx.SuoShuDingDan inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai where sqyf.ShouQuYiFuID = {DingDanHao} and ddxx.YiFuZhuangTai = 6";
            int getOne4 = Convert.ToInt32(db.GetOne(sql4));
            if (getOne + getOne4 + 1 == int.Parse(lab_shuliang.Text))
            {
                string sql2 = $"update ShouQuYiFu set DingDanZhuangTai = '2' where ShouQuYiFuID = {DingDanHao}";
                if (db.Update(sql2) > 0 && db.Update(sql3) > 0)
                {
                    string str = $"已成功取走衣服编号为：{danHao}的订单,该订单已完成！";
                    MessageBox.Show(str);
                }
            }
            else
            {
               if(db.Update(sql3) > 0)
                {
                    string str = $"已成功取走衣服编号为：{danHao}的订单";
                    MessageBox.Show(str);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LTian();
        }
    }
}

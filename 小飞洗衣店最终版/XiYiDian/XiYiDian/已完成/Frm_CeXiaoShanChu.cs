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
    public partial class Frm_CeXiaoShanChu : Form
    {
        public Frm_CeXiaoShanChu()
        {
            InitializeComponent();
        }

        private void Frm_CeXiaoShanChu_Load(object sender, EventArgs e)
        {
            LTian();
        }
        public string danHao;
        public string dingDanHao;
        public double jiaGe;
        public double zheKou;
        DBHelper db = new DBHelper();
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

            zheKou = double.Parse(dt.Rows[0]["SheKou"].ToString());

            int weiZhi = dt.Rows[0]["DanJia"].ToString().IndexOf(".");
            jiaGe = int.Parse(dt.Rows[0]["DanJia"].ToString().Substring(0, weiZhi));
            num_shuliang.Maximum = int.Parse(lab_shuliang.Text);
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退款？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                ShouQu();
            }
        }
        //撤销删除
        public void ShouQu()
        {
            string sql = $"select count(*) from DingDanXiangXi as ddxx inner join ShouQuYiFu as sqyf on sqyf.ShouQuYiFuID = ddxx.SuoShuDingDan inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai where sqyf.ShouQuYiFuID = {dingDanHao} and ddxx.YiFuZhuangTai = 3";
            string sql3 = $"update DingDanXiangXi set YiFuZhuangTai = 6 where YiFuBianHao = {danHao}";
            int getOne = Convert.ToInt32(db.GetOne(sql));
            string sql4 = $"select count(*) from DingDanXiangXi as ddxx inner join ShouQuYiFu as sqyf on sqyf.ShouQuYiFuID = ddxx.SuoShuDingDan inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai where sqyf.ShouQuYiFuID = {dingDanHao} and ddxx.YiFuZhuangTai = 6";
            int getOne4 = Convert.ToInt32(db.GetOne(sql4));
            if (getOne + getOne4 + 1 == int.Parse(lab_shuliang.Text))
            {
                string sql2 = $"update ShouQuYiFu set DingDanZhuangTai = '2' where ShouQuYiFuID = {dingDanHao}";
                if (db.Update(sql2) > 0 && db.Update(sql3) > 0)
                {
                    string str = $"退款衣服编号为：{danHao}的订单,该订单已完成！";
                    MessageBox.Show(str);
                    LTian();
                }
            }
            else
            {
                if (db.Update(sql3) > 0)
                {
                    string str = $"退款衣服编号为：{danHao}的订单";
                    MessageBox.Show(str);
                    LTian();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定撤销此订单？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                if (dr == DialogResult.OK)
                {
                    string sql2 = $"delete DingDanXiangXi where YiFuBianHao = {danHao}";
                    string sql = $"select count(*) from DingDanXiangXi as ddxx inner join ShouQuYiFu as sqyf on sqyf.ShouQuYiFuID = ddxx.SuoShuDingDan inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai where sqyf.ShouQuYiFuID = {dingDanHao} and ddxx.YiFuZhuangTai = 3";
                    int getOne = Convert.ToInt32(db.GetOne(sql));
                    string sql4 = $"select count(*) from DingDanXiangXi as ddxx inner join ShouQuYiFu as sqyf on sqyf.ShouQuYiFuID = ddxx.SuoShuDingDan inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai where sqyf.ShouQuYiFuID = {dingDanHao} and ddxx.YiFuZhuangTai = 6";
                    int getOne4 = Convert.ToInt32(db.GetOne(sql4));

                    string sql5 = $"update ShouQuYiFu set ShuLiang = {int.Parse(lab_shuliang.Text) - 1} where ShouQuYiFuID = {dingDanHao} ";
                    if (getOne + getOne4 + 1 == int.Parse(lab_shuliang.Text))
                    {
                        if (db.Update(sql2) > 0 && db.Update(sql5) > 0)
                        {
                            string str = $"已删除衣服编号为：{danHao}的订单,该订单已完成！";
                            MessageBox.Show(str);
                            this.Close();
                        }
                    }
                    else
                    {
                        if (db.Update(sql2) > 0 && db.Update(sql5) > 0)
                        {
                            string str = $"已删除衣服编号为：{danHao}的订单";
                            MessageBox.Show(str);
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}

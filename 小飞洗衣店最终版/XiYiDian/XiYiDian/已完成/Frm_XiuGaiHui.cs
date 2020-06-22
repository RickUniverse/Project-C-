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
    public partial class Frm_XiuGaiHui : Form
    {
        public Frm_XiuGaiHui()
        {
            InitializeComponent();
        }
        public string kaHao;
        DBHelper db = new DBHelper();
        private void Frm_XiuGaiHui_Load(object sender, EventArgs e)
        {
            tex_kahao.Text = kaHao;
            CobTian();
            XiangTian();
        }
        public void CobTian()
        {
            //分类
            DataTable dt = db.GetData("select * from HuiYuanZhongLei");
            com_fenlei.DataSource = dt;
            com_fenlei.DisplayMember = "HuiYuanZhongLeiName";
            com_fenlei.ValueMember = "HuiYuanZhongLeiID";

            //状态
            DataTable dt2 = db.GetData("select * from HuiYuanZhuangTai");
            com_zhuangtai.DataSource = dt2;
            com_zhuangtai.DisplayMember = "HuiYuanZhuangTai";
            com_zhuangtai.ValueMember = "HuiYuanZhuanTaiID";
        }
        public void XiangTian()
        {
            string sql = $"select * from HuiYuan as hy inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = hy.ZhongLei inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join HuiYuanTime as hytime on hytime.ShiJianID = hy.ShiJian where hy.HuiYuanID = {kaHao} ";
            DataTable dt = db.GetData(sql);
            tex_name.Text = dt.Rows[0]["HuiYuanRenName"].ToString();
            tex_sex.Text = dt.Rows[0]["Sex"].ToString();
            tex_phone.Text = dt.Rows[0]["HuiYuanPhone"].ToString();
            tex_shengri.Text = dt.Rows[0]["ShengRi"].ToString();
            tex_dizhi.Text = dt.Rows[0]["XiangXiZhuZhi"].ToString();
            tex_id.Text = dt.Rows[0]["IDShengFen"].ToString();
            tex_danwei.Text = dt.Rows[0]["GongZuoDanWei"].ToString();
            tex_zhiwei.Text = dt.Rows[0]["ZhiWei"].ToString();
            com_fenlei.Text = dt.Rows[0]["HuiYuanZhongLeiName"].ToString();
            com_zhuangtai.Text = dt.Rows[0]["HuiYuanZhuangTai"].ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateHui();
        }
        public void UpdateHui()
        {
            string sql = $"update HuiYuan set HuiYuanRenName = '{tex_name.Text}' , HuiYuanPhone = '{tex_phone.Text}' ,ZhongLei = {com_fenlei.SelectedValue} , ZhuangTai = {com_zhuangtai.SelectedValue} ,IDShengFen = {tex_id.Text} , XiangXiZhuZhi = '{tex_dizhi.Text}' , GongZuoDanWei = '{tex_danwei.Text}',ZhiWei = '{tex_zhiwei.Text}'  where huiyuanid = {kaHao}";
            int enq = db.Update(sql);
            if (enq > 0)
            {
                MessageBox.Show("修改会员信息成功！");
                CobTian();
                XiangTian();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

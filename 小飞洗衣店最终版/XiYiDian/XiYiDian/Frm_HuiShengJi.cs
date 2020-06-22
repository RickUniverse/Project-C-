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
    public partial class Frm_HuiShengJi : Form
    {
        public Frm_HuiShengJi()
        {
            InitializeComponent();
        }
        public string kaHao;
        DBHelper db = new DBHelper();
        private void Frm_HuiShengJi_Load(object sender, EventArgs e)
        {
            TianXinXi();
            CobTian();
            HuiTian();
        }
        public void HuiTian()
        {
            dgv_huiyuan.AutoGenerateColumns = false;
            string sql = $"select * from HuiYuanZhongLei";
            DataTable dt = db.GetData(sql);
            dgv_huiyuan.DataSource = dt;
            dt.Rows[0]["SuoXuJiFen"].ToString();
        }
        public void CobTian()
        {
            //分类
            DataTable dt = db.GetData("select * from HuiYuanZhongLei");
            com_zhonglei.DataSource = dt;
            com_zhonglei.DisplayMember = "HuiYuanZhongLeiName";
            com_zhonglei.ValueMember = "HuiYuanZhongLeiID";
            com_zhonglei.SelectedValue = ZhongBian;
        }
        public string zongGe;
        public string ZhongBian;
        public void TianXinXi()
        {
            string sql = $"select * from HuiYuan as hy inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = hy.ZhongLei inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join HuiYuanTime as hytime on hytime.ShiJianID = hy.ShiJian where HuiYuanID = {kaHao}";
            DataTable dt = db.GetData(sql);
            lab_xingming.Text = dt.Rows[0]["HuiYuanRenName"].ToString();
            lab_kahao.Text = kaHao;
            lab_zhonglei.Text = dt.Rows[0]["HuiYuanZhongLeiName"].ToString();
            lab_phone.Text = dt.Rows[0]["HuiYuanPhone"].ToString();
            lab_zonge.Text = dt.Rows[0]["XiaoFeiZongE"].ToString();
            lab_zhekou.Text = dt.Rows[0]["SheKou"].ToString();
            zongGe = dt.Rows[0]["XiaoFeiZongE"].ToString();
            lab_dangqianjifen.Text = (double.Parse(zongGe) / 10).ToString();
            ZhongBian = dt.Rows[0]["HuiYuanZhongLeiID"].ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanDuan();
        }
        public void PanDuan()
        {
            string sql2 = $"select * from HuiYuanZhongLei where HuiYuanZhongLeiID = {com_zhonglei.SelectedValue}";
            DataTable dt2 = db.GetData(sql2);

            if (double.Parse(lab_dangqianjifen.Text) >= double.Parse(dt2.Rows[0]["SuoXuJiFen"].ToString()) && (int)com_zhonglei.SelectedValue != 2)
            {
                if (!com_zhonglei.Text.Equals(lab_zhonglei.Text))
                {
                    string sql = $"update HuiYuan set ZhongLei = {com_zhonglei.SelectedValue} where huiyuanid = {kaHao}";
                    if (db.Update(sql) > 0)
                    {
                        MessageBox.Show("恭喜你，升级成功！");
                        HuiTian();
                        TianXinXi();
                        CobTian();
                    }
                }
                else
                {
                    MessageBox.Show("你已经是此会员！");
                }
            }
            else
            {
                MessageBox.Show("升级失败，积分不够升级或不能升级为普通会员！");
            }
        }
    }
}

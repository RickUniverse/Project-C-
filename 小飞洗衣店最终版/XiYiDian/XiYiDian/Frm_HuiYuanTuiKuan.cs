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
    public partial class Frm_HuiYuanTuiKuan : Form
    {
        public Frm_HuiYuanTuiKuan()
        {
            InitializeComponent();
        }
        public string kaHao;
        DBHelper db = new DBHelper();
        private void Frm_HuiYuanTuiKuan_Load(object sender, EventArgs e)
        {
            XiangTian();
            ComTian();
        }
        public void XiangTian()
        {
            string sql = $"select * from HuiYuan as hy inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = hy.ZhongLei inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join HuiYuanTime as hytime on hytime.ShiJianID = hy.ShiJian where hy.HuiYuanID = {kaHao}";
            DataTable dt = db.GetData(sql);
            lab_xingming.Text = dt.Rows[0]["HuiYuanRenName"].ToString();
            lab_zhonglei.Text = dt.Rows[0]["HuiYuanZhongLeiName"].ToString();
            lab_dianhua.Text = dt.Rows[0]["HuiYuanPhone"].ToString();
            lab_zhuangtai.Text = dt.Rows[0]["HuiYuanZhuangTai"].ToString();
            lab_xiaofei.Text = dt.Rows[0]["XiaoFeiZongE"].ToString();
            lab_yue.Text = dt.Rows[0]["YuE"].ToString();
            lab_zhekou.Text = dt.Rows[0]["SheKou"].ToString();

        }
        public void ComTian()
        {
            DataTable dt = db.GetData("select * from HuiYuanZhuangTai");
            com_Zhuant.DataSource = dt;
            com_Zhuant.DisplayMember = "HuiYuanZhuangTai";
            com_Zhuant.ValueMember = "HuiYuanZhuanTaiID";
            com_Zhuant.SelectedValue = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }
        public void Update()
        {
            DialogResult dr = MessageBox.Show("确定退款？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if(dr == DialogResult.OK)
            {
                string sql = $"update HuiYuan set ZhuangTai = {com_Zhuant.SelectedValue} , YuE = 0 where HuiYuanID = {kaHao}";
                if (db.Update(sql) > 0)
                {
                    string tuiKuan = $"已成功退款,退款金额为:{lab_yue.Text}";
                    MessageBox.Show(tuiKuan);
                    XiangTian();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

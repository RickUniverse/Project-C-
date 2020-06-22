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
    public partial class Frm_FanHuiChongXi : Form
    {
        public Frm_FanHuiChongXi()
        {
            InitializeComponent();
        }
        public string danHao;
        public string zhuangTai;
        DBHelper db = new DBHelper();
        //确定重洗
        private void btnfhcx_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定重洗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                string sql = $"update DingDanXiangXi set YiFuZhuangTai = 5 ,QuYiTime = '{dateTime_xinquyi.Value}' where YiFuBianHao = {danHao}";
                if(db.Update(sql) > 0)
                {
                    MessageBox.Show("新收衣日期修改成功！");
                    LTian();
                }
            }
        }
        public void LTian()
        {
            string sql = $"select * from DingDanXiangXi as ddxx inner join ShouQuYiFu as sqyf on sqyf.ShouQuYiFuID = ddxx.SuoShuDingDan inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai inner join XiYiFangShi as xyfs on xyfs.LeiXingID = ddxx.XiFangShi inner join YiFuZhongLei as yfzl on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei inner join YiFuYanSe as yfys on yfys.YanSeID = ddxx.YanSe where ddxx.YiFuBianHao = {danHao}";
            DataTable dt = db.GetData(sql);
            lab_shuliang.Text = dt.Rows[0]["ShuLiang"].ToString();
            zhuangTai = dt.Rows[0]["YiZhuangTai"].ToString();
            lab_yingshou.Text = dt.Rows[0]["YingShouJinE"].ToString();
            lab_zhifu.Text = dt.Rows[0]["ShiShouJinE"].ToString();
            lab_huibian.Text = dt.Rows[0]["HuiYuanID"].ToString();
            lab_huiming.Text = dt.Rows[0]["HuiYuanRenName"].ToString();
            lab_dianhua.Text = dt.Rows[0]["HuiYuanPhone"].ToString();
            lab_yue.Text = dt.Rows[0]["YuE"].ToString();
            lab_zonge.Text = dt.Rows[0]["XiaoFeiZongE"].ToString();
            lab_zhuangtaia.Text = dt.Rows[0]["HuiYuanZhuangTai"].ToString();
            dgv_xiangqing.AutoGenerateColumns = false;
            dgv_xiangqing.DataSource = dt;
            lab_dangqianxi.Text = danHao;

            num_shuliang.Maximum = int.Parse(lab_shuliang.Text);
        }
        //加载
        private void Frm_FanHuiChongXi_Load(object sender, EventArgs e)
        {
            LTian();
        }
        //关闭
        private void lbltc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

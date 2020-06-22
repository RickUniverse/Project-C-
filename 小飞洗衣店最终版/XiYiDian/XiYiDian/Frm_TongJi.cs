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
    public partial class Frm_TongJi : Form
    {
        public Frm_TongJi()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        #region
        private void button5_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        #endregion
        #region
        /// <summary>
        /// 营业额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_TongJi_Load(object sender, EventArgs e)
        {
            TianJiaQuanBu(0);
            TongJiHuiYuan(0);
        }
        public void TianJiaQuanBu(int cha)
        {
            dgv_dingdan.AutoGenerateColumns = false;
            string sql = $"select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan inner join DingDanZhuangTai as ddzt on ddzt.DingDanZhuangTai = sqyf.DingDanZhuangTai";
            DataTable dt4 = db.GetData(sql);
            DataView dv = new DataView(dt4);
            StringBuilder strTime1 = new StringBuilder(dateTimePicker1.Value.Year.ToString());
            strTime1.AppendFormat("-{0}-{1}", dateTimePicker1.Value.Month.ToString(), dateTimePicker1.Value.Day.ToString());
            StringBuilder strTime2 = new StringBuilder(dateTime_end.Value.Year.ToString());
            strTime2.AppendFormat("-{0}-{1}", dateTime_end.Value.Month.ToString(), dateTime_end.Value.Day.ToString());
            if (cha == 1)
            {
                dv.RowFilter = $"ShouQuTime >=  '{strTime1.ToString()}' and ShouQuTime <= '{strTime2.ToString()}'";
            }
            else
            {
                dgv_dingdan.DataSource = dv;
            }
            dgv_dingdan.DataSource = dv;
            lab_zongyingyee.Text = yingYeE().ToString();
            labe_shuliang.Text = shuLiang().ToString();
        }
        public double yingYeE()
        {
            double YingYeE = 0;
            foreach (DataGridViewRow dgvr in dgv_dingdan.Rows)
            {
                int weiZhi = dgvr.Cells["Column17"].Value.ToString().IndexOf(".");
                double jiaGe = double.Parse(dgvr.Cells["Column17"].Value.ToString().Substring(0, weiZhi));
                YingYeE += jiaGe;
            }

            return YingYeE;
        }
        public int shuLiang()
        {
            int shuLiang = 0;
            foreach(DataGridViewRow dgvr in dgv_dingdan.Rows)
            {
                int shuLian = int.Parse(dgvr.Cells["Column19"].Value.ToString());
                shuLiang += shuLian;
            }
            return shuLiang;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TianJiaQuanBu(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TianJiaQuanBu(1);
        }

        //添加详细
        private void dgv_dingdan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgv_xiangxi.AutoGenerateColumns = false;
                string sql = $"select * from ShouQuYiFu as sqyf inner join DingDanXiangXi as ddxx on ddxx.SuoShuDingDan = sqyf.ShouQuYiFuID inner join XiYiFangShi as xyfs on xyfs.LeiXingID = ddxx.XiFangShi inner join YiFuZhongLei as yfzl on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai inner join YiFuYanSe as yfys on yfys.YanSeID = ddxx.YanSe where sqyf.ShouQuYiFuID = {dgv_dingdan.SelectedRows[0].Cells[0].Value.ToString()}";
                DataTable dt = db.GetData(sql);
                dgv_xiangxi.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

        #endregion
        #region
        /// <summary>
        /// 会员
        /// </summary>
        /// <param name="cha"></param>
        /// 

        private void button2_Click(object sender, EventArgs e)
        {
            TongJiHuiYuan(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TongJiHuiYuan(0);
        }
        public void TongJiHuiYuan(int cha)
        {
            dgv_huiyuan.AutoGenerateColumns = false;
            string sql = $"select * from HuiYuan as hy inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = hy.ZhongLei inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join HuiYuanTime as hytime on hytime.ShiJianID = hy.ShiJian";
            DataTable dt = db.GetData(sql);
            StringBuilder strTime1 = new StringBuilder(huiyuan_time.Value.Year.ToString());
            strTime1.AppendFormat("-{0}-{1}", huiyuan_time.Value.Month.ToString(), huiyuan_time.Value.Day.ToString());
            StringBuilder strTime2 = new StringBuilder(huiyuanend_time.Value.Year.ToString());
            strTime2.AppendFormat("-{0}-{1}", huiyuanend_time.Value.Month.ToString(), huiyuanend_time.Value.Day.ToString());
            DataView dv = new DataView(dt);
            if(cha == 1)
            {
                dv.RowFilter = $"NowTime >= '{strTime1.ToString()}' and NowTime <= '{strTime2.ToString()}'";
            }
            else
            {
                dgv_huiyuan.DataSource = dv;
            }
            dgv_huiyuan.DataSource = dv;
            lab_huiyuane.Text = HuiYuanXiaoFei().ToString();
        }
        public double HuiYuanXiaoFei()
        {
            double huiXiaoE = 0;
            foreach(DataGridViewRow dgvr in dgv_huiyuan.Rows)
            {
                huiXiaoE += double.Parse(dgvr.Cells["Column7"].Value.ToString());
            }
            return huiXiaoE;
        }
        //会员充值记录
        private void dgv_huiyuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_huiyuan.Rows.Count > 0)
            {
                dgv_huiyuanjilu.AutoGenerateColumns = false;
                string sql = $"select * from HuiYuan as hy inner join ChongZhiJiLu as czjl on czjl.HuiYuanId = hy.HuiYuanID where hy.HuiYuanID = {dgv_huiyuan.SelectedRows[0].Cells[0].Value.ToString()}";
                DataTable dt = db.GetData(sql);
                dgv_huiyuanjilu.DataSource = dt;
            }

        }
        #endregion
    }
}

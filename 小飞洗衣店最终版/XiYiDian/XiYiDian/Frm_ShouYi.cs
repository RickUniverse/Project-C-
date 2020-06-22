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
    public partial class Frm_ShouYi : Form
    {
        public Frm_ShouYi()
        {
            InitializeComponent();
        }
        public string kaHao;
        double jiaGe = 0;
        DBHelper db = new DBHelper();
        private void Frm_ShouYi_Load(object sender, EventArgs e)
        {
            ChaTian();
            lab_zhifu.Text = TianYi().ToString();
            jiaGe = double.Parse(lab_zhifu.Text);
        }
        #region
        public void ChaTian()
        {
            string sql = $"select * from HuiYuan as hy inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = hy.ZhongLei inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join HuiYuanTime as hytime on hytime.ShiJianID = hy.ShiJian where hy.HuiYuanID = {kaHao}";
            DataTable dt = db.GetData(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                lab_kahao.Text = dt.Rows[0]["HuiYuanID"].ToString();
                lab_mingcheng.Text = dt.Rows[0]["HuiYuanRenName"].ToString();
                lab_zhonglei.Text = dt.Rows[0]["HuiYuanZhongLeiName"].ToString();
                lab_zhuangtai.Text = dt.Rows[0]["HuiYuanZhuangTai"].ToString();
                lab_zonge.Text = dt.Rows[0]["XiaoFeiZongE"].ToString();
                lab_yue.Text = dt.Rows[0]["YuE"].ToString();
                lab_phone.Text = dt.Rows[0]["HuiYuanPhone"].ToString();
            }
        }
        public double TianYi()
        {
            dgv_shouqu.AutoGenerateColumns = false;
            string sql = $"select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan where hy.HuiYuanID = {kaHao} and ShiFouJieZhang = '否' ";
            DataTable dt = db.GetData(sql);
            dgv_shouqu.DataSource = dt;

            double jinE = 0;
            for(int a = 0; a < dt.Rows.Count; a++)
            {
                jinE += double.Parse(dt.Rows[a]["ShiShouJinE"].ToString());
            }
            lab_zhifu.Text = jinE.ToString();
            return jinE;
        }

        #endregion
        private void button4_Click(object sender, EventArgs e)
        {

            if (ChanWeiJie())
            {
                this.Close();
            }
            
        }
        //查看是否有未结账单
        public bool ChanWeiJie()
        {
            string sql = $"select * from ShouQuYiFu as sqyf inner join DingDanXiangXi as ddxx on ddxx.SuoShuDingDan = sqyf.ShouQuYiFuID inner join XiYiFangShi as xyfs on xyfs.LeiXingID = ddxx.XiFangShi inner join YiFuZhongLei as yfzl on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai inner join YiFuYanSe as yfys on yfys.YanSeID = ddxx.YanSe inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan where hy.HuiYuanID = {kaHao} and ShiFouJieZhang = '否' ";
            DataTable dt = db.GetData(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("还有未结账单！");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Frm_TianJiaYiFu frm = new Frm_TianJiaYiFu();
            frm.kaHao = kaHao;
            frm.Time = dateTime_quyi.Value.ToString();
            frm.ShowDialog();
            lab_zhifu.Text = TianYi().ToString();
            jiaGe = double.Parse(lab_zhifu.Text);
        }
        //刷新
        private void button5_Click(object sender, EventArgs e)
        {
            //TianWeiJie();
            ChaTian();
            lab_tishi.Text = "当前显示的是未结账单";
            lab_zhifu.Text = TianYi().ToString();
            jiaGe = double.Parse(lab_zhifu.Text);
            //MessageBox.Show(jiaGe.ToString());
        }
        public void ShanDan()
        {
            if (dgv_shouqu.Rows.Count != 0)
            {
                DialogResult dr = MessageBox.Show("确定删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.OK)
                {
                    string yiBian = dgv_shouqu.SelectedRows[0].Cells[0].Value.ToString();
                    string sql1 = $"select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan where sqyf.ShouQuYiFuID = {yiBian} and ShiFouJieZhang = '否'";
                    DataTable dt = db.GetData(sql1);
                    if (dt.Rows.Count > 0)
                    {
                        DialogResult dr2 = MessageBox.Show("还未结账，确定删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        if (dr2 == DialogResult.OK)
                        {
                            
                            string sql5 = $"select count(*) from DingDanXiangXi where SuoShuDingDan = {yiBian}";
                            if (Convert.ToInt32(db.GetOne(sql5)) > 0)
                            {
                                string sql4 = $"delect DingDanXiangXi where SuoShuDingDan = {yiBian}";
                                db.Update(sql4);
                                string sql = $"delete ShouQuYiFu where ShouQuYiFuID = {yiBian}";
                                int enq = db.Update(sql);
                                if (enq > 0)
                                {
                                    MessageBox.Show("删除成功！");
                                    TianYi();
                                }
                            }
                            else
                            {
                                string sql = $"delete ShouQuYiFu where ShouQuYiFuID = {yiBian}";
                                int enq = db.Update(sql);
                                if (enq > 0)
                                {
                                    MessageBox.Show("删除成功！");
                                    TianYi();
                                }
                            }   
                        }
                    }
                    else
                    {
                        string sql5 = $"select count(*) from DingDanXiangXi where SuoShuDingDan = {yiBian}";
                        if (Convert.ToInt32(db.GetOne(sql5)) > 0)
                        {
                            string sql4 = $"delect DingDanXiangXi where SuoShuDingDan = {yiBian}";
                            db.Update(sql4);
                            string sql = $"delete ShouQuYiFu where ShouQuYiFuID = {yiBian}";
                            int enq = db.Update(sql);
                            if (enq > 0)
                            {
                                MessageBox.Show("删除成功！");
                                TianYi();
                            }
                        }
                        else
                        {
                            string sql = $"delete ShouQuYiFu where ShouQuYiFuID = {yiBian}";
                            int enq = db.Update(sql);
                            if (enq > 0)
                            {
                                MessageBox.Show("删除成功！");
                                TianYi();
                            }
                        }
                    }
                }
            }
        }
        //删除
        private void button2_Click(object sender, EventArgs e)
        {
            ShanDan();
            jiaGe = double.Parse(lab_zhifu.Text);
        }
        //结账
        private void button3_Click(object sender, EventArgs e)
        {
            JieZhang();
        }
        public void JieZhang()
        {
            DialogResult dr = MessageBox.Show("确定结账？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                string sql = $"select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan where hy.HuiYuanID = {kaHao} and ShiFouJieZhang = '否' ";
                DataTable dt = db.GetData(sql);

                if (dt.Rows.Count != 0)
                {
                    string sql3 = $"select * from HuiYuan as hy inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = hy.ZhongLei inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join HuiYuanTime as hytime on hytime.ShiJianID = hy.ShiJian where HuiYuanID = {kaHao}";
                    DataTable dt3 = db.GetData(sql3);
                    double xiaoFeiZong = double.Parse(dt3.Rows[0]["XiaoFeiZongE"].ToString());

                    double yuE = double.Parse(dt3.Rows[0]["YuE"].ToString());
                    if (yuE >= jiaGe)
                    {
                        yuE = yuE - jiaGe;
                        xiaoFeiZong += jiaGe;

                        string sql4 = $"update HuiYuan set XiaoFeiZongE = {xiaoFeiZong} , YuE = {yuE} where huiyuanid = {kaHao}";
                        int enq4 = db.Update(sql4);
                        if (enq4 > 0)
                        {
                            MessageBox.Show("结账成功！");
                            ChaTian();
                            TianYi();

                            for (int a = 0; a < dt.Rows.Count; a++)
                            {
                                if (a == dt.Rows.Count)
                                {
                                    break;
                                }

                                string syid = dt.Rows[a]["ShouQuYiFuID"].ToString();

                                DataTable dt2 = db.GetData(sql);
                                string sql2 = $"update ShouQuYiFu set ShiFouJieZhang = '是' where ShouQuYiFuID = {syid} and ShiFouJieZhang = '否'";
                                int enq = db.Update(sql2);
                            }
                            //ChaTian();
                            //TianYi();
                        }
                    }
                    else
                    {
                        string str = $"当前账户余额不足，是否充值？还差：{jiaGe - yuE}元";
                        DialogResult dr2 = MessageBox.Show(str, "提示！", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (dr2 == DialogResult.Yes)
                        {
                            Frm_HuiYuanChongZhi frm = new Frm_HuiYuanChongZhi();
                            frm.kaHao = kaHao;
                            frm.Show();
                        }
                    }
                        
                    
                }
                else
                {
                    MessageBox.Show("当前没有可结的账单！");
                }
                

                
            }
            
            
        }
        //刷新
        private void button6_Click(object sender, EventArgs e)
        {
            lab_tishi.Text = "当前显示的是已结账单";
            TianWeiJie();
            jiaGe = double.Parse(lab_zhifu.Text);
        }
        //未结账添加
        public void TianWeiJie()
        {
            string sql = $"select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan where hy.HuiYuanID = {kaHao} and ShiFouJieZhang = '是' ";
            DataTable dt = db.GetData(sql);
            dgv_shouqu.DataSource = dt;
        }
        //一结账添加
        private void button7_Click(object sender, EventArgs e)
        {
            lab_tishi.Text = "当前显示的是未结账单";
            TianYi();
            jiaGe = double.Parse(lab_zhifu.Text);
        }
        //单击详细
        private void dgv_shouqu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgv_xiangxi.AutoGenerateColumns = false;
                string sql = $"select * from ShouQuYiFu as sqyf inner join DingDanXiangXi as ddxx on ddxx.SuoShuDingDan = sqyf.ShouQuYiFuID inner join XiYiFangShi as xyfs on xyfs.LeiXingID = ddxx.XiFangShi inner join YiFuZhongLei as yfzl on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai inner join YiFuYanSe as yfys on yfys.YanSeID = ddxx.YanSe where sqyf.ShouQuYiFuID = {dgv_shouqu.SelectedRows[0].Cells[0].Value.ToString()}";
                DataTable dt = db.GetData(sql);
                dgv_xiangxi.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }
    }
}

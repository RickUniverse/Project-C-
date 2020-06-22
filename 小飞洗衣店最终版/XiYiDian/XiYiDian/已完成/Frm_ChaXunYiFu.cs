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
    public partial class Frm_ChaXunYiFu : Form
    {
        public Frm_ChaXunYiFu()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void button2_Click(object sender, EventArgs e)
        {
            if (NoNull())
            {
                TianRu();
                if (dgv_tianru.Rows.Count == 0)
                {
                    MessageBox.Show("没有此单号或该用户没有订单");
                }
            }
        }
        public void TianRu()
        {
            dgv_tianru.AutoGenerateColumns = false;
            string sql = $"select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan inner join DingDanZhuangTai as ddzt on ddzt.DingDanZhuangTai = sqyf.DingDanZhuangTai where sqyf.lianXiDianHua like '%{tex_chaxun.Text}%' or hy.HuiYuanID like '%{tex_chaxun.Text}%' or hy.HuiYuanRenName like '%{tex_chaxun.Text}%' or sqyf.ShouQuYiFuID like '%{tex_chaxun.Text}%'";
            DataTable dt = db.GetData(sql);
            dgv_tianru.DataSource = dt;
            //XiuGaiYanSe();

        }
        public bool NoNull()
        {
            if (tex_chaxun.Text == string.Empty)
            {
                MessageBox.Show("请输入单号或会员号");
                tex_chaxun.Focus();
                return false;
            }
            return true;
        }
        //单机填入
        string danHao;
        public string yiFuZhuang;
        private void dgv_tianru_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_tianru.Rows.Count > 0)
            {
                string sql = $"select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan inner join DingDanZhuangTai as ddzt on ddzt.DingDanZhuangTai = sqyf.DingDanZhuangTai inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai where sqyf.ShouQuYiFuID = {dgv_tianru.SelectedRows[0].Cells[0].Value.ToString()}";
                DataTable dt = db.GetData(sql);
                labkahao.Text = dt.Rows[0]["HuiYuanID"].ToString();
                lab_xingming.Text = dt.Rows[0]["HuiYuanRenName"].ToString();
                lab_dianhua.Text = dt.Rows[0]["HuiYuanPhone"].ToString();
                lab_zhuangtaia.Text = dt.Rows[0]["HuiYuanZhuangTai"].ToString();
                lab_xuanzhong.Text = dgv_tianru.SelectedRows[0].Cells[0].Value.ToString();
                

                XiangXiDingDan();
                XiuGaiYanSe();
                lab_yifubian.Text = "";
            }
        } 
        public void XiangXiDingDan()
        {
            try
            {
                dgv_xiangxi.AutoGenerateColumns = false;
                string sql = $"select * from ShouQuYiFu as sqyf inner join DingDanXiangXi as ddxx on ddxx.SuoShuDingDan = sqyf.ShouQuYiFuID inner join XiYiFangShi as xyfs on xyfs.LeiXingID = ddxx.XiFangShi inner join YiFuZhongLei as yfzl on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai inner join YiFuYanSe as yfys on yfys.YanSeID = ddxx.YanSe where sqyf.ShouQuYiFuID = {dgv_tianru.SelectedRows[0].Cells[0].Value.ToString()}";
                DataTable dt = db.GetData(sql);
                dgv_xiangxi.DataSource = dt;
                danHao = dt.Rows[0]["ShouQuYiFuID"].ToString();
            }
            catch (Exception ex)
            {

            }
        }
        private void Frm_ChaXunYiFu_Load(object sender, EventArgs e)
        {
            TianRuCob();
            QuanBu();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ChaZhongLei();
        }
        public void TianRuCob()
        {
            string sql = "select * from DingDanZhuangTai";
            DataTable dt = db.GetData(sql);
            com_zhuang.DataSource = dt;
            com_zhuang.DisplayMember = "ZhuangTaiMing";
            com_zhuang.ValueMember = "DingDanZhuangTai";

        }
        DataTable dt4 = null;
        public void ChaZhongLei()
        {
            dgv_tianru.AutoGenerateColumns = false;
            string sql4 = $"select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan inner join DingDanZhuangTai as ddzt on ddzt.DingDanZhuangTai = sqyf.DingDanZhuangTai";
            dt4 = db.GetData(sql4);
            DataView dv = new DataView(dt4);
            if (com_zhuang.Text != "全部")
            {
                dv.RowFilter = string.Format("DingDanZhuangTai = {0}", com_zhuang.SelectedValue);
            }
            dgv_tianru.DataSource = dv;
            //XiuGaiYanSe();
        }
        //修改dgv行颜色
        public void XiuGaiYanSe()
        {
            foreach (DataGridViewRow dgvr in dgv_xiangxi.Rows)
            {
                if (dgvr.Cells["Column5"].Value.ToString() == "退款")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (dgvr.Cells["Column5"].Value.ToString() == "未完成")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Orange;
                }
                else if (dgvr.Cells["Column5"].Value.ToString() == "已取走")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Green;
                }
                else if (dgvr.Cells["Column5"].Value.ToString() == "未取走")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (dgvr.Cells["Column5"].Value.ToString() == "重洗")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.Brown;
                }
                else
                {
                    dgvr.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
        public void QuanBu()
        {
            dgv_tianru.AutoGenerateColumns = false;
            string sql = $"select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan inner join DingDanZhuangTai as ddzt on ddzt.DingDanZhuangTai = sqyf.DingDanZhuangTai";
            DataTable dt4 = db.GetData(sql);
            dgv_tianru.DataSource = dt4;
            //XiuGaiYanSe();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            QuanBu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            StringBuilder strTime1 = new StringBuilder(dateTimePicker1.Value.Year.ToString());
            strTime1.AppendFormat("-{0}-{1}", dateTimePicker1.Value.Month.ToString(), dateTimePicker1.Value.Day.ToString());
            StringBuilder strTime2 = new StringBuilder(dateTime_end.Value.Year.ToString());
            strTime2.AppendFormat("-{0}-{1}", dateTime_end.Value.Month.ToString(), dateTime_end.Value.Day.ToString());
            //MessageBox.Show(strTime1.ToString(), strTime2.ToString());
            dgv_tianru.AutoGenerateColumns = false;
            string sql4 = $"select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan inner join DingDanZhuangTai as ddzt on ddzt.DingDanZhuangTai = sqyf.DingDanZhuangTai where sqyf.ShouQuTime between '{strTime1.ToString()}' and '{strTime2.ToString()}'";
            DataTable dt4 = db.GetData(sql4);
            dgv_tianru.DataSource = dt4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lab_yifubian.Text != "")
            {
                if (yiFuZhuang == "未取走" || yiFuZhuang == "已取走")
                {
                    MessageBox.Show("该衣服已完成！");
                    return;
                }
                else if (yiFuZhuang == "退款")
                {
                    MessageBox.Show("已经退款！");
                    return;
                }
                Frm_ShangGua frm = new Frm_ShangGua();
                frm.dingDan = lab_yifubian.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("请选中衣服！");
            }
        }
        //lab_chaxun控件的查询
        public void Lab_Tian(string sql)
        {
            if(danHao != null)
            {
                dgv_xiangxi.AutoGenerateColumns = false;
                string sql4 = $"select * from DingDanXiangXi as ddxx inner join ShouQuYiFu as sqyf on sqyf.ShouQuYiFuID = ddxx.SuoShuDingDan inner join XiYiFangShi as xyfs on xyfs.LeiXingID = ddxx.XiFangShi inner join YiFuZhongLei as yfzl on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai inner join YiFuYanSe as yfys on yfys.YanSeID = ddxx.YanSe where ddxx.SuoShuDingDan = {danHao}";
                dt4 = db.GetData(sql4);
                DataView dv = new DataView(dt4);
                dv.RowFilter = string.Format(sql);
                dgv_xiangxi.DataSource = dv;
            }
            XiuGaiYanSe();
        }

        private void lab_weiwancheng_Click(object sender, EventArgs e)
        {
            Lab_Tian("YiFuZhuangTaiID = 1");
        }

        private void lab_yiquzou_Click(object sender, EventArgs e)
        {
            Lab_Tian("YiFuZhuangTaiID = 3");
        }

        private void lab_weiquzou_Click(object sender, EventArgs e)
        {
            Lab_Tian("YiFuZhuangTaiID = 2");
        }

        private void lab_chongxi_Click(object sender, EventArgs e)
        {
            Lab_Tian("YiFuZhuangTaiID = 5");
        }

        private void lab_tuikuan_Click(object sender, EventArgs e)
        {
            Lab_Tian("YiFuZhuangTaiID = 6");
        }

        private void lab_qita_Click(object sender, EventArgs e)
        {
            Lab_Tian("YiFuZhuangTaiID = 7");
        }
        //选择衣服
        private void dgv_xiangxi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lab_yifubian.Text = dgv_xiangxi.SelectedRows[0].Cells[0].Value.ToString();
            yiFuZhuang = dgv_xiangxi.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}

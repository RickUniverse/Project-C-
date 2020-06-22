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
    public partial class Frm_LingQuYiFu : Form
    {
        public Frm_LingQuYiFu()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void button5_Click(object sender, EventArgs e)
        {
            if (NoNull())
            {
                TianRu();
            }
        }
        //点击查询填入数据
        public void TianRu()
        {
            dgv_tianru.AutoGenerateColumns = false;
            string sql = $"select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan inner join DingDanZhuangTai as ddzt on ddzt.DingDanZhuangTai = sqyf.DingDanZhuangTai where sqyf.lianXiDianHua like '%{tex_chaxun.Text}%' or hy.HuiYuanID like '%{tex_chaxun.Text}%' or hy.HuiYuanRenName like '%{tex_chaxun.Text}%' or sqyf.ShouQuYiFuID like '%{tex_chaxun.Text}%'";
            DataTable dt = db.GetData(sql);
            dgv_tianru.DataSource = dt;

        }
        public bool NoNull()
        {
            if(tex_chaxun.Text == string.Empty)
            {
                MessageBox.Show("请输入单号或会员号");
                tex_chaxun.Focus();
                return false;
            }
            return true;
        }
        public void QuanBu()
        {
            dgv_tianru.AutoGenerateColumns = false;
            string sql = $"select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan inner join DingDanZhuangTai as ddzt on ddzt.DingDanZhuangTai = sqyf.DingDanZhuangTai";
            DataTable dt4 = db.GetData(sql);
            dgv_tianru.DataSource = dt4;
        }
        public string yiFuZhuang;
        private void dgv_tianru_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_tianru.Rows.Count > 0)
            {
                //if (dgv_tianru.SelectedRows.Count != 0)
                //{
                    dgv_XiangXi.AutoGenerateColumns = false;
                    string sql = $"select yfzl.*,sqyf.*,xylx.*,ys.*,hy.*,hyzl.*,yfzt.ZhuangTai as ZhuangT from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = hy.ZhongLei inner join YiFuZhongLei as yfzl on yfzl.YiFuZhongLeiID = sqyf.YiFuZhongLei inner join XiYiFangShi as xylx on xylx.LeiXingID = sqyf.XiFangShi inner join YiFuYanSe as ys on ys.YanSeID = sqyf.YanSe inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = sqyf.YiFuZhuangTai where sqyf.ShouQuYiFuID = {dgv_tianru.SelectedRows[0].Cells[0].Value.ToString()}";
                    DataTable dt = db.GetData(sql);
                    dgv_XiangXi.DataSource = dt;
                yiFuZhuang = dt.Rows[0]["ZhuangT"].ToString();
                lab_DangQian.Text = dgv_tianru.SelectedRows[0].Cells[0].Value.ToString();
                //}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lab_yifubian.Text != "")
            {
                if (yiFuZhuang == "已取走")
                {
                    MessageBox.Show("该衣服已取走！");
                    return;
                }
                else if (yiFuZhuang == "退款")
                {
                    MessageBox.Show("已经退款！");
                    return;
                }
                else if (yiFuZhuang == "未完成")
                {
                    MessageBox.Show("还未完成！");
                    return;
                }
                Frm_QuYiJeDan frm = new Frm_QuYiJeDan();
                frm.danHao = lab_yifubian.Text;
                frm.DingDanHao = lab_DangQian.Text;
                frm.ShowDialog();
                QuanBu();
            }
            else
            {
                MessageBox.Show("请选择需要收取的衣服!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lab_yifubian.Text != "")
            {
                if (yiFuZhuang == "已取走")
                {
                    MessageBox.Show("该衣服已完成！");
                    return;
                }
                else if (yiFuZhuang == "重洗")
                {
                    MessageBox.Show("不可重复重洗！");
                    return;
                }
                else if (yiFuZhuang == "退款")
                {
                    MessageBox.Show("已退款！");
                    return;
                }
                else if (yiFuZhuang == "未完成")
                {
                    MessageBox.Show("未完成不可重洗！");
                    return;
                }
                Frm_FanHuiChongXi frm = new Frm_FanHuiChongXi();
                frm.danHao = lab_yifubian.Text;
                //frm.DingDanHao = lab_DangQian.Text;
                frm.ShowDialog();
                QuanBu();
            }
            else
            {
                MessageBox.Show("请选择衣服!");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lab_yifubian.Text != "")
            {
                if (yiFuZhuang == "已取走")
                {
                    MessageBox.Show("该衣服已取走！");
                    return;
                }
                else if (yiFuZhuang == "退款")
                {
                    MessageBox.Show("已经退款！");
                    return;
                }
                Frm_CeXiaoShanChu frm = new Frm_CeXiaoShanChu();
                frm.danHao = lab_yifubian.Text;
                frm.dingDanHao = lab_DangQian.Text;
                frm.ShowDialog();
                QuanBu();
            }
            else
            {
                MessageBox.Show("请选择衣服!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QuanBu();
        }

        private void Frm_LingQuYiFu_Load(object sender, EventArgs e)
        {
            QuanBu();
        }

        private void dgv_tianru_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            lab_DangQian.Text = dgv_tianru.SelectedRows[0].Cells[0].Value.ToString();
            XiangXiDingDan();
            lab_yifubian.Text = "";
        }
        public void XiangXiDingDan()
        {
            try
            {
                dgv_XiangXi.AutoGenerateColumns = false;
                string sql = $"select * from ShouQuYiFu as sqyf inner join DingDanXiangXi as ddxx on ddxx.SuoShuDingDan = sqyf.ShouQuYiFuID inner join XiYiFangShi as xyfs on xyfs.LeiXingID = ddxx.XiFangShi inner join YiFuZhongLei as yfzl on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai inner join YiFuYanSe as yfys on yfys.YanSeID = ddxx.YanSe where sqyf.ShouQuYiFuID = {dgv_tianru.SelectedRows[0].Cells[0].Value.ToString()}";
                DataTable dt = db.GetData(sql);
                dgv_XiangXi.DataSource = dt;
                //danHao = dt.Rows[0]["ShouQuYiFuID"].ToString();
            }
            catch (Exception ex)
            {

            }
        }
        //选择衣服
        private void dgv_XiangXi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lab_yifubian.Text = dgv_XiangXi.SelectedRows[0].Cells[0].Value.ToString();
            yiFuZhuang = dgv_XiangXi.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}

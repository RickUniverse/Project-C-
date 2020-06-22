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
    public partial class HuiYuanZongYeMian : Form
    {
        public HuiYuanZongYeMian()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            if (NoNull())
            {
                ChaXun();
            }
        }
        public bool NoNull()
        {
            if (tex_huiyuanhao.Text == string.Empty)
            {
                MessageBox.Show("请输入会员号或会员名");
                tex_huiyuanhao.Focus();
                return false;
            }
            return true;
        }
        //全部
        public void TianRu()
        {
            dgv_huiyuan.AutoGenerateColumns = false;
            string sql = $"select * from HuiYuan as hy inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = hy.ZhongLei inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join HuiYuanTime as hytime on hytime.ShiJianID = hy.ShiJian";
            DataTable dt = db.GetData(sql);
            dgv_huiyuan.DataSource = dt;

        }
        //加载
        private void HuiYuanZongYeMian_Load(object sender, EventArgs e)
        {
            TianRu();
        }
        //查询
        public void ChaXun()
        {
            //dgv_huiyuan.AutoGenerateColumns = false;
            string sql = $"select * from HuiYuan as hy inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = hy.ZhongLei inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join HuiYuanTime as hytime on hytime.ShiJianID = hy.ShiJian where hy.HuiYuanID like '%{tex_huiyuanhao.Text}%' or hy.Name like '%{tex_huiyuanhao.Text}%' ";
            DataTable dt = db.GetData(sql);
            dgv_huiyuan.DataSource = dt;
            if(dgv_huiyuan.Rows.Count == 0)
            {
                MessageBox.Show("没有此用户（会员）");
            }
        }
         //查询全部
        private void button7_Click(object sender, EventArgs e)
        {
            TianRu();
        }

        private void dgv_huiyuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XiangTian();
        }
        public void XiangTian()
        {
            string sql = $"select * from HuiYuan as hy inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = hy.ZhongLei inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join HuiYuanTime as hytime on hytime.ShiJianID = hy.ShiJian where hy.HuiYuanID = {dgv_huiyuan.SelectedRows[0].Cells[0].Value.ToString()}";
            DataTable dt = db.GetData(sql);
            lab_xingming.Text = dt.Rows[0]["HuiYuanRenName"].ToString();
            lab_sex.Text = dt.Rows[0]["Sex"].ToString();
            lab_zhonglei.Text = dt.Rows[0]["HuiYuanZhongLeiName"].ToString(); 
            lab_dianhua.Text = dt.Rows[0]["HuiYuanPhone"].ToString();
            lab_zhuangtai.Text = dt.Rows[0]["HuiYuanZhuangTai"].ToString();
            lab_tianjiashijian.Text = dt.Rows[0]["NowTime"].ToString();
            lab_daoqi.Text = dt.Rows[0]["EndTime"].ToString();
            lab_shengri.Text = dt.Rows[0]["ShengRi"].ToString();
            lab_dizhi.Text = dt.Rows[0]["XiangXiZhuZhi"].ToString();
            lab_xiaofei.Text = dt.Rows[0]["XiaoFeiZongE"].ToString();
            lab_yue.Text = dt.Rows[0]["YuE"].ToString();
            lab_zhekou.Text = dt.Rows[0]["SheKou"].ToString();
            lab_kahao.Text = dgv_huiyuan.SelectedRows[0].Cells[0].Value.ToString();
        }
        //添加会员
        private void button3_Click(object sender, EventArgs e)
        {
            Frm_TianJiaHuiYuan frm = new Frm_TianJiaHuiYuan();
            frm.Show();
        }
        //tuichu
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //充值
        private void button2_Click(object sender, EventArgs e)
        {
            if(lab_kahao.Text!= "")
            {
                if(lab_zhuangtai.Text == "报销" || lab_zhuangtai.Text == "挂失")
                {
                    MessageBox.Show("会员卡以报销或挂失不可进行此操作");
                    return;
                }
                    Frm_HuiYuanChongZhi frm = new Frm_HuiYuanChongZhi();
                    frm.kaHao = lab_kahao.Text;
                    frm.Show();
            }
            else
            {
                MessageBox.Show("请选择会员!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(lab_kahao.Text != "")
            {
                DialogResult dr = MessageBox.Show("确定删除该会员？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if(dr == DialogResult.OK)
                {
                    string sql = $"delete HuiYuan where HuiYuanID = {lab_kahao.Text}";
                    int enq = db.Update(sql);
                    if (enq > 0)
                    {
                        MessageBox.Show("已成功删除该会员！");
                        TianRu();
                    }
                }
            }
            else
            {
                MessageBox.Show("无可删除会员！");
            }
        }
        //修改会员
        private void button4_Click(object sender, EventArgs e)
        {
            if (lab_kahao.Text != "")
            {
                Frm_XiuGaiHui frm = new Frm_XiuGaiHui();
                frm.kaHao = lab_kahao.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("请选择需要进行修改的会员！");
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lab_kahao.Text != "")
            {
                if (lab_zhuangtai.Text == "报销" || lab_zhuangtai.Text == "挂失")
                {
                    MessageBox.Show("会员卡以报销或挂失不可进行此操作");
                    return;
                }
                Frm_HuiShengJi frm = new Frm_HuiShengJi();
                frm.kaHao = lab_kahao.Text;
                frm.ShowDialog();
                XiangTian();
            }
            else
            {
                MessageBox.Show("请选择需要进行升级的会员！");
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lab_kahao.Text != "")
            {
                if (lab_zhuangtai.Text == "报销" || lab_zhuangtai.Text == "挂失")
                {
                    MessageBox.Show("会员卡以报销或挂失不可进行此操作");
                    return;
                }
                Frm_HuiYuanTuiKuan frm = new Frm_HuiYuanTuiKuan();
                frm.kaHao = lab_kahao.Text;
                frm.ShowDialog();
                XiangTian();
            }
            else
            {
                MessageBox.Show("请选择需要进行退款的会员！");
            }
        }
    }
}

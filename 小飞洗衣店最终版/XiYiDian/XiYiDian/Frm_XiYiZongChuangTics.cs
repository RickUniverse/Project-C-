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
    public partial class Frm_XiYiZongChuangTics : Form
    {
        public Frm_XiYiZongChuangTics()
        {
            InitializeComponent();
        }
        #region
        /// <summary>
        /// 跳转按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_XiTongSheZhi frm = new Frm_XiTongSheZhi();
            frm.ShowDialog();
        }
        private void 添加会员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TianJiaHuiYuan frm2 = new Frm_TianJiaHuiYuan();
            frm2.Show();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Frm_TianJiaHuiYuan frm = new Frm_TianJiaHuiYuan();
            frm.name = tex_cha.Text;
            frm.ShowDialog();
        }
        //添加会员
        #endregion
        DBHelper db = new DBHelper();
        #region
        /// <summary>
        /// 添加会员信息衣服信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (NoNull())
            {
                if (ChaTian())
                {
                    TianYi();
                }
            }
        }
        //判断是否为空
        public bool NoNull()
        {
            if(tex_cha.Text == string.Empty)
            {
                MessageBox.Show("请输入会员账号或者会员编号");
                tex_cha.Focus();
                return false;
            }
            return true;
        }
        //查添
        public bool ChaTian()
        {
            string sql = $"select * from HuiYuan as hy inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = hy.ZhongLei inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join HuiYuanTime as hytime on hytime.ShiJianID = hy.ShiJian where hy.HuiYuanID like '%{tex_cha.Text}%' or hy.HuiYuanRenName like '%{tex_cha.Text}%'";
            DataTable dt = db.GetData(sql);
            if(dt != null && dt.Rows.Count > 0)
            {
                lab_kahao.Text = dt.Rows[0]["HuiYuanID"].ToString();
                lab_mingcheng.Text = dt.Rows[0]["HuiYuanRenName"].ToString();
                lab_zhonglei.Text = dt.Rows[0]["HuiYuanZhongLeiName"].ToString();
                lab_zhuangtai.Text = dt.Rows[0]["HuiYuanZhuangTai"].ToString();
                lab_xiaofei.Text = dt.Rows[0]["XiaoFeiZongE"].ToString();
                lab_yue.Text = dt.Rows[0]["YuE"].ToString();
                lab_dianhua.Text = dt.Rows[0]["HuiYuanPhone"].ToString();
                lab_zhekou.Text = dt.Rows[0]["SheKou"].ToString();
                lab_riqi.Text = dt.Rows[0]["NowTime"].ToString();
                if (lab_kahao.Text == string.Empty)
                {
                    return false;
                }
                
            }
            else
            {
                MessageBox.Show("没有此用户");
                return false;
            }
            return true;
        }
        //添加衣服
        public void TianYi()
        {
            dgv_xinxi.AutoGenerateColumns = false;
            //string sql = $"select * from ShouQuYiFu as sqyf inner join DingDanXiangXi as ddxx on ddxx.SuoShuDingDan = sqyf.ShouQuYiFuID inner join XiYiFangShi as xyfs on xyfs.LeiXingID = ddxx.XiFangShi inner join YiFuZhongLei as yfzl on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai inner join YiFuYanSe as yfys on yfys.YanSeID = ddxx.YanSe inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan where hy.HuiYuanID = {lab_kahao.Text}";
            string sql = $"select * from ShouQuYiFu as sqyf inner join HuiYuan as hy on hy.HuiYuanID = sqyf.HuiYuan inner join DingDanZhuangTai as ddzt on ddzt.DingDanZhuangTai = sqyf.DingDanZhuangTai where hy.HuiYuanID = {lab_kahao.Text}";
            DataTable dt = db.GetData(sql);
            dgv_xinxi.DataSource = dt;
        }
        public void TianXiangXi()
        {
            //MessageBox.Show(dgv_xinxi.SelectedRows.Count.ToString());
            try
            {
                dgv_xiangxi.AutoGenerateColumns = false;
                string sql = $"select * from ShouQuYiFu as sqyf inner join DingDanXiangXi as ddxx on ddxx.SuoShuDingDan = sqyf.ShouQuYiFuID inner join XiYiFangShi as xyfs on xyfs.LeiXingID = ddxx.XiFangShi inner join YiFuZhongLei as yfzl on yfzl.YiFuZhongLeiID = ddxx.YiFuZhongLei inner join YiFuZhuangTai as yfzt on yfzt.YiFuZhuangTaiID = ddxx.YiFuZhuangTai inner join YiFuYanSe as yfys on yfys.YanSeID = ddxx.YanSe where sqyf.ShouQuYiFuID = {dgv_xinxi.SelectedRows[0].Cells[0].Value.ToString()}";
                DataTable dt = db.GetData(sql);
                dgv_xiangxi.DataSource = dt;
            }catch(Exception ex)
            {

            }
                
        }

        private void 查看详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TianXiangXi();
        }

        private void dgv_xinxi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TianXiangXi();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lab_kahao.Text != "")
            {
                if(lab_zhuangtai.Text == "报销")
                {
                    MessageBox.Show("该会员已报销不可使用！");
                    return;
                }
                else if (lab_zhuangtai.Text == "挂失")
                {
                    MessageBox.Show("该会员已挂失不可使用！");
                    return;
                }
                else
                {
                    Frm_ShouYi frm = new Frm_ShouYi();
                    frm.kaHao = lab_kahao.Text;
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("卡号为空！");
            }
        }

        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            QingKong();
        }
        public void QingKong()
        {
            tex_cha.Text = "";
            lab_kahao.Text = "";
            lab_mingcheng.Text = "";
            lab_zhonglei.Text = "";
            lab_zhuangtai.Text = "";
            lab_xiaofei.Text = "";
            lab_yue.Text = "";
            lab_dianhua.Text = "";
            lab_zhekou.Text = "";
            lab_riqi.Text = "";
            //dgv_xinxi.Rows.Clear();
            //dgv_xiangxi.Rows.Clear();
        }
        //刷新
        private void button7_Click(object sender, EventArgs e)
        {
            if(lab_kahao.Text != "")
            {
                TianYi();
                ChaTian();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_LingQuYiFu frm = new Frm_LingQuYiFu();
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Frm_ChaXunYiFu frm = new Frm_ChaXunYiFu();
            frm.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Frm_ShangGua frm = new Frm_ShangGua();
            frm.Show();
        }

        private void 会员充值ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_HuiYuanChongZhi frm = new Frm_HuiYuanChongZhi();
            frm.Show();
        }

        private void 管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuiYuanZongYeMian frm = new HuiYuanZongYeMian();
            frm.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Frm_SuoPing frm = new Frm_SuoPing();
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (lab_kahao.Text != "")
            {
                Frm_ShouYi frm = new Frm_ShouYi();
                frm.kaHao = lab_kahao.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("卡号为空！");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HuiYuanZongYeMian frm = new HuiYuanZongYeMian();
            frm.Show();
        }

        private void Frm_XiYiZongChuangTics_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Frm_TongJi frm = new Frm_TongJi();
            frm.Show();
        }

        private void 添加会员ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_tianjiayuangong frm = new Frm_tianjiayuangong();
            frm.Show();
        }

        private void 删除员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_yuangongguanli frm = new Frm_yuangongguanli();
            frm.Show();
        }

        private void 结算工资ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_gongziguanli frm = new Frm_gongziguanli();
            frm.Show();
        }
    }
}

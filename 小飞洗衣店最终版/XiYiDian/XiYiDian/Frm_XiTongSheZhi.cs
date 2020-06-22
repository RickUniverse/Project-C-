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
    public partial class Frm_XiTongSheZhi : Form
    {
        public Frm_XiTongSheZhi()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void Frm_XiTongSheZhi_Load(object sender, EventArgs e)
        {
            HuiTian();
            ZhuangTian();
            YeWuTian();
            BiaoZhunTian();
            YanSeTian();
            YiFuZhuanTian();
            SuoPingTian();
        }
        #region
        /// <summary>
        /// 会员添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public void HuiTian()
        {
            dgv_huiyuan.AutoGenerateColumns = false;
            DataTable dt = db.GetData("select * from huiyuanzhonglei");
            dgv_huiyuan.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (NoNull())
            {
                if (double.Parse(tex_shekou.Text) > 1 || double.Parse(tex_shekou.Text) <= 0)
                {
                    MessageBox.Show("折扣不能大于1或小于等于0");
                }
                else
                {
                    string sql = string.Format("insert HuiYuanZhongLei values('{0}','{1}','{2}')", tex_zhonglei.Text, tex_shekou.Text,tex_jifen.Text);
                    if (db.Update(sql) > 0)
                    {
                        MessageBox.Show("添加成功！");
                        HuiTian();
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                    }
                }
            }
        }
        public bool NoNull()
        {
            if(tex_zhonglei.Text == "")
            {
                MessageBox.Show("种类不能为空！");
                tex_zhonglei.Focus();
                return false;
            }
            if (tex_shekou.Text == "")
            {
                MessageBox.Show("折扣不能为空！");
                tex_shekou.Focus();
                return false;
            }
            if (tex_jifen.Text == "")
            {
                MessageBox.Show("积分不能为空！");
                tex_jifen.Focus();
                return false;
            }
            return true;
        }
        public void ZhuangTian()
        {
            DataTable dt = db.GetData("select * from huiyuanzhuangtai");
            dgv_zhuang.DataSource = dt;
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(tex_zhuangtai.Text != "")
            {
                string sql = string.Format("insert HuiYuanzhuangtai values('{0}')", tex_zhuangtai.Text);
                int enq = db.Update(sql);
                if (enq > 0)
                {
                    MessageBox.Show("添加成功！");
                    ZhuangTian();
                }
            }
            else
            {
                MessageBox.Show("请输入状态名");
            }
        }
        //删除
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                string bianHao = dgv_huiyuan.SelectedRows[0].Cells[0].Value.ToString();
                if(bianHao != "2")
                {
                DialogResult dr = MessageBox.Show("确定删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.OK)
                {
                    string sql = string.Format("delete HuiYuanZhongLei where HuiYuanZhongLeiID = {0}", bianHao);
                    int enq = db.Update(sql);
                    if (enq > 0)
                    {
                        MessageBox.Show("删除成功！");
                        HuiTian();
                    }
                }
                }
                else
                {
                    MessageBox.Show("该种类不可删除！");
                }
                
            
        }
        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
                string bianHao = dgv_zhuang.SelectedRows[0].Cells[0].Value.ToString();
                if(!(bianHao.Equals("2")||bianHao.Equals("3")||bianHao.Equals("4")))
                {
                DialogResult dr = MessageBox.Show("确定删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.OK)
                {
                    string sql = string.Format("delete HuiYuanZhuangTai where HuiYuanZhuanTaiID = {0}", bianHao);
                    int enq = db.Update(sql);
                    if (enq > 0)
                    {
                        MessageBox.Show("删除成功！");
                        ZhuangTian();
                    }
                }
                }
                else
                {
                    MessageBox.Show("基本状态不可删除！");
                }
        }

        #endregion
        #region
        /// <summary>
        /// 衣服设置
        /// </summary>
        public void YeWuTian()
        {
            DataTable dt = db.GetData("select * from xiyifangshi");
            dgv_yewu.DataSource = dt;
            cob_yewu.DataSource = dt;
            cob_yewu.DisplayMember = "LeiXing";
            cob_yewu.ValueMember = "LeiXingID";
        }
        public void BiaoZhunTian()
        {
            DataTable dt = db.GetData("select XiYiFangShi.LeiXing,YiFuZhongLei.YiFuZhongLeiID ,YiFuZhongLei.YiFuName ,YiFuZhongLei.JiaGe from YiFuZhongLei inner join  XiYiFangShi on XiYiFangShi.LeiXingID = YiFuZhongLei.XiYiFangShi");
            dgv_shoubiao.DataSource = dt;
        }
        //业务添加
        private void button2_Click(object sender, EventArgs e)
        {
            if(tex_yewu.Text != "")
            {
                string sql = string.Format("insert XiYiFangShi values('{0}')",tex_yewu.Text);
                int enq = db.Update(sql);
                if (enq > 0)
                {
                    MessageBox.Show("添加成功！");
                    YeWuTian();
                }
            }
            else
            {
                MessageBox.Show("业务不能为空！");
            }
        }
        private void 删除ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                string bianHao = dgv_yewu.SelectedRows[0].Cells[0].Value.ToString();
                //MessageBox.Show(bianHao);
                string sql = string.Format("delete XiYiFangShi where LeiXingID = {0}", bianHao);
                int enq = db.Update(sql);
                if (enq > 0)
                {
                    MessageBox.Show("删除成功！");
                    YeWuTian();
                }
            }
        }

        public bool YeZhongNoNull()
        {
            if(cob_yewu.Text == "")
            {
                MessageBox.Show("请选择或添加业务！");
                return false;
            }
            if (tex_zhong.Text == "")
            {
                MessageBox.Show("种类不能为空！");
                return false;
            }
            if (tex_jiage.Text == "")
            {
                MessageBox.Show("请输入价格！");
                return false;
            }
            return true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (YeZhongNoNull())
            {
                string sql = string.Format("insert YiFuZhongLei values('{0}','{1}',{2})", tex_zhong.Text, tex_jiage.Text, cob_yewu.SelectedValue.ToString());
                int enq = db.Update(sql);
                if (enq > 0)
                {
                    MessageBox.Show("添加成功！");
                    BiaoZhunTian();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("删除业务时需要先将衣服种类里的与业务相关种类删除！");
        }

        private void 删除ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                string bianHao = dgv_shoubiao.SelectedRows[0].Cells[1].Value.ToString();
                //MessageBox.Show(bianHao);
                string sql = string.Format("delete YiFuZhongLei where YiFuZhongLeiID = {0}", bianHao);
                int enq = db.Update(sql);
                if (enq > 0)
                {
                    MessageBox.Show("删除成功！");
                    BiaoZhunTian();
                }
            }
        }
        
        public void YanSeTian()
        {
            DataTable dt = db.GetData("select * from YiFuYanSe");
            dgv_yan.DataSource = dt;
        }
        public void YiFuZhuanTian()
        {
            DataTable dt = db.GetData("select * from YiFuzhuangtai");
            dgv_yifuzhuangtai.DataSource = dt;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if(tex_yanse.Text != "")
            {
                string sql = string.Format("insert YiFuYanSe values('{0}')",tex_yanse.Text);
                int enq = db.Update(sql);
                if (enq > 0)
                {
                    MessageBox.Show("添加成功！");
                    YanSeTian();
                }
            }
            else
            {
                MessageBox.Show("请输入颜色");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tex_yifuzhuang.Text != "")
            {
                string sql = string.Format("insert YiFuzhuangtai values('{0}')", tex_yifuzhuang.Text);
                int enq = db.Update(sql);
                if (enq > 0)
                {
                    MessageBox.Show("添加成功！");
                    YiFuZhuanTian();
                }
            }
            else
            {
                MessageBox.Show("请输入");
            }
        }

        private void 删除ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                string bianHao = dgv_yan.SelectedRows[0].Cells[0].Value.ToString();
                //MessageBox.Show(bianHao);
                string sql = string.Format("delete YiFuYanSe where YanSeID = {0}", bianHao);
                int enq = db.Update(sql);
                if (enq > 0)
                {
                    MessageBox.Show("删除成功！");
                    YanSeTian();
                }
            }
        }

        private void 删除ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
                string bianHao = dgv_yifuzhuangtai.SelectedRows[0].Cells[0].Value.ToString();
                //MessageBox.Show(bianHao);
                if (!(bianHao.Equals("1")|| bianHao.Equals("2") || bianHao.Equals("3") || bianHao.Equals("5") || bianHao.Equals("6")))
                {
                DialogResult dr = MessageBox.Show("确定删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.OK)
                {
                    string sql = string.Format("delete YiFuZhuangTai where YiFuZhuangTaiID = {0}", bianHao);
                    int enq = db.Update(sql);
                    if (enq > 0)
                    {
                        MessageBox.Show("删除成功！");
                        YiFuZhuanTian();
                    }
                }
                }
                else
                {
                    MessageBox.Show("基本种类不可删除");
                }
        }
        #endregion
        #region
        /// <summary>
        /// 锁屏
        /// </summary>
        public void SuoPingTian()
        {
            DataTable dt = db.GetData("select * from AdminSuoPing");
            lab_dangqian.Text = dt.Rows[0][0].ToString();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if(tex_xin.Text != "")
            {
                string sql = string.Format("update [AdminSuoPing]  set Pwd = '{0}'", tex_xin.Text);
                int enq = db.Update(sql);
                if (enq > 0)
                {
                    MessageBox.Show("修改成功！");
                    SuoPingTian();
                }
            }
            else
            {
                MessageBox.Show("请输入新密码");
            }
        }

        #endregion

        private void label17_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void tex_xin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }

    }
}

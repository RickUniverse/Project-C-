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
    public partial class Frm_HuiYuanChongZhi : Form
    {
        public Frm_HuiYuanChongZhi()
        {
            InitializeComponent();
        }
        public string kaHao;
        DBHelper db = new DBHelper();
        private void Frm_HuiYuanChongZhi_Load(object sender, EventArgs e)
        {
            tex_huiyuanhao.Text = kaHao;
            if(tex_huiyuanhao.Text != "")
            {
                tex_huiyuanhao.Enabled = false;
                ChaTian();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NoNull())
            {
                ChaTian();
            }
        }
        public void ChaTian()
        {
            string sql = $"select * from HuiYuan as hy inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = hy.ZhongLei inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join HuiYuanTime as hytime on hytime.ShiJianID = hy.ShiJian where hy.HuiYuanID = {tex_huiyuanhao.Text}";
            DataTable dt = db.GetData(sql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有该会员");
                return;
            }
            lab_mingcheng.Text = dt.Rows[0]["HuiYuanRenName"].ToString();
            lab_dianhua.Text = dt.Rows[0]["HuiYuanPhone"].ToString();
            lab_zonge.Text = dt.Rows[0]["XiaoFeiZongE"].ToString();
            lab_yue.Text = dt.Rows[0]["YuE"].ToString();
        }
        public bool NoNull()
        {
            if (tex_huiyuanhao.Text == string.Empty)
            {
                MessageBox.Show("请输入会员号");
                tex_huiyuanhao.Focus();
                return false;
            }
            return true;
        }
        //充值
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateChong();
        }
        public void UpdateChong()
        {
            if(lab_mingcheng.Text != "")
            {
                double zongE =  double.Parse(lab_yue.Text) + double.Parse(tex_chongzhi.Text);
                string sql = $"update HuiYuan set YuE ={zongE} where huiyuanid = {kaHao}";
                int enq = db.Update(sql);
                if (enq > 0)
                {
                    MessageBox.Show("充值成功！");
                    string str = $"insert into ChongZhiJiLu values('{kaHao}',default,'{tex_chongzhi.Text}')";
                    db.Update(str);
                    lab_shishou.Text = tex_chongzhi.Text;
                    ChaTian();
                }
            }
            else
            {
                MessageBox.Show("请输入会员或未找到！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

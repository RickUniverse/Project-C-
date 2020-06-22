using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDaExpress
{
    public partial class FrmKuaiDiJieSuan : Form
    {
        public FrmKuaiDiJieSuan()
        {
            InitializeComponent();
        }
        //ChuangDi cd = new ChuangDi();
        int jiage = 0;
        private void FrmKuaiDiJieSuan_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ChuangDi.ZhongLiang.ToString(), "提示");
            //lab_zhongliang = cd.ZhongLiang
            lab_zhongliang.Text = ChuangDi.ZhongLiang.ToString();
            jiage = 12;
            ChuangDi.ZhongLiang = ChuangDi.ZhongLiang - 1;
            for(double a = ChuangDi.ZhongLiang; a > 0;a--)
            {
                jiage+= 10;
            }
            lab_jiage.Text = jiage.ToString();
            //double jiage = ChuangDi.ZhongLiang;
        }
        DBHelper db = new DBHelper();
        //确认支付单击
        private void button1_Click(object sender, EventArgs e)
        {
            string sql4 = string.Format("update UserExpressXinXI set KuaiDiMoney = {0} where Odd = {1}", jiage, ChuangDi.DanHaoJiaGe);
            int enq = db.JiRu(sql4);
            if (enq == 1)
            {
                MessageBox.Show("支付成功", "提示");
                this.Close();
            }
        }
    }
}

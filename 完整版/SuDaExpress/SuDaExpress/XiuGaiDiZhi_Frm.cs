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
    public partial class XiuGaiDiZhi_Frm : Form
    {
        public XiuGaiDiZhi_Frm()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            ChuangDi.XiuGaiDi = tex_xiugaiaddress.Text;
            //ChuangDi.XiuGaiPanDuan = 1;
            string lingshistr1 = string.Format("update UserExpressXinXI set ShouHuoAddress = '{0}' where Odd = {1}", ChuangDi.XiuGaiDi, ChuangDi.DanHao);
            int lingshi1 = db.JiRu(lingshistr1);
            if (lingshi1 > 0)
            {
                MessageBox.Show("修改成功", "提示");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

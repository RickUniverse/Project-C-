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
    public partial class TongJiKuaiDi : Form
    {
        public TongJiKuaiDi()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        public void ZongJianShu()
        {
            string sql =string.Format("select count(*) from UserExpressXinXI ");
            int lingshi_2 = Convert.ToInt32(db.GetOne(sql));
            lab_kuaidizongjian.Text = lingshi_2.ToString();
            string sql1 = string.Format("select SUM(KuaiDiMoney) from UserExpressXinXI ");
            int lingshi_3 = Convert.ToInt32(db.GetOne(sql1));
            lab_kuaidizongjian.Text = lingshi_2.ToString();
            lab_yingyee.Text = lingshi_3.ToString();
        }
        public bool NoNull()
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("不能大于起始时间");
                dateTimePicker1.Focus();
                return false;
            }
            return true;
        }
        public bool KuaiDiJiaRu()
        {
            DateTime qishishijiantime = dateTimePicker1.Value;
            DateTime zhongzhishijiantime2 = dateTimePicker2.Value;
            string sql = string.Format("select * from UserExpressXinXI where LanJianTime between '{0}' and '{1}'", qishishijiantime,zhongzhishijiantime2);
            DataView dv = new DataView(db.GetTable(sql));
            dataGridView1.DataSource = dv;

            string sql_1 = "select count(*) from UserExpressXinXI";
            int lingshi_2 = Convert.ToInt32(db.GetOne(sql_1));
            if (lingshi_2 == 0)
            {
                MessageBox.Show("当前没有快递单", "提示");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (NoNull())
            {
                this.dataGridView1.AutoGenerateColumns = false;
                if (KuaiDiJiaRu())
                {
                    ZongJianShu();
                }  
            }
        }
    }
}

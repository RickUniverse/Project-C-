using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuDaExpress
{
    public partial class TiaoZaoTianJia : Form
    {
        public TiaoZaoTianJia()
        {
            InitializeComponent();
        }
        #region
        //窗体加载,复合框
        DBHelper db = new DBHelper();
        private void TiaoZaoTianJia_Load(object sender, EventArgs e)
        {
            JiaRu();
        }
        public void JiaRu()
        {
            comboBox1.Text = "请选择...";
            string sql = string.Format("select * from TiaoZaoShangPinLeiXing");
            SqlDataReader sdr = db.GetSet(sql);
            while (sdr.Read())
            {
                comboBox1.Items.Add(sdr["LeiXing"].ToString());
            }
            sdr.Close();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (PanDuan())
            {
                TianJia();
            }
        }
        public void TianJia()
        {
            string sql = string.Format("insert CommodityTable values('{0}','{1}','{2}',{3},{4},0,0)", tex_shangpinname.Text,comboBox1.Text,tex_shangpinmiaosu.Text,int.Parse(tex_shangpinjiage.Text),ChuangDi.TiaoZaoUid);
            int lingshi = db.JiRu(sql);
            if (lingshi > 0)
            {
                MessageBox.Show("添加成功！", "提示");
            }
        }
        public bool PanDuan()
        {
            if(tex_shangpinname.Text == "")
            {
                MessageBox.Show("名称不能为空", "提示");
                tex_shangpinname.Focus();
                return false;
            }
            if (comboBox1.Text == "请选择...")
            {
                MessageBox.Show("请选择商品类型", "提示");
                comboBox1.Focus();
                return false;
            }
            if (tex_shangpinmiaosu.Text == "")
            {
                MessageBox.Show("商品描述不能为空", "提示");
                tex_shangpinmiaosu.Focus();
                return false;
            }
            if (tex_shangpinjiage.Text == "")
            {
                MessageBox.Show("输入商品价格", "提示");
                tex_shangpinjiage.Focus();
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

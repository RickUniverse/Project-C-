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
    public partial class KuaiDiBaoShi : Form
    {
        public KuaiDiBaoShi()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void KuaiDiBaoShi_Load(object sender, EventArgs e)
        {
            //this.dataGridView1.AutoGenerateColumns = false;
            this.WindowState = FormWindowState.Maximized;
            KuaiDiJiaRu();
        }
        public void KuaiDiJiaRu()
        {
            string sql = "select b.UserUid,ShouHuoRenName,ShouHuoAddress,ShouHuoRenPhone,NowAddress,YouDiRenName,YouDiAddress,YouDiRenPhone,b.Odd,LanJianTime,LiuYan ,q.ShuoMing,StaffNo,KuaiDiMoney from KuaiDiBaoShi as a inner join UserExpressXinXI as b on a.Odd = b.Odd inner join QianShou as q on QianShou = q.BiaoShi ";
            //DataTable dt = db.GetTable(sql);
            DataView dv = new DataView(db.GetTable(sql));
            //DataTable dt = new DataTable(db.GetTable(sql));
            dataGridView1.DataSource = dv;
            //SqlCommandBuilder builder = new SqlCommandBuilder(dv);
        }

        private void 删除QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShanChuBaoShi shanChuBaoShi = new ShanChuBaoShi();
            shanChuBaoShi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tex_kuaididanhao.Text == "")
            {
                MessageBox.Show("单号不能为空", "提示");
                this.tex_kuaididanhao.Focus();
            }
            else
            {
                if (!PanDuanChaXun())
                {
                    ShanChu();
                }
            }
        }
        public bool PanDuanChaXun()
        {
            string sql = string.Format("select count(*) from UserExpressXinXI where Odd = {0}", Convert.ToInt32(tex_kuaididanhao.Text));
            if (tex_kuaididanhao.Text == "")
            {
                MessageBox.Show("请输入单号", "提示");
                this.tex_kuaididanhao.Focus();
            }
            else if (tex_kuaididanhao.Text != "")
            {
                int lingshi = Convert.ToInt32(db.GetOne(sql));
                if (lingshi > 0)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("单号输入错误或无此快递", "提示");
                }
            }
            return true;
        }
        public void ShanChu()
        {
            //string sql = string.Format("delete from KuaiDiBaoShi where Odd = {0}", Convert.ToInt32(tex_kuaididanhao.Text));
            //DataSet ds = new DataSet();
            //SqlDataAdapter sda = new SqlDataAdapter(sql, db.Conn);
            //DataView dv = new DataView(db.GetTable(sql));
            //sda.Fill(ds.Tables["KuaiDiBaoShi"]);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //sda.Update(ds, "KuaiDiBaoShi");
            string sql4 = string.Format("delete from KuaiDiBaoShi where Odd = {0}", Convert.ToInt32(tex_kuaididanhao.Text));
            int enq = db.JiRu(sql4);
            if (enq == 1)
            {
                MessageBox.Show("删除成功", "提示");
                KuaiDiJiaRu();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 1)
            {
                return;
            }
            tex_kuaididanhao.Text = dataGridView1.SelectedRows[0].Cells["Column8"].Value.ToString();
        }
    }
}

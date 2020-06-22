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
    public partial class TouSuChuLi_Frm : Form
    {
        public TouSuChuLi_Frm()
        {
            InitializeComponent();
        }
        private void 删除QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShanChuBaoShi shanChuBaoShi = new ShanChuBaoShi();
            shanChuBaoShi.Show();
        }
        DBHelper db = new DBHelper();
        private void TouSuChuLi_Frm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            KuaiDiJiaRu();
        }
        public void KuaiDiJiaRu()
        {
            string sql = "select t.UserUid,ShouHuoRenName,ShouHuoAddress,ShouHuoRenPhone,NowAddress,YouDiRenName,YouDiAddress,YouDiRenPhone,t.Odd,LanJianTime,LiuYan ,q.ShuoMing,StaffNo,KuaiDiMoney,t.TouSuYuanYin from TouSuKaiDi as t inner join UserExpressXinXI as b on t.Odd = b.Odd inner join QianShou as q on QianShou = q.BiaoShi";
            //DataTable dt = db.GetTable(sql);
            DataView dv = new DataView(db.GetTable(sql));
            //DataTable dt = new DataTable(db.GetTable(sql));
            dataGridView1.DataSource = dv;
            //SqlCommandBuilder builder = new SqlCommandBuilder(dv);
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
            string sql4 = string.Format("delete from TouSuKaiDi where Odd = {0}", Convert.ToInt32(tex_kuaididanhao.Text));
            int enq = db.JiRu(sql4);
            if (enq == 1)
            {
                MessageBox.Show("删除成功", "提示");
                KuaiDiJiaRu();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
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
        //单击单元格加入快递单号
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 1)
            {
                return;
            }
            string danHao = dataGridView1.SelectedRows[0].Cells["Column8"].Value.ToString();
            this.tex_kuaididanhao.Text = danHao;
        }
    }
}

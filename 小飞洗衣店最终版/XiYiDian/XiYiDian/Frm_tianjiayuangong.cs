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
    public partial class Frm_tianjiayuangong : Form
    {
        public Frm_tianjiayuangong()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btntuichu_Click(object sender, EventArgs e)
        {
           
        }

        private void Frm_tianjiayuangong_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ka = "";
            if (rdinan.Checked)
            {
                ka = rdinan.Text;
            }
            else if (rdinu.Checked)
            {
                ka = rdinu.Text;
            }
            if (txtname.Text.Trim() == "" || txtshengid.Text.Trim() == "" || txtaddress.Text.Trim() == "")
            {
                MessageBox.Show("录入信息不完整");
            }
            else
            {
                string sql = $"insert into YuanGong values('{txtname.Text}','{ka}','{txtshengid.Text}','{txtiphone.Text}','{dtruzhitime.Value}','{txtaddress.Text}','无','无','0','0','0','0')";
                if (db.Update(sql) > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出!", "提示!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtshengid.Text = "";
            txtiphone.Text = "";
            txtiphone.Text = "";
            txtaddress.Text = "";
        }
    }
}

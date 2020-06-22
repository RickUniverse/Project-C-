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
    public partial class Frm_SuoPing : Form
    {
        public Frm_SuoPing()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region
        /// <summary>
        /// 时间
        /// </summary>
        private Timer Timer;
        private void Frm_SuoPing_Load(object sender, EventArgs e)
        {
            Timer tim = new Timer();
            tim.Interval = 1000;
            tim.Tick += new EventHandler(Timer_Tick);
            tim.Start();

            //
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.lab_shijian.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            if(tex_mima.Text != "")
            {
                string sql = $"select count(*) from AdminSuoPing where Pwd = {tex_mima.Text.Trim()}";
                int biJiao = Convert.ToInt32(db.GetOne(sql));
                if (biJiao > 0)
                {
                    this.Close();
                }
                else
                {
                    lab_tishi.Text = "密码错误";
                }
            }
            else
            {
                lab_tishi.Text = "密码不能为空";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tex_mima.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tex_mima.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tex_mima.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tex_mima.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tex_mima.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tex_mima.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tex_mima.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tex_mima.Text += "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tex_mima.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tex_mima.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tex_mima.Text = string.Empty;
        }
    }
}

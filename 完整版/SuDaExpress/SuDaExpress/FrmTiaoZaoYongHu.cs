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
    public partial class FrmTiaoZaoYongHu : Form
    {
        public FrmTiaoZaoYongHu()
        {
            InitializeComponent();
        }
        #region
        /// <summary>
        /// 缓冲页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //时间事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            //pictureBox1.Visible = false;
            ////label1.Text = timer1.Interval.ToString();
            //pictureBox1.Enabled = false;
            //but_tiaoguo.Visible = false;
            //but_tiaoguo.Enabled = false;
            this.Hide();
            FrmTiaoZao tz = new FrmTiaoZao();
            tz.Show();
            this.timer1.Enabled = false;
        }
        //按钮
        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = false;
            ////label1.Text = timer1.Interval.ToString();
            //pictureBox1.Enabled = false;
            //but_tiaoguo.Visible = false;
            //but_tiaoguo.Enabled = false;
            this.Hide();
            FrmTiaoZao tz = new FrmTiaoZao();
            tz.Show();
            this.timer1.Enabled = false;
        }
        #endregion
    }
}

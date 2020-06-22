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
    public partial class SuDaDengLu : Form
    {
        public SuDaDengLu()
        {
            InitializeComponent();
        }
        #region
        /// <summary>
        /// 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //退出
        private void but_tuichu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //右键按钮
        private void 推出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 最大化OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void 最小化UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //右键按钮
        #endregion
        DBHelper db = new DBHelper();
        #region
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_denglu_Click(object sender, EventArgs e)
        {
            //string sql = string.Format("select * from admin where {0} and {1}", tex_uid, tex_pwd);
            //int uid = 0;
            //int uid = int.Parse(tex_uid.Text);
            //MessageBox.Show(enq.ToString(), "输出");
            if (NoKong())
            {
                ChaZhao();
            }
        }
        public bool NoKong()
        {
            //bool kong = true;
            if (tex_uid.Text == "")
            {
                MessageBox.Show("请输入账号", "提示");
                this.tex_uid.Focus();
                return false;
            }
            if (tex_pwd.Text == "")
            {
                MessageBox.Show("请输入密码", "提示");
                this.tex_pwd.Focus();
                return false;
            }
            if (comb_leixing.Text == "请选择")
            {
                MessageBox.Show("请选择类型", "提示");
                this.comb_leixing.Focus();
                return false;
            }
            if (tex_uid.Text.Length < 6)
            {
                MessageBox.Show("账号长度不能小于六", "提示");
                this.tex_uid.Focus();
                return false;
            }
            if (tex_pwd.Text.Length < 6)
            {
                MessageBox.Show("密码长度不能小于六", "提示");
                this.tex_pwd.Focus();
                return false;
            }
            return true;
        }
        public void ChaZhao()
        {
            string sql = string.Format("select count(*) from admin where admuid = {0} and admpwd = '{1}'", tex_uid.Text.Trim(), tex_pwd.Text.Trim());
            string sql2 = string.Format("select count(*) from [user] where useruid = {0} and userpwd = '{1}'", tex_uid.Text.Trim(), tex_pwd.Text.Trim());

            if (comb_leixing.Text == "管理员")
            {
                int jieshou = Convert.ToInt32(db.GetOne(sql));
                if (jieshou > 0)
                {

                    MessageBox.Show("登陆成功！", "提示");
                    //
                    FrmGuanLiWindow fglw = new FrmGuanLiWindow();
                    this.Hide();
                    fglw.Show();

                }
                else
                {
                    MessageBox.Show("登录失败", "提示");
                }
            }
            else if (comb_leixing.Text == "跳蚤用户")
            {
                int jieshou_1 = Convert.ToInt32(db.GetOne(sql2));
                if (jieshou_1 > 0)
                {
                    ChuangDi.TiaoZaoUid = int.Parse(tex_uid.Text);
                    MessageBox.Show("登陆成功！", "提示");
                    FrmTiaoZaoYongHu tz = new FrmTiaoZaoYongHu();
                    this.Hide();
                    tz.Show();
                }
                else
                {
                    MessageBox.Show("登录失败", "提示");
                }
            }
            else
            {
                MessageBox.Show("错误！", "提示");
            }
        }

        private void tex_uid_TextChanged(object sender, EventArgs e)
        {
            if(tex_uid.Text != "")
            {
                if(tex_uid.Text.Length >= 6)
                {
                    lab_zhanghaotishi.ForeColor = Color.White;
                    lab_zhanghaotishi.Text = "账号";
                }
                else
                {
                    lab_zhanghaotishi.Text = "账号长度必须大于等于六！";
                    lab_zhanghaotishi.ForeColor = Color.Red;
                }
            }
            else
            {
                lab_zhanghaotishi.Text = "账号不能为空!";
                lab_zhanghaotishi.ForeColor = Color.Red;
                this.tex_uid.Focus();
            }
        }

        private void tex_pwd_TextChanged(object sender, EventArgs e)
        {
            if (tex_pwd.Text != "")
            {
                if (tex_pwd.Text.Length >= 6)
                {
                    lab_mimatishi.ForeColor = Color.White;
                    lab_mimatishi.Text = "密码";
                }
                else
                {
                    lab_mimatishi.Text = "账号长度必须大于等于六！";
                    lab_mimatishi.ForeColor = Color.Red;
                }
            }
            else
            {
                lab_mimatishi.Text = "账号不能为空!";
                lab_mimatishi.ForeColor = Color.Red;
                this.tex_pwd.Focus();
            }
        }
        #endregion
        //private void comb_leixing_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show(this.comb_leixing.Text,"提示");
        //}
    }
}

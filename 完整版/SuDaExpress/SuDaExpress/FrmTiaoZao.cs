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
    public partial class FrmTiaoZao : Form
    {
        public FrmTiaoZao()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();
        #region
        /// <summary>
        /// 事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //退出事件
        private void FrmTiaoZao_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //窗体加载事件
        private void FrmTiaoZao_Load(object sender, EventArgs e)
        {
            //标题名字
            string sql = string.Format("select * from [user] where useruid = {0}", ChuangDi.TiaoZaoUid);
            SqlDataReader sdr = db.GetSet(sql);
            sdr.Read();
            string str = string.Format("你好，跳蚤用户--{0}！", sdr["name"].ToString());
            this.Text = str;
            lab_tiaozaoname.Text = sdr["Name"].ToString();
            ChaXun();
            ChaXun2();
            KuaiDi();
        }
        #endregion
        #region
        //快递
        public void KuaiDi()
        {

            string sql = string.Format("select w.UserUid , q.ShuoMing , w.UserAdd ,YouDiRenPhone ,StaffNo from TiaoZaoWoDeKuaiDi as w inner join UserExpressXinXI as x on w.UserAdd = x.Odd inner join QianShou as q on q.BiaoShi = x.QianShou");
            //DataView dv = new DataView(db.GetTable(sql));
            //data_kuaidi.DataSource = dv;
            SqlDataReader sdr = db.GetSet(sql);
            while (sdr.Read())
            {
                //listView3.Items.Clear();
                ListViewItem lv = new ListViewItem();
                lv.Text = sdr["useruid"].ToString();
                lv.SubItems.Add(sdr["shuoming"].ToString());
                lv.SubItems.Add(sdr["UserAdd"].ToString());
                lv.SubItems.Add(sdr["YouDiRenPhone"].ToString());
                lv.SubItems.Add(sdr["StaffNo"].ToString());
                listView3.Items.Add(lv);
            }
            sdr.Close();
        }
        /// <summary>
        /// 签收 删除 报失 投诉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //单击签收事件
        private void button7_Click(object sender, EventArgs e)
        {
            if (PanDuan())
            {
                if (!ChaXunDanHao())
                {
                    QianShou();
                }
            }
        }
        public bool ChaXunDanHao()
        {
            string sql =string.Format("select count(*) from UserExpressXinXI where odd = {0}",int.Parse(tex_shurudanhao.Text));
            int lingshi_2 = Convert.ToInt32(db.GetOne(sql));
            if (lingshi_2 > 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show("单号错误，或无此快递", "提示");
                return true;
            }
            return true;
        }
        public bool ShouFouQian()
        {
            string sql = string.Format("select count(*) from UserExpressXinXI where QianShou = 2 and Odd = {0}", int.Parse(tex_shurudanhao.Text));
            int lingshi_2 = Convert.ToInt32(db.GetOne(sql));
            if (lingshi_2 > 0)
            {
                return false;
            }
            return true;
        }
        //签收投诉快递
        public void QianShou()
        {
            if (ShouFouQian())
            {
                DialogResult dr = MessageBox.Show("确定签收？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.OK)
                {
                    string sql4 = string.Format("update UserExpressXinXI set QianShou = 2 where Odd = {0}", int.Parse(tex_shurudanhao.Text));
                    int enq = db.JiRu(sql4);
                    if (enq == 1)
                    {
                        MessageBox.Show("已签收！", "提示");
                        listView3.Items.Clear();
                        KuaiDi();
                    }
                }
            }
            else
            {
                MessageBox.Show("已签收！不需要重复签收", "提示");
            }
                
        }
        //判断单号
        public bool PanDuan()
        {
            if(tex_shurudanhao.Text == "")
            {
                MessageBox.Show("请输入单号", "提示");
                tex_shurudanhao.Focus();
                return false;
            }

            return true;
        }
        //删除快递
        private void button8_Click(object sender, EventArgs e)
        {
            if (PanDuan())
            {
                if (!ChaXunDanHao())
                {
                    if (ShouFouQian())
                    {
                        MessageBox.Show("快递未签收！不能删除", "提示");
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("确定删除此快递单？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        if (dr == DialogResult.OK)
                        {
                            ShanChu();
                            KuaiDi();
                        }
                    }
                }
            }
        }
        //删除代码
        public void ShanChu()
        {
            string lingshistr1 = string.Format("delete from UserExpressXinXI where Odd = {0}", int.Parse(tex_shurudanhao.Text));
            int lingshi1 = db.JiRu(lingshistr1);
            string lingshistr2 = string.Format("delete from TiaoZaoWoDeKuaiDi where Odd = {0}", int.Parse(tex_shurudanhao.Text));
            int lingshi2 = db.JiRu(lingshistr2);
            if (lingshi1 > 0 && lingshi2 > 0)
            {
                MessageBox.Show("已删除此快递：", "提示");
            }
        }
        //投诉判断
        public bool TouSu()
        {
            if (tex_tousuyuanyin.Text == "")
            {
                MessageBox.Show("输入投诉原因!", "提示");
                tex_tousuyuanyin.Focus();
                return false;
            }
            return true;
        }
        public void TouKuaiDiYuan()
        {

        }
        //投诉快递员
        public bool TouSuKuaiDiYuan()
        {
            DialogResult dr = MessageBox.Show("是否投诉快递员？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                string sql = string.Format("select * from UserExpressXinXI where Odd = {0}", int.Parse(tex_shurudanhao.Text));
                SqlDataReader sdr = db.GetSet(sql);
                sdr.Read();
                string str = sdr["staffno"].ToString();
                string sql3 = string.Format("select * from staff where staffno = {0}", int.Parse(str));
                SqlDataReader sdr3 = db.GetSet(sql3);
                sdr3.Read();
                int a = Convert.ToInt32(sdr3["TouSuCiShu"]) + 1;
                string sql4 = string.Format("update staff set TouSuCiShu = {0} where staffno = {1}", a, Convert.ToInt32(sdr["StaffNo"]));
                int enq = db.JiRu(sql4);
                if (enq == 1)
                {
                    MessageBox.Show("投诉快递员成功！", "提示");
                }
                return true;
            }
            return false;
        }
        //是否重复投诉
        public bool ChongFuTou()
        {
            string sql = string.Format("select count(*) from TouSuKaiDi where odd = {0}", int.Parse(tex_shurudanhao.Text));
            int lingshi_2 = Convert.ToInt32(db.GetOne(sql));
            if (lingshi_2 > 0)
            {
                MessageBox.Show("你已投诉，无需重复投诉", "提示");
                return false;
            }
            return true;
        }
        //投诉快递
        private void button9_Click(object sender, EventArgs e)
        {
            if (PanDuan())
            {
                if (TouSu())
                {
                    if (!ChaXunDanHao())
                    {
                        //
                        if (ChongFuTou())
                        {
                            if (TouSuKuaiDiYuan())
                            {
                                string sql = string.Format("insert TouSuKaiDi values({0},{1},'{2}')", ChuangDi.TiaoZaoUid, int.Parse(tex_shurudanhao.Text), tex_tousuyuanyin.Text);
                                int lingshi = db.JiRu(sql);
                                if (lingshi > 0)
                                {
                                    MessageBox.Show("投诉快递单成功！", "提示");
                                }
                            }
                            else
                            {
                                string sql = string.Format("insert TouSuKaiDi values({0},{1},'{2}')", ChuangDi.TiaoZaoUid, int.Parse(tex_shurudanhao.Text), tex_tousuyuanyin.Text);
                                int lingshi = db.JiRu(sql);
                                if (lingshi > 0)
                                {
                                    MessageBox.Show("投诉成功！", "提示");
                                }
                            }
                        }
                    }
                }
            }
        }
        //是否重复报失
        public bool ChongFuBao()
        {
            string sql = string.Format("select count(*) from KuaiDiBaoShi where odd = {0}", int.Parse(tex_shurudanhao.Text));
            int lingshi_2 = Convert.ToInt32(db.GetOne(sql));
            if (lingshi_2 > 0)
            {
                MessageBox.Show("你已报失，无需重复报失", "提示");
                return false;
            }
            return true;
        }
        //快递报失
        private void button10_Click(object sender, EventArgs e)
        {
            if (PanDuan())
            {
                if (!ChaXunDanHao())
                {
                    if (ChongFuBao())
                    {
                        if (ShouFouQian())
                        {
                            //
                            string sql = string.Format("insert KuaiDiBaoShi values({0},{1})", ChuangDi.TiaoZaoUid, int.Parse(tex_shurudanhao.Text));
                            int lingshi = db.JiRu(sql);
                            if (lingshi > 0)
                            {
                                MessageBox.Show("已报失,正在处理请耐心等候", "提示");
                            }
                        }
                        else
                        {
                            MessageBox.Show("用户已签收，不能报失", "提示");
                        }
                    }
                }
            }
        }
#endregion
        #region
        //我的地摊添加
        //public void ListTianJia()
        //{
        //    string sql = string.Format("select * from CommodityTable where useruid = {0}", ChuangDi.TiaoZaoUid);
        //    SqlDataReader sdr = db.GetSet(sql);
        //    int q = 0;
        //    while (sdr.Read())
        //    {
        //        ListViewItem item = new ListViewItem();
        //        item.Text = sdr["ComName"].ToString();
        //        item.SubItems.Add(sdr["ComText"].ToString());
        //        item.SubItems.Add(sdr["ComMoney"].ToString());
        //        item.ImageIndex = q;
        //        list_wodeshangpin.Items.Add(item);
        //        q++;
        //    }
        //}
        private void button6_Click(object sender, EventArgs e)
        {
            list_wodeshangpin.Items.Clear();
            ChaXun2();
        }
        #endregion
        //我的地摊添加
        public void ChaXun2()
        {
                //string sql = string.Format("select ComName , ComText , ComMoney from TiaoZaoWoDeKuaiDi as w inner join CommodityTable as c on w.UserUid = c.UserUid where w.UserUid = {0})",ChuangDi.TiaoZaoUid);
                string sql = string.Format("select * from CommodityTable where UserUid = {0}",ChuangDi.TiaoZaoUid);
                SqlDataReader sdr = db.GetSet(sql);
                int q = 0;
                while (sdr.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = sdr["ComName"].ToString();
                    item.SubItems.Add(sdr["ComText"].ToString());
                    item.SubItems.Add(sdr["ComMoney"].ToString());
                    item.ImageIndex = q;
                    list_wodeshangpin.Items.Add(item);
                    q++;
                 }
            sdr.Close();
        }
        #region
        //主页面
        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            ChaXun();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            tex_chaxun.Text = "";
            ChaXun();
        }
        //主页面添加
        public void ChaXun()
        {
            if(tex_chaxun.Text == "")
            {
                string sql = string.Format("select * from CommodityTable");
                SqlDataReader sdr = db.GetSet(sql);
                int q = 0;
                while (sdr.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = sdr["ComName"].ToString();
                    item.SubItems.Add(sdr["ComText"].ToString());
                    item.SubItems.Add(sdr["ComMoney"].ToString());
                    item.ImageIndex = q;
                    listView2.Items.Add(item);
                    q++;
                }
            }
            else
            {
                string sql = string.Format("select * from [CommodityTable] where ComName like '%{0}%'", tex_chaxun.Text);
                SqlDataReader sdr = db.GetSet(sql);
                int q = 0;
                while (sdr.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = sdr["ComName"].ToString();
                    item.SubItems.Add(sdr["ComText"].ToString());
                    item.SubItems.Add(sdr["ComMoney"].ToString());
                    item.ImageIndex = q;
                    listView2.Items.Add(item);
                    q++;
                }
            }
        }
        #endregion
        #region
        //修改资料跟添加商品
        private void button3_Click(object sender, EventArgs e)
        {
            TiaoZaoTianJia ti = new TiaoZaoTianJia();
            ti.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TiaoZaoXiuGaiZiLiao xg = new TiaoZaoXiuGaiZiLiao();
            xg.Show();
        }

        #endregion
    }
}

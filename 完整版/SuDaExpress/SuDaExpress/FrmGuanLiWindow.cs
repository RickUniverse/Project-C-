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
    public partial class FrmGuanLiWindow : Form
    {
        public FrmGuanLiWindow()
        {
            InitializeComponent();
        }
        #region
        /// <summary>
        /// 推出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuanLiWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dr = MessageBox.Show("确定要退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr != DialogResult.OK)
                {
                    //Application.Exit();
                    //ChuangDi.dr = DialogResult.Cancel;
                    //System.Environment.Exit(0);
                    e.Cancel = true;
                    //Environment.Exit(0);

                }
                else
                {
                    Application.Exit();
                }
            }
        }
        #endregion
        #region
        /// <summary>
        /// 时间
        /// </summary>
        private Timer Timer;
        private void FrmGuanLiWindow_Load(object sender, EventArgs e)
        {
            Timer tim = new Timer();
            tim.Interval = 1000;
            tim.Tick += new EventHandler(Timer_Tick);
            tim.Start();
            //
            //label1.BackColor = Color.Transparent;
            //label1.Parent = pictureBox1;//将pictureBox1设为标签的父控件
            //pictureBox1.Controls.Add(label1);
            //label1.Location = new Point(80, 80);//重新设定标签的位置，这个位置时相对于父控件的左上角
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        #endregion
        #region
        /// <summary>
        /// 工具栏and菜单栏单击事件and控制text输入and菜单栏跟工具栏单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void 微商通道EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PanDuan_weishang())
            {
                if (PanDuan2_weishang())
                {

                    //MessageBox.Show("chenggong", "tishi");
                    if (!QianJia_weishang())
                    {
                        double zhongliang = double.Parse(num_weishang.Value.ToString());
                        //jt.ZhongLiang = zhongliang;
                        zhong = zhongliang + zhong;
                        DialogResult dr = MessageBox.Show("是否继续添加", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        if (dr == DialogResult.OK)
                        {
                            QingKongBuFen();
                        }
                        else
                        {
                            ChuangDi.ZhongLiang = zhong;
                            FrmKuaiDiJieSuan js = new FrmKuaiDiJieSuan();
                            js.Show();
                            QingKong_weishang();
                            QingKong2_weishang();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("UID或者快递员编号输入错误");
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (!PanDuan_weishang())
            {
                if (PanDuan2_weishang())
                {

                    //MessageBox.Show("chenggong", "tishi");
                    if (!QianJia_weishang())
                    {
                        double zhongliang = double.Parse(num_weishang.Value.ToString());
                        //jt.ZhongLiang = zhongliang;
                        zhong = zhongliang + zhong;
                        DialogResult dr = MessageBox.Show("是否继续添加", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        if (dr == DialogResult.OK)
                        {
                            QingKongBuFen();
                        }
                        else
                        {
                            ChuangDi.ZhongLiang = zhong;
                            FrmKuaiDiJieSuan js = new FrmKuaiDiJieSuan();
                            js.Show();
                            QingKong_weishang();
                            QingKong2_weishang();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("UID或者快递员编号输入错误");
            }
        }
        private void 接收快递统计LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TongJiKuaiDi tj = new TongJiKuaiDi();
            tj.Show();
        }

        private void 营业额统计GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TongJiKuaiDi tj = new TongJiKuaiDi();
            tj.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            TongJiKuaiDi tj = new TongJiKuaiDi();
            tj.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            TongJiKuaiDi tj = new TongJiKuaiDi();
            tj.Show();
        }
        //丢失
        private void 快递丢失YToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KuaiDiBaoShi kdbs = new KuaiDiBaoShi();
            kdbs.Show();
        }
        //投诉
        private void 投诉处理KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TouSuChuLi_Frm ts = new TouSuChuLi_Frm();
            ts.Show();
        }
        //添加员工
        private void 添加员工KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TianJiaYuanGong tjyg = new TianJiaYuanGong();
            tjyg.Show();
        }
        //员工管理按钮
        private void 员工管理DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YuanGongGuanLi yggl = new YuanGongGuanLi();
            yggl.Show();
        }

        private void 工资结算FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YuanGongJieSuan ygjs = new YuanGongJieSuan();
            ygjs.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            YuanGongGuanLi yggl = new YuanGongGuanLi();
            yggl.Show();
        }
        //揽入快递单击事件
        private void 揽入快递GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LanRu();
            if (!PanDuan())
            {
                if (PanDuan2())
                {
                    //MessageBox.Show("chenggong", "tishi");
                    QianJia();
                    QingKong();
                    double zhongliang = double.Parse(num_zhongliang.Value.ToString());
                    //jt.ZhongLiang = zhongliang;
                    ChuangDi.ZhongLiang = zhongliang;
                    FrmKuaiDiJieSuan js = new FrmKuaiDiJieSuan();
                    js.Show();
                    QingKong2();
                    //MessageBox.Show(zhongliang.ToString(),"提示");
                }
            }
            else
            {
                MessageBox.Show("UID或者快递员编号输入错误");
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //LanRu();
            if (!PanDuan())
            {
                if (PanDuan2())
                {
                    //MessageBox.Show("chenggong", "tishi");
                    QianJia();
                    QingKong();
                    double zhongliang = double.Parse(num_zhongliang.Value.ToString());
                    //jt.ZhongLiang = zhongliang;
                    ChuangDi.ZhongLiang = zhongliang;
                    FrmKuaiDiJieSuan js = new FrmKuaiDiJieSuan();
                    js.Show();
                    QingKong2();
                    //MessageBox.Show(zhongliang.ToString(),"提示");
                }
            }
            else
            {
                MessageBox.Show("UID或者快递员编号输入错误");
            }
        }
        //输入控制
        private void tex_shurudanhao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }

        private void tex_uid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }
        //查询单击
        private void 查询快递UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PanDuanChaXun())
            {
                ChaXun();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!PanDuanChaXun())
            {
                ChaXun();
            }
        }
        #endregion
        DBHelper db = new DBHelper();
        ChuangDi jt = new ChuangDi();
        #region
        /// <summary>
        /// 揽入快递
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            if (!PanDuan())
            {
                if (PanDuan2())
                {
                    //MessageBox.Show("chenggong", "tishi");
                    if (!QianJia())
                    {
                        QingKong();
                        double zhongliang = double.Parse(num_zhongliang.Value.ToString());
                        //jt.ZhongLiang = zhongliang;
                        ChuangDi.ZhongLiang = zhongliang;
                        FrmKuaiDiJieSuan js = new FrmKuaiDiJieSuan();
                        js.Show();
                        QingKong2();
                    }
                    //MessageBox.Show(zhongliang.ToString(),"提示");
                }               
            }
            else
            {
                MessageBox.Show("UID或者快递员编号输入错误");
            }
        }
        public bool PanDuan()
        {
            string sql = string.Format("select count(*) from [user] where useruid = '{0}'",tex_uid.Text);
            string sql2 = string.Format("select count(*) from staff where staffno = '{0}'", tex_kuaidiyuan.Text);
            string sql3 = string.Format("select * from staff where staffno = '{0}'", tex_kuaidiyuan.Text);
            int obj =Convert.ToInt32(db.GetOne(sql));
            int obj2 = Convert.ToInt32(db.GetOne(sql2));
            if(obj > 0 && obj2 > 0)
            {
                SqlDataReader sdr = db.GetSet(sql3);
                sdr.Read();
                int lingshi = Convert.ToInt32(sdr["kuaidijian"])+1;
                int lingshi2 = Convert.ToInt32(sdr["Wages"]) + 1;
                string sql4 = string.Format("update staff set kuaidijian = {0}  where staffno = '{1}'", lingshi, tex_kuaidiyuan.Text);
                int enq = db.JiRu(sql4);
                string sql5 = string.Format("update staff set Wages = {0}  where staffno = '{1}'", lingshi2, tex_kuaidiyuan.Text);
                int enq1 = db.JiRu(sql4);
                if (enq == 1)
                {
                    if(enq1 == 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool PanDuan2()
        {
            //if(tex_uid.Text == "")
            //{
            //    MessageBox.Show("请输入uid","提示");
            //    return false;
            //}
            if (texx_shouname.Text == "")
            {
                MessageBox.Show("请输入收货人的名字", "提示");
                this.texx_shouname.Focus();
                return false;
            }
            if (tex_shouaddress.Text == "")
            {
                MessageBox.Show("请输入收货地址", "提示");
                this.tex_shouaddress.Focus();
                return false;
            }
            if (tex_shouphone.Text == "")
            {
                MessageBox.Show("请输入收货人电话", "提示");
                this.tex_shouphone.Focus();
                return false;
            }
            if (tex_youname.Text == "")
            {
                MessageBox.Show("请输入邮递人姓名", "提示");
                this.tex_youname.Focus();
                return false;
            }
            if (tex_youaddress.Text == "")
            {
                MessageBox.Show("请输入邮递人地址", "提示");
                this.tex_youaddress.Focus();
                return false;
            }
            if (tex_youphone.Text == "")
            {
                MessageBox.Show("请输入邮递人电话", "提示");
                this.tex_youphone.Focus();
                return false;
            }
            if (tex_liuyan.Text == "")
            {
                MessageBox.Show("请留言", "提示");
                this.tex_liuyan.Focus();
                return false;
            }
            return true;
        }
         public bool QianJia()
        {
            DateTime time = time_lantime.Value;
           string sql = string.Format("insert UserExpressXinXI values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}' , 0 ,{9},0,'{10}')", int.Parse(tex_uid.Text), texx_shouname.Text, tex_shouaddress.Text, tex_shouphone.Text, tex_youname.Text, tex_youaddress.Text, tex_youphone.Text, time,tex_liuyan.Text,int.Parse(tex_kuaidiyuan.Text),tex_nowaddress.Text);
           int lingshi = db.JiRu(sql);
            if (lingshi > 0)
            {
                MessageBox.Show("快递单创建成功", "提示");
                string sql3 = string.Format("select * from UserExpressXinXI where UserUid = '{0}' ORDER BY Odd desc", tex_uid.Text);
                SqlDataReader sdr = db.GetSet(sql3);
                sdr.Read();
                MessageBox.Show(sdr["Odd"].ToString(), "你的快递单号为", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                ChuangDi.DanHaoJiaGe = Convert.ToInt32(sdr["Odd"]);
                return false;
            }
            else
            {
                MessageBox.Show("快递单创建失败，请从新确认信息", "提示");
                return true;
            }
            return true;
        }
        public void QingKong()
        {
            tex_uid.Text = "";
            tex_kuaidiyuan.Text = "";
            texx_shouname.Text = "";
            tex_shouaddress.Text = "";
            tex_shouphone.Text = "";
            tex_youname.Text = "";
            tex_youaddress.Text = "";
            tex_youphone.Text = "";
            tex_liuyan.Text = "";
        }
        public void QingKong2()
        {
            this.num_zhongliang.Value = 1;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            QingKong();
            QingKong2();
        }
        //private void button9_Click_1(object sender, EventArgs e)
        //{
        //    string jietime = time_lantime.Text.ToString();
        //    MessageBox.Show(jietime, "提示");
        //}
        #endregion
        #region
        /// <summary>
        /// 查询快递
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!PanDuanChaXun())
            {
                ChaXun();
            }
        }
        public bool PanDuanChaXun()
        {
            string sql = string.Format("select count(*) from UserExpressXinXI where Odd = {0}",tex_shurudanhao.Text);
            if(tex_shurudanhao.Text == "")
            {
                MessageBox.Show("请输入单号", "提示");
                this.tex_shurudanhao.Focus();
            }
            else if(tex_shurudanhao.Text != "")
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
        public void ChaXun()
        {
            string sql = string.Format("select * from UserExpressXinXI where Odd = {0}", tex_shurudanhao.Text);
            SqlDataReader sdr = db.GetSet(sql);
            sdr.Read();
            lab_uid.Text = sdr["UserUid"].ToString();
            lab_add.Text = sdr["Odd"].ToString();
            lab_shouname.Text = sdr["ShouHuoRenName"].ToString();
            lab_shouaddres.Text = sdr["ShouHuoAddress"].ToString();
            lab_shouphone.Text = sdr["ShouHuoRenPhone"].ToString();
            lab_youname.Text = sdr["YouDiRenName"].ToString();
            lab_youaddress.Text = sdr["YouDiAddress"].ToString();
            lab_youphone.Text = sdr["YouDiRenPhone"].ToString();
            lab_nowaddress.Text = sdr["NowAddress"].ToString();
            lab_lanjiantime.Text = sdr["LanJianTime"].ToString();
            lab_liuyan.Text = sdr["LiuYan"].ToString();
            //用户签收按钮
            string sql_1 = string.Format("select * from UserExpressXinXI where Odd = {0}", tex_shurudanhao.Text);
            SqlDataReader sdr_1 = db.GetSet(sql_1);
            sdr_1.Read();

            if (Convert.ToInt32(sdr_1["qianshou"]) == 2)
            {
                this.but_yonghuqianshou.Visible = true;
                this.but_yonghuqianshou.Enabled = false;
                this.but_yonghuqianshou.Text = "用户已签收";
            }else if(Convert.ToInt32(sdr_1["qianshou"]) == 0 || Convert.ToInt32(sdr_1["qianshou"]) == 1)
            {
                this.but_yonghuqianshou.Visible = true;
                this.but_yonghuqianshou.Enabled = false;
                this.but_yonghuqianshou.Text = "用户未签收";
            }
            //单选
            string lingshistr = string.Format("select count(*) from UserExpressXinXI where QianShou = 0");
            int lingshi = Convert.ToInt32(db.GetOne(lingshistr));
            if (lingshi > 0)
            {
                this.radio_shi.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!PanDuanChaXun())
            {
                if (radio_shi.Checked == true)
                {
                    string sql = "select count(*) from UserExpressXinXI where QianShou = 2";
                    int lingshi_2 = Convert.ToInt32(db.GetOne(sql));
                    if (lingshi_2 > 0)
                    {
                        MessageBox.Show("用户已签收,不需要服务点签收", "提示");
                    }
                    else
                    {
                        string lingshistr = string.Format("update UserExpressXinXI set QianShou = 1 ,NowAddress = '{0}' where Odd = {1}", tex_fuwudianaddress.Text, lab_add.Text);
                        int lingshi = db.JiRu(lingshistr);
                        if (lingshi > 0)
                        {
                            QingKongChaXun();
                            MessageBox.Show("服务点已签收", "提示");
                        }
                        else
                        {
                            QingKongChaXun();
                        }
                    }
                }
            }    
        }  
        public void QingKongChaXun()
        {
            tex_shurudanhao.Text = "";
            lab_uid.Text = "";
            lab_add.Text = "";
            lab_shouname.Text = "";
            lab_shouaddres.Text = "";
            lab_shouphone.Text = "";
            lab_youname.Text = "";
            lab_youaddress.Text = "";
            lab_youphone.Text = "";
            lab_lanjiantime.Text = "";
            lab_liuyan.Text = "";
            lab_nowaddress.Text = "";
            this.radio_fou.Checked = true;
            this.but_yonghuqianshou.Visible = false;
        }   

        private void button5_Click(object sender, EventArgs e)
        {
            QingKongChaXun();
        }
        //判断是否签收
        public bool PanDuanQianShou()
        {
            string sql_1 = string.Format("select * from UserExpressXinXI where Odd = {0}", tex_shurudanhao.Text);
            SqlDataReader sdr_1 = db.GetSet(sql_1);
            sdr_1.Read();
            if (Convert.ToInt32(sdr_1["qianshou"]) == 0)
            {
                return false;
            }
            else if (Convert.ToInt32(sdr_1["qianshou"]) == 1 || Convert.ToInt32(sdr_1["qianshou"]) == 2)
            {
                //MessageBox.Show("用户或代理点已签收，不能更改", "提示");
                return true;
            }
            return true;
        }
        //修改地址
        private void button3_Click(object sender, EventArgs e)
        {
            if (!PanDuanChaXun())
            {
                if (!PanDuanQianShou())
                {
                    XiuGaiDiZhi();
                }
                else
                {
                    MessageBox.Show("用户或代理点已签收，不能更改", "提示");
                }
            }
            //if (PanDuanXiu())
            //{
            //    XiuGaiDiZhi();
            //}
        }
        //public bool PanDuanXiu()
        //{
        //    if (tex_shurudanhao.Text == "")
        //    {
        //        MessageBox.Show("请输入单号", "提示");
        //        this.tex_shurudanhao.Focus();
        //        return false;
        //    }
        //    return true;
        //}
        public void XiuGaiDiZhi()
        {
            XiuGaiDiZhi_Frm xg = new XiuGaiDiZhi_Frm();
            ChuangDi.DanHao = int.Parse(tex_shurudanhao.Text);
            xg.Show();

        }
        //快递报失
        private void button6_Click(object sender, EventArgs e)
        {
            if (!PanDuanChaXun())
            {
                if (!PanDuanQianShou())
                {
                    string sql = string.Format("insert KuaiDiBaoShi values({0},{1})", lab_uid.Text, lab_add.Text);
                    int lingshi = db.JiRu(sql);
                    if (lingshi > 0)
                    {
                        MessageBox.Show("已报失！", "提示");
                    }
                }
                else
                {
                    MessageBox.Show("已签收，不能报失", "提示");
                }
            }
        }
        //判断是否为未处理问题件
        public bool WenTiJian()
        {
            string sql = string.Format("select COUNT(*) from KuaiDiBaoShi where Odd = {0}", int.Parse(tex_shurudanhao.Text));
            int lingShi = Convert.ToInt32(db.GetOne(sql));
            string sql2 = string.Format("select COUNT(*) from TouSuKaiDi where Odd = {0}", int.Parse(tex_shurudanhao.Text));
            int lingShi2 = Convert.ToInt32(db.GetOne(sql2));
            if (lingShi > 0 || lingShi2 > 0)
            {
                MessageBox.Show("投诉快递件或报失快递件未处理", "提示");
                return false;
            }
            else
            {
                
                return true;
            }
            return true;
        }
        //删除快递单
        private void button4_Click(object sender, EventArgs e)
        {
            if (!PanDuanChaXun())
            {
                if (PanDuanQianShou())
                {
                    if (WenTiJian())
                    {
                        DialogResult dr = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        if (dr == DialogResult.OK)
                        {
                            string mess = tex_shurudanhao.Text;
                            string lingshistr1 = string.Format("delete from UserExpressXinXI where odd = {0}", int.Parse(tex_shurudanhao.Text));
                            int lingshi1 = db.JiRu(lingshistr1);
                            if (lingshi1 > 0)
                            {
                                QingKongChaXun();
                                MessageBox.Show("已删除快递单：" + mess, "提示");
                            }
                        }
                    }
                    //else
                    //{
                    //    MessageBox.Show("快递未签收，不能删除", "提示");
                    //}
                }
                else
                {
                    MessageBox.Show("用户未签收不能删除", "提示");
                }    
            }
            //if (PanDuanXiu())
            //{
            //string lingshistr = string.Format("delete from UserExpressXinXI where odd = {0}", tex_shurudanhao);
            //int lingshi = db.JiRu(lingshistr);
            //if (lingshi > 0)
            //{
            //    QingKongChaXun();
            //    MessageBox.Show("已删除快递单："+ tex_shurudanhao, "提示");
            //}
            //}
        }
        #endregion
        #region
        //微商通道
        double zhong = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            if (!PanDuan_weishang())
            {
                if (PanDuan2_weishang())
                {
                    //MessageBox.Show("chenggong", "tishi");
                    if (!QianJia_weishang())
                    {
                        double zhongliang = double.Parse(num_weishang.Value.ToString());
                        //jt.ZhongLiang = zhongliang;
                        zhong = zhongliang + zhong;
                        DialogResult dr = MessageBox.Show("是否继续添加","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
                        if(dr == DialogResult.OK)
                        {
                            QingKongBuFen();
                        }
                        else
                        {
                            QingKong_weishang();
                            QingKong2_weishang();
                            ChuangDi.ZhongLiang = zhong;
                            FrmKuaiDiJieSuan js = new FrmKuaiDiJieSuan();
                            js.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("邮递人UID，收货人UID或者快递员编号输入错误");
            }
        }
        public bool PanDuan2_weishang()
        {
            //if(tex_uid.Text == "")
            //{
            //    MessageBox.Show("请输入uid","提示");
            //    return false;
            //}
            if (tex_sname.Text == "")
            {
                MessageBox.Show("请输入收货人的名字", "提示");
                this.texx_shouname.Focus();
                return false;
            }
            if (tex_sadrress.Text == "")
            {
                MessageBox.Show("请输入收货地址", "提示");
                this.tex_shouaddress.Focus();
                return false;
            }
            if (tex_sphone2.Text == "")
            {
                MessageBox.Show("请输入收货人电话", "提示");
                this.tex_shouphone.Focus();
                return false;
            }
            if (tex_yname.Text == "")
            {
                MessageBox.Show("请输入邮递人姓名", "提示");
                this.tex_youname.Focus();
                return false;
            }
            if (tex_ysardss.Text == "")
            {
                MessageBox.Show("请输入邮递人地址", "提示");
                this.tex_youaddress.Focus();
                return false;
            }
            if (tex_yphone.Text == "")
            {
                MessageBox.Show("请输入邮递人电话", "提示");
                this.tex_youphone.Focus();
                return false;
            }
            if (tex_liu.Text == "")
            {
                MessageBox.Show("请留言", "提示");
                this.tex_liuyan.Focus();
                return false;
            }
            return true;
        }
        public bool PanDuan_weishang()
        {
            if(text_weishouuid.Text != "")
            {
                string sql6 = string.Format("select count(*) from [User] where UserUid = '{0}'", text_weishouuid.Text);
                string sql = string.Format("select count(*) from [user] where useruid = '{0}'", tex_uid2.Text);
                string sql2 = string.Format("select count(*) from staff where staffno = '{0}'", tex_kuaidiyuan2.Text);
                string sql3 = string.Format("select * from staff where staffno = '{0}'", tex_kuaidiyuan2.Text);
                int obj = Convert.ToInt32(db.GetOne(sql));
                int obj3 = Convert.ToInt32(db.GetOne(sql6));
                int obj2 = Convert.ToInt32(db.GetOne(sql2));
                if (obj > 0 && obj2 > 0 && obj3 >0)
                {
                    SqlDataReader sdr = db.GetSet(sql3);
                    sdr.Read();
                    int lingshi = Convert.ToInt32(sdr["kuaidijian"]) + 1;
                    int lingshi2 = Convert.ToInt32(sdr["Wages"]) + 1;
                    string sql4 = string.Format("update staff set kuaidijian = {0}  where staffno = '{1}'", lingshi, tex_kuaidiyuan2.Text);
                    int enq = db.JiRu(sql4);
                    string sql5 = string.Format("update staff set Wages = {0}  where staffno = '{1}'", lingshi2, tex_kuaidiyuan2.Text);
                    int enq1 = db.JiRu(sql4);
                    if (enq == 1)
                    {
                        if (enq1 == 1)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                string sql = string.Format("select count(*) from [user] where useruid = '{0}'", tex_uid2.Text);
                string sql2 = string.Format("select count(*) from staff where staffno = '{0}'", tex_kuaidiyuan2.Text);
                string sql3 = string.Format("select * from staff where staffno = '{0}'", tex_kuaidiyuan2.Text);
                int obj = Convert.ToInt32(db.GetOne(sql));
                int obj2 = Convert.ToInt32(db.GetOne(sql2));
                if (obj > 0 && obj2 > 0)
                {
                    SqlDataReader sdr = db.GetSet(sql3);
                    sdr.Read();
                    int lingshi = Convert.ToInt32(sdr["kuaidijian"]) + 1;
                    int lingshi2 = Convert.ToInt32(sdr["Wages"]) + 1;
                    string sql4 = string.Format("update staff set kuaidijian = {0}  where staffno = '{1}'", lingshi, tex_kuaidiyuan2.Text);
                    int enq = db.JiRu(sql4);
                    string sql5 = string.Format("update staff set Wages = {0}  where staffno = '{1}'", lingshi2, tex_kuaidiyuan2.Text);
                    int enq1 = db.JiRu(sql4);
                    if (enq == 1)
                    {
                        if (enq1 == 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public bool QianJia_weishang()
        {
            DateTime time = time_2.Value;
            string sql = string.Format("insert UserExpressXinXI values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}' , 0 ,{9},0,'{10}')", int.Parse(tex_uid2.Text), tex_sname.Text, tex_sadrress.Text, tex_sphone2.Text, tex_yname.Text, tex_youaddress.Text, tex_yphone.Text, time, tex_liu.Text, int.Parse(tex_kuaidiyuan2.Text),tex_weinowaddress.Text);
            int lingshi = db.JiRu(sql);
            if (lingshi > 0)
            {
                
                MessageBox.Show("快递单创建成功", "提示");
                string sql3 = string.Format("select * from UserExpressXinXI where UserUid = '{0}' ORDER BY Odd desc", tex_uid2.Text);
                SqlDataReader sdr = db.GetSet(sql3);
                sdr.Read();
                MessageBox.Show(sdr["Odd"].ToString(), "你的快递单号为", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                ChuangDi.DanHaoJiaGe = Convert.ToInt32(sdr["Odd"]);
                if(text_weishouuid.Text != "")
                {
                    string sql_1 = string.Format("insert TiaoZaoWoDeKuaiDi values({0},{1})", int.Parse(text_weishouuid.Text), Convert.ToInt32(sdr["Odd"]));
                    int lingshi_1 = db.JiRu(sql_1);
                    if (lingshi_1 > 0)
                    {
                        MessageBox.Show("已添加收货人UID", "提示");
                    }
                }
                sdr.Close();
                return false;
            }
            else
            {
                MessageBox.Show("快递单创建失败，请从新确认信息", "提示");
                return true;
            }
            return true;
        }
         public void QingKongBuFen()
        {
            tex_sname.Text = "";
            tex_sadrress.Text = "";
            tex_sphone2.Text = "";
            text_weishouuid.Text = "";
            this.text_weishouuid.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            QingKong_weishang();
            QingKong2_weishang();
        }
        public void QingKong_weishang()
        {
            tex_uid2.Text = "";
            this.tex_uid2.Focus();
            tex_kuaidiyuan2.Text = "";
            this.tex_kuaidiyuan2.Focus();
            tex_sname.Text = "";
            this.tex_sname.Focus();
            tex_sadrress.Text = "";
            this.tex_sadrress.Focus();
            tex_sphone2.Text = "";
            this.tex_sphone2.Focus();
            tex_yname.Text = "";
            this.tex_yname.Focus();
            tex_ysardss.Text = "";
            this.tex_ysardss.Focus();
            tex_yphone.Text = "";
            this.tex_yphone.Focus();
            tex_liu.Text = "";
            this.tex_liu.Focus();
            text_weishouuid.Text = "";
            this.text_weishouuid.Focus();
        }
        public void QingKong2_weishang()
        {
            this.num_weishang.Value = 1;
        }
        #endregion
    }
    }
   

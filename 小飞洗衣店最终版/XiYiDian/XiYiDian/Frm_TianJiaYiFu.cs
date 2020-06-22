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
    public partial class Frm_TianJiaYiFu : Form
    {
        public Frm_TianJiaYiFu()
        {
            InitializeComponent();
        }
        public string kaHao;
        public string Time;
        string danHao;
        Frm_TianJiaYiFu frm;
        DBHelper db = new DBHelper();
        //刷新
        private void Frm_TianJiaYiFu_Load(object sender, EventArgs e)
        {
            CobTian();
            XuanYeWu();
            lab_zhekou.Text = ZheKou().ToString();
            JiaGe();

            string sql = $"select * from HuiYuan as hy inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = hy.ZhongLei inner join HuiYuanZhuangTai as hyzt on hyzt.HuiYuanZhuanTaiID = hy.ZhuangTai inner join HuiYuanTime as hytime on hytime.ShiJianID = hy.ShiJian where hy.HuiYuanID = {kaHao}";
            DataTable dt = db.GetData(sql);
            string sql1 = $"insert into ShouQuYiFu values('{dt.Rows[0]["HuiYuanRenName"].ToString()}','{dt.Rows[0]["HuiYuanPhone"].ToString()}','{kaHao}','否','{Time}','1','0','0','无','1')";
            db.Update(sql1);
            string sql2 = "select * from ShouQuYiFu  order by ShouQuYiFuID desc";
            DataTable dt1 = db.GetData(sql2);
            danHao = dt1.Rows[0]["ShouQuYiFuID"].ToString();

        }
        //价格刷新
        public void JiaGe()
        {
            string sql = $"select * from XiYiFangShi where LeiXingID = {com_xiyifangshi.SelectedValue}";
            DataTable dt = db.GetData(sql);
            int xiFang = Convert.ToInt32(dt.Rows[0]["LeiXingId"]);

            string sql2 = $"select * from YiFuZhongLei where XiYiFangShi = {xiFang}";
            DataTable dt2 = db.GetData(sql2);
            int jiaGe = Convert.ToInt32(dt2.Rows[0]["JiaGe"]);

            string jiage = (jiaGe * num_shuliang.Value).ToString();
            lab_jiage.Text = jiage + "元";
        }

        //绑定cob数据
        public void CobTian()
        {
            DataTable dt = db.GetData("select * from XiYiFangShi");
            com_xiyifangshi.DataSource = dt;
            com_xiyifangshi.DisplayMember = "LeiXing";
            com_xiyifangshi.ValueMember = "LeiXingID";

            DataTable dt3 = db.GetData("select * from YiFuYanSe");
            com_yanse.DataSource = dt3;
            com_yanse.DisplayMember = "YanSeName";
            com_yanse.ValueMember = "YanSeID";
        }
        public void XuanYeWu()
        {
            string sql = $"select * from YiFuZhongLei where XiYiFangShi = {com_xiyifangshi.SelectedValue}";
            DataTable dt2 = db.GetData(sql);
            com_yifuzhonglei.DataSource = dt2;
            com_yifuzhonglei.DisplayMember = "YiFuName";
            com_yifuzhonglei.ValueMember = "YiFuZhongLeiID";
        }


        private void button1_Click(object sender, EventArgs e)
        {
                TianJia();
        }
        double yingShou;
        double shiShou1;
        int shuLiang;
        public void TianJia()
        {
            string sql2 = $"select * from YiFuZhongLei where XiYiFangShi = {com_xiyifangshi.SelectedValue} and YiFuZhongLeiID = {com_yifuzhonglei.SelectedValue}";
            DataTable dt2 = db.GetData(sql2);
            double zheKou = ZheKou();
            double jiaGe = Convert.ToDouble(dt2.Rows[0]["JiaGe"]);
            double shiShou = Convert.ToDouble(jiaGe * Convert.ToDouble(num_shuliang.Value)) * zheKou * 1 ;
            yingShou += jiaGe;
            shiShou1 += shiShou;
            shuLiang += (int)num_shuliang.Value;

            string sql = $"insert DingDanXiangXi values({danHao},'{jiaGe}',{com_xiyifangshi.SelectedValue},{com_yifuzhonglei.SelectedValue},1,{com_yanse.SelectedValue},'{dateTi_shou.Value}','{tex_benque.Text}','无','0','')";
            int enq = db.Update(sql);
            if (enq > 0)
            {
                MessageBox.Show("添加成功！");
            }
        }
        //折扣方法
        public double ZheKou()
        {
            string sql3 = $"select * from HuiYuan inner join HuiYuanZhongLei as hyzl on hyzl.HuiYuanZhongLeiID = HuiYuan.ZhongLei where HuiYuanID = {kaHao}";
            DataTable dt3 = db.GetData(sql3);
            double zheKou = Convert.ToDouble(dt3.Rows[0]["SheKou"]);
            return zheKou;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = $"update ShouQuYiFu set YingShouJinE = {yingShou} ,ShiShouJinE = {shiShou1} , ShuLiang = {shuLiang} where ShouQuYiFuID = {danHao}";
            if (db.Update(sql) > 0)
            {
               // MessageBox.Show("修改成功", yingShou.ToString());
            }
            this.Close();
        }

        private void com_xiyifangshi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                XuanYeWu();
                JiaGe();
            }
            catch (Exception ex)
            {

            }
        }
    }
}

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
    public partial class Frm_yuangongguanli : Form
    {
        public Frm_yuangongguanli()
        {
            InitializeComponent();
        }
        DBHelper db = new DBHelper();

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_tianjiayuangong f1 = new Frm_tianjiayuangong();
            f1.Show();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from YuanGong where YuanGongID = '" + txtxianshibianhao.Text + "' ";
            DataTable dt = db.GetData(sql);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = dr["YanGongID"].ToString();
                lvi.Text = dr["Name"].ToString();
                lvi.SubItems.Add(dr["Sex"].ToString());
                lvi.SubItems.Add(dr["Phone"].ToString());
                lvi.SubItems.Add(dr["ID"].ToString());
                lvi.SubItems.Add(dr["RuZhiShiJian"].ToString());
                lvi.SubItems.Add(dr["DiZhi"].ToString());
                lvi.SubItems.Add(dr["ChengJiuZhiDanWei"].ToString());
                lvi.SubItems.Add(dr["DangWei"].ToString());
                lvi.SubItems.Add(dr["XiYiJianShu"].ToString());
                lvi.SubItems.Add(dr["XiHuaiJian"].ToString());
                lvi.SubItems.Add(dr["GongZi"].ToString());
                lvi.SubItems.Add(dr["ShiJiGongZi"].ToString());
                lvixianshi.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvixianshi.Items.Clear();
            string sql = "select * from YuanGong where YuanGongID = '"+txtxianshibianhao.Text+"' ";
            DataTable dt = db.GetData(sql);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["Name"].ToString();
                lvi.SubItems.Add(dr["Sex"].ToString());
                lvi.SubItems.Add(dr["Phone"].ToString());
                lvi.SubItems.Add(dr["ID"].ToString());
                lvi.SubItems.Add(dr["RuZhiShiJian"].ToString());
                lvi.SubItems.Add(dr["DiZhi"].ToString());
                lvi.SubItems.Add(dr["ChengJiuZhiDanWei"].ToString());
                lvi.SubItems.Add(dr["DangWei"].ToString());
                lvi.SubItems.Add(dr["XiYiJianShu"].ToString());
                lvi.SubItems.Add(dr["XiHuaiJian"].ToString());
                lvi.SubItems.Add(dr["GongZi"].ToString());
                lvi.SubItems.Add(dr["ShiJiGongZi"].ToString());
                lvixianshi.Items.Add(lvi);
            }
        }

        private void lvixianshi_Click(object sender, EventArgs e)
        {

        }

        private void btnchaxunquanbu_Click(object sender, EventArgs e)
        {
            lvixianshi.Items.Clear();
            string sql = "select * from YuanGong ";
            DataTable dt = db.GetData(sql);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["Name"].ToString();
                lvi.SubItems.Add(dr["Sex"].ToString());
                lvi.SubItems.Add(dr["Phone"].ToString());
                lvi.SubItems.Add(dr["ID"].ToString());
                lvi.SubItems.Add(dr["RuZhiShiJian"].ToString());
                lvi.SubItems.Add(dr["DiZhi"].ToString());
                lvi.SubItems.Add(dr["ChengJiuZhiDanWei"].ToString());
                lvi.SubItems.Add(dr["DangWei"].ToString());
                lvi.SubItems.Add(dr["XiYiJianShu"].ToString());
                lvi.SubItems.Add(dr["XiHuaiJian"].ToString());
                lvi.SubItems.Add(dr["GongZi"].ToString());
                lvi.SubItems.Add(dr["ShiJiGongZi"].ToString());
                lvixianshi.Items.Add(lvi);
            }
        }

        public void load()
        {
            lvixianshi.Items.Clear();
            string sql = "select * from YuanGong ";
            DataTable dt = db.GetData(sql);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = dr["YuanGongID"].ToString();
                lvi.Text = dr["Name"].ToString();
                lvi.SubItems.Add(dr["Sex"].ToString());
                lvi.SubItems.Add(dr["Phone"].ToString());
                lvi.SubItems.Add(dr["ID"].ToString());
                lvi.SubItems.Add(dr["RuZhiShiJian"].ToString());
                lvi.SubItems.Add(dr["DiZhi"].ToString());
                lvi.SubItems.Add(dr["ChengJiuZhiDanWei"].ToString());
                lvi.SubItems.Add(dr["DangWei"].ToString());
                lvi.SubItems.Add(dr["XiYiJianShu"].ToString());
                lvi.SubItems.Add(dr["XiHuaiJian"].ToString());
                lvi.SubItems.Add(dr["GongZi"].ToString());
                lvi.SubItems.Add(dr["ShiJiGongZi"].ToString());
                lvixianshi.Items.Add(lvi);
            }
        }

        private void Frm_yuangongguanli_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(lvixianshi.SelectedItems.Count == 1)
            {
                DialogResult result = MessageBox.Show("确认要删除此员工？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (lvixianshi.SelectedItems.Count == 1)
                    {
                        string statues = lvixianshi.SelectedItems[0].Tag.ToString();
                        string sql = "delete from YuanGong where YuanGongID =" + statues;
                        int row = db.Update(sql);
                        if (row > 0)
                        {
                            MessageBox.Show("删除成功");
                            load();
                        }
                        else
                        {
                            MessageBox.Show("请选中员工");
                        }
                        //string sql1 = "select * from YuanGong where YuanGongID =" + txtxianshibianhao;
                        //DataTable dt = new DataTable(sql1);
                        //foreach (DataRow dr in dt.Rows)
                        //{
                        //    ListViewItem lvi = new ListViewItem();
                        //    lvi.Text = dr["Name"].ToString();
                        //    lvi.SubItems.Add(dr["Sex"].ToString());
                        //    lvi.SubItems.Add(dr["Phone"].ToString());
                        //    lvi.SubItems.Add(dr["ID"].ToString());
                        //    lvi.SubItems.Add(dr["RuZhiShiJian"].ToString());
                        //    lvi.SubItems.Add(dr["DiZhi"].ToString());
                        //    lvi.SubItems.Add(dr["ChengJiuZhiDanWei"].ToString());
                        //    lvi.SubItems.Add(dr["DangWei"].ToString());
                        //    lvi.SubItems.Add(dr["XiYiJianShu"].ToString());
                        //    lvi.SubItems.Add(dr["XiHuaiJian"].ToString());
                        //    lvi.SubItems.Add(dr["GongZi"].ToString());
                        //    lvi.SubItems.Add(dr["ShiJiGongZi"].ToString());
                        //    lvixianshi.Items.Add(lvi);
                        //}
                    }
                }
            }
            else
            {
                MessageBox.Show("请选中");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_gongziguanli frm = new Frm_gongziguanli();
            frm.Show();
        }
    }
}

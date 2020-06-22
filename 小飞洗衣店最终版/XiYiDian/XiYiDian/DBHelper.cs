using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace XiYiDian
{
    public class DBHelper
    {
        string conStr = "server=.;database=XiYiDian;uid=sa;pwd=sa";
        
        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, conStr);
            try
            {
                sda.Fill(dt);
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //添加衣服弹出两个错误窗口
            }
            return dt;
        }
        public int Update(string sql)
        {
            SqlConnection con = new SqlConnection(conStr);
            int enq = 0;
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                enq = com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            return enq;
        }
        public object GetOne(string sql)
        {
            SqlConnection con = new SqlConnection(conStr);
            object es = null;
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                es = com.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return es;
        }
    }
}

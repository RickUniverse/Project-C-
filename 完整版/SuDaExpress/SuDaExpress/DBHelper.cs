using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuDaExpress
{
    public class DBHelper
    {
        string conStr = "server=.;database=SuDaExpress;uid=sa;pwd=sa;";
        private SqlConnection _conn;

        public SqlConnection Conn
        {
            get
            {
                if (_conn == null)
                {
                    _conn = new SqlConnection(conStr);
                    _conn.Open();
                }
                else if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                else if (_conn.State == ConnectionState.Broken)
                {
                    _conn.Close();
                    _conn.Open();
                }
                return _conn;
            }
        }
        //读取数据
        public SqlDataReader GetSet(string sql)
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlDataReader sdr = null;
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql,con);
                sdr = com.ExecuteReader(CommandBehavior.CloseConnection);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            finally
            {
                //con.Close();
            }
            return sdr;
        }
        public int JiRu(string sql)
        {
            SqlConnection con = new SqlConnection(conStr);
            int enq = 0;
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                enq = com.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            finally
            {
                con.Close();
            }
            return enq;
        }
        public object GetOne(string sql)
        {
            SqlConnection con = new SqlConnection(conStr);
            //object obj = null;
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                //obj = com.ExecuteScalar();
                return com.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return null;
            }
            finally
            {
                con.Close();
            }
            //return obj;
        }
        public DataTable GetTable(string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(sql, new SqlConnection(conStr));
            sda.Fill(ds);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //sda.Update(ds,ds.Tables[sda]);
            return ds.Tables[0];
        }
    }
}

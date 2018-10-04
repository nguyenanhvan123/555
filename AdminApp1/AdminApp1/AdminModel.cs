using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdminApp1
{
    public class AdminModel
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-PNT1KBR\\SQLEXPRESS;database=TestOnlineDemo;uid=sa;pwd=123456");
            return conn;
        }
        public Staff CheckLogin(string u, string p)
        {
            Staff staff = null;
            string sql = "SELECT *FROM Staff WHERE _username=@u and _pass=@p";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@u", u);
            cmd.Parameters.AddWithValue("@p", p);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                staff = new Staff();
                staff.UserName = rd.GetString(0);
                staff.Roles = rd.GetInt32(2);

            }
            cmd.Connection.Close();
            return staff;
        }
        public bool CheckExist(string id)
        {
            bool result = true;
            string sql="SELECT * FROM QUESTION WHERE _id=@id";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader rd = cmd.ExecuteReader();
            result = rd.HasRows;
            cmd.Connection.Close();
            return !result;
        }
        public bool AddQuestion(string id,string content,string a,string b,string c,string d,string subject,string correct)
        {
            string sql = "INSERT INTO QUESTION (_id,_content,_a,_b,_c,_d,_sid,_correct) VALUES(@i,@cont,@a,@b,@c,@d,@s,@crr)";
            SqlCommand cmd = new SqlCommand(sql,GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@i", id);
            cmd.Parameters.AddWithValue("@cont", content);
            cmd.Parameters.AddWithValue("@a", a);
            cmd.Parameters.AddWithValue("@b", b);
            cmd.Parameters.AddWithValue("@c", c);
            cmd.Parameters.AddWithValue("@d", d);
            cmd.Parameters.AddWithValue("@s", subject);
            cmd.Parameters.AddWithValue("@crr", correct);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        public DataTable GetQuestion()
        {
            string sql = "SELECT * FROM QUESTION";
        DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            da.Fill(dt);
            return dt;
        }
        public bool Delete(string id)
        {
            string sql = "DELETE FROM QUESTION WHERE _id=@i";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@i", id);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        public bool Update(string id, string content, string a, string b, string c, string d, string subject,string correct)
        {
            string sql = "UPDATE QUESTION SET _content=@cont,_a=@a,_b=@b,_c=@c,_d=@d,_sid=@s,_correct=@crr WHERE _id=@i";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@i", id);
            cmd.Parameters.AddWithValue("@cont", content);
            cmd.Parameters.AddWithValue("@a", a);
            cmd.Parameters.AddWithValue("@b", b);
            cmd.Parameters.AddWithValue("@c", c);
            cmd.Parameters.AddWithValue("@d", d);
            cmd.Parameters.AddWithValue("@s", subject);
            cmd.Parameters.AddWithValue("@crr", correct);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        public DataTable SearchByID(string id)

        {
            string sql = "select * from Question where _id = '" + id + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            da.Fill(dt);
            return dt;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADOPROJECT
{
    class DBCON
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-T2S9EFG;Initial catalog=project1;integrated security=true;");

        public int insertproduct(int @pid, string @pname, string @pdesc)
        {
            SqlCommand cmd = new SqlCommand("insprod", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@pdesc", pdesc);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public DataTable displayproduct()
        {
            SqlCommand cmd = new SqlCommand("disprod", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable displayproductid(int @pid)
        {
            SqlCommand cmd = new SqlCommand("disprod1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public int updateproduct(int @pid, string @pname, string @pdesc)
        {
            SqlCommand cmd = new SqlCommand("updprod", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@pdesc", pdesc);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public int deleteproduct(int @pid)
        {
            SqlCommand cmd = new SqlCommand("delprod", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }

        public int insertuser(string @uid, string @pwd, string @usrtype)
        {
            SqlCommand cmd = new SqlCommand("insuser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@usrtype", usrtype);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }

        public DataTable displayuser()
        {
            SqlCommand cmd = new SqlCommand("viewuser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable displayuserid(string @uid)
        {
            SqlCommand cmd = new SqlCommand("viewuserid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@uid", uid);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public int updateuser(string @uid, string @pwd, string @usrtype)
        {
            SqlCommand cmd = new SqlCommand("upduser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@usrtype", usrtype);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public int deleteuser(string @uid)
        {
            SqlCommand cmd = new SqlCommand("deluser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@uid", uid);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }

        public int insertmodel(int @pid, string @pname, int @mid, string @mname, string @spec, int @uprice, int @soh)
        {
            SqlCommand cmd = new SqlCommand("insmodel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@mname", mname);
            cmd.Parameters.AddWithValue("@spec", spec);
            cmd.Parameters.AddWithValue("@uprice", uprice);
            cmd.Parameters.AddWithValue("@soh", soh);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }

        public int updatemodel(int @pid, string @pname, int @mid, string @mname, string @spec, int @uprice, int @soh)
        {
            SqlCommand cmd = new SqlCommand("updmodel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@mname", mname);
            cmd.Parameters.AddWithValue("@spec", spec);
            cmd.Parameters.AddWithValue("@uprice", uprice);
            cmd.Parameters.AddWithValue("@soh", soh);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public DataTable displaymodel()
        {
            SqlCommand cmd = new SqlCommand("viewmodel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable displaymodelid(int @mid)
        {
            SqlCommand cmd = new SqlCommand("viewmodelbyid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid", mid);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public int deletemodel(int @mid)
        {
            SqlCommand cmd = new SqlCommand("delmodel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid", mid);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public int CHKLogin(string uid, string pwd, string usrtype)
        {
            SqlCommand cmd = new SqlCommand("chklog", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@usrtype", usrtype);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int x = int.Parse(dr[0].ToString());
            con.Close();
            return x;
        }
      
        public int insertsales(int @pid, string @pname, int @mid, string @mname, string @spec, int @uprice, int @qty, int @totamt)
        {
            SqlCommand cmd = new SqlCommand("InsSales", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@mname", mname);
            cmd.Parameters.AddWithValue("@spec", spec);
            cmd.Parameters.AddWithValue("@uprice", uprice);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@totamt", totamt);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }

        public DataTable displadailyreport()
        {
            SqlCommand cmd = new SqlCommand("DailyRpt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable displayproductwisereport(int @pid)
        {
            SqlCommand cmd = new SqlCommand("ProductRpt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable displaymodelwisereport(int @mid)
        {
            SqlCommand cmd = new SqlCommand("ModelRpt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid", mid);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable disdatebetreport(DateTime @fdate,DateTime @tdate)
        {
            SqlCommand cmd = new SqlCommand("SalesRpt",con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@fdate",fdate);
            cmd.Parameters.AddWithValue("@tdate",tdate);
            DataTable dt = new DataTable();
             dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        //public void print()
        //{

        //}

    }
}

using EMS201724112133.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112133
{
    public partial class _21 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EMSdb1Entities db = new EMSdb1Entities();
            if (Session["CurrentId"] != null)
            {
                string uid = Session["CurrentId"].ToString();
                var result = from m in db.Emp
                             where m.Emp_id == uid
                             select m;
                StringBuilder sb = new StringBuilder();
                foreach (var s in result)
                {
                    sb.Append(string.Format(s.Emp_name));
                }
                Label1.Text = sb.ToString();
            }
            if (!Page.IsPostBack)
            {
                ShowData();
            }
        }

        protected void btnToLog_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        string sqlconn = "Data Source=(LocalDB)\\MSSQLLocalDB;" + "AttachDbFilename='|DataDirectory|\\EMSdb1.mdf';";
        void ShowData()
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = sqlconn;
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Emp", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string keyword = TextBox1.Text;
            StringBuilder sb = new StringBuilder();
            if (TextBox1.Text == "")
            {
                sb.Append("请输入部门信息");
                Label2.Text = sb.ToString();
                return;
            }
            else
            {
                Label2.Text = "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = sqlconn;
                    cn.Open();
                    string sqlstr = string.Format("INSERT INTO dept(dept_id,dept_name,dept_manager)" +
                    "VALUES(N'{0}',N'{1}',N'{2}')", TextBox2.Text, TextBox3.Text, TextBox4.Text);
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.ExecuteNonQuery();
                    ShowData();
                    cn.Close();
                }
            }
            catch
            {
                Response.Write("<script>alert('插入异常')</script>");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = sqlconn;
                    cn.Open();
                    string sqlstr = "UPDATE dept SET dept_name=@name,dept_manager=@manager WHERE dept_id=@id";

                    // 建立SqlCommand对象cmd
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@manager", SqlDbType.NChar));
                    cmd.Parameters["@id"].Value = TextBox2.Text;
                    cmd.Parameters["@name"].Value = TextBox3.Text;
                    cmd.Parameters["@manager"].Value = TextBox4.Text;
                    cmd.ExecuteNonQuery();
                    ShowData();
                    cn.Close();
                }
            }
            catch
            {
                Response.Write("<script>alert('修改异常')</script>");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = sqlconn;
                cn.Open();
                string sqlstr = "DELETE FROM dept WHERE dept_id=@id";
                // 建立SqlCommand对象cmd
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Char));
                cmd.Parameters["@id"].Value = TextBox2.Text;
                cmd.ExecuteNonQuery();
                ShowData();
                cn.Close();
            }
        }
    }
}
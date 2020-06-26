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
    public partial class _22 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EMSdb1Entities db = new EMSdb1Entities();
            //返回session中的用户id对应的名字
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string keyword = TextBox1.Text;
            StringBuilder sb = new StringBuilder();
            if (TextBox1.Text == "")
            {
                sb.Append("请输入设备信息");
                Label2.Text = sb.ToString();
                return;
            }
            else
            {
                EMSdb1Entities db = new EMSdb1Entities();
                //使用LINQ方法
                var result1 = db.Equ.Where(m => m.Equ_Id.Contains(keyword));
                var result2 = db.Equ.Where(m => m.Equ_name.Contains(keyword));
                var result3 = db.Equ.Where(m => m.Equ_date.ToString().Contains(keyword));
                var result4 = db.Equ.Where(m => m.Equ_location.Contains(keyword));
                var result5 = db.Equ.Where(m => m.Equ_resp.Contains(keyword));
                if (result1.Count() != 0)    //设备编号查询
                {
                    foreach (var m in result1)
                    {
                        sb.Append(m.Equ_Id + " ");
                        sb.Append(m.Equ_name + " ");
                        sb.Append(m.Equ_standards + " ");
                        sb.Append(m.Equ_price + " ");
                        sb.Append(m.Equ_date + " ");
                        sb.Append(m.Equ_location + " ");
                        sb.Append(m.Equ_resp + " ");
                        sb.Append("<img src=\"" + m.Equ_img + "\">");
                        sb.Append("<hr/>");
                    }
                    Label2.Text = sb.ToString();
                }
                else if (result2.Count() != 0)   //设备名称查询
                {
                    foreach (var m in result2)
                    {
                        sb.Append(m.Equ_Id + " ");
                        sb.Append(m.Equ_name + " ");
                        sb.Append(m.Equ_standards + " ");
                        sb.Append(m.Equ_price + " ");
                        sb.Append(m.Equ_date + " ");
                        sb.Append(m.Equ_location + " ");
                        sb.Append(m.Equ_resp + " ");
                        sb.Append("<img src=\"" + m.Equ_img + "\">");
                        sb.Append("<hr/>");
                    }
                    Label2.Text = sb.ToString();
                }
                else if (result3.Count() != 0)   //按照设备购入日期查询
                {
                    foreach (var m in result3)
                    {
                        sb.Append(m.Equ_Id + " ");
                        sb.Append(m.Equ_name + " ");
                        sb.Append(m.Equ_standards + " ");
                        sb.Append(m.Equ_price + " ");
                        sb.Append(m.Equ_date + " ");
                        sb.Append(m.Equ_location + " ");
                        sb.Append(m.Equ_resp + " ");
                        sb.Append("<img src=\"" + m.Equ_img + "\">");
                        sb.Append("<hr/>");
                    }
                    Label2.Text = sb.ToString();
                }
                else if (result4.Count() != 0)       //按照存放位置查询
                {
                    foreach (var m in result4)
                    {
                        sb.Append(m.Equ_Id + " ");
                        sb.Append(m.Equ_name + " ");
                        sb.Append(m.Equ_standards + " ");
                        sb.Append(m.Equ_price + " ");
                        sb.Append(m.Equ_date + " ");
                        sb.Append(m.Equ_location + " ");
                        sb.Append(m.Equ_resp + " ");
                        sb.Append("<img src=\"" + m.Equ_img + "\">");
                        sb.Append("<hr/>");
                    }
                    Label2.Text = sb.ToString();
                }
                else if (result5.Count() != 0)          //按照负责人编号查询
                {
                    foreach (var m in result5)
                    {
                        sb.Append(m.Equ_Id + " ");
                        sb.Append(m.Equ_name + " ");
                        sb.Append(m.Equ_standards + " ");
                        sb.Append(m.Equ_price + " ");
                        sb.Append(m.Equ_date + " ");
                        sb.Append(m.Equ_location + " ");
                        sb.Append(m.Equ_resp + " ");
                        sb.Append("<img src=\"" + m.Equ_img + "\">");
                        sb.Append("<hr/>");
                    }
                    Label2.Text = sb.ToString();
                }
                else
                {
                    sb.Append("查无设备!");
                    Label2.Text = sb.ToString();
                    return;
                }
            }
        }

        string sqlconn = "Data Source=(LocalDB)\\MSSQLLocalDB;" + "AttachDbFilename='|DataDirectory|\\EMSdb1.mdf';";
        void ShowData()
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = sqlconn;
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Equ", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                FileUpload1.SaveAs(Server.MapPath("images/" + FileUpload1.FileName));//上传图片
                Image1.ImageUrl = "images/" + FileUpload1.FileName;
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = sqlconn;
                    cn.Open();
                    string sqlstr = string.Format("INSERT INTO Equ(Equ_id,Equ_name,Equ_standards,Equ_price,Equ_date,Equ_location,Equ_resp,Equ_img)" +
                    "VALUES(N'{0}',N'{1}',N'{2}','{3}','{4}',N'{5}',N'{6}',N'{7}')", TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, Image1.ImageUrl);
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
                FileUpload1.SaveAs(Server.MapPath("images/" + FileUpload1.FileName));//上传图片
                Image1.ImageUrl = "images/" + FileUpload1.FileName;
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = sqlconn;
                    cn.Open();
                    string sqlstr = "UPDATE Equ SET Equ_name=@name,Equ_standards=@standards,Equ_price=@price,Equ_date=@date,Equ_location=@location,Equ_resp=@resp,Equ_img=@img WHERE Equ_id=@id";

                    // 建立SqlCommand对象cmd
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@standards", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@price", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.Date));
                    cmd.Parameters.Add(new SqlParameter("@location", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@resp", SqlDbType.NChar));
                    cmd.Parameters.Add(new SqlParameter("@img", SqlDbType.NChar));
                    cmd.Parameters["@id"].Value = TextBox2.Text;
                    cmd.Parameters["@name"].Value = TextBox3.Text;
                    cmd.Parameters["@standards"].Value = TextBox4.Text;
                    cmd.Parameters["@price"].Value = TextBox5.Text;
                    cmd.Parameters["@date"].Value = TextBox6.Text;
                    cmd.Parameters["@location"].Value = TextBox7.Text;
                    cmd.Parameters["@resp"].Value = TextBox8.Text;
                    cmd.Parameters["@img"].Value = Image1.ImageUrl;
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
                string sqlstr = "DELETE FROM Equ WHERE Equ_id=@id";
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
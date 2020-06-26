using EMS201724112133.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112133
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EMSdb1Entities db = new EMSdb1Entities();
            try
            {
                string Uid = TextBox1.Text;
                string Upass = TextBox2.Text;
                var result1 = db.Emp.Where(m => m.Emp_id == Uid && m.Emp_pass == Upass);
                if (result1.Count() != 0)
                {
                    var result2 = from m in db.Emp
                                  where m.Emp_id == TextBox1.Text
                                  select m;
                    StringBuilder sb = new StringBuilder();
                    foreach (var s in result2)
                    {
                        sb.Append(s.Emp_manager);
                    }
                    Session["CurrentId"] = TextBox1.Text;
                    if (sb.ToString() == "True")
                    {
                        Response.Redirect("./Default.aspx");
                    }
                    else
                    {
                        Response.Redirect("./1.aspx");
                    }
                }
                else
                {
                    Response.Write("<script>alert('编号或密码错误')</script>");
                }
            }
            catch
            {
                Response.Write("<script>alert('登录异常')</script>");
            }
        }
    }
}
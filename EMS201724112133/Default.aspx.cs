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
    public partial class Default : System.Web.UI.Page
    {
        EMSdb1Entities db = new EMSdb1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
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
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            var result = from m in db.Emp
                         where m.Emp_name == Label1.Text
                         select m;
            StringBuilder sb = new StringBuilder();
            foreach (var s in result)
            {
                sb.Append(s.Emp_manager);
            }
            if (Session["CurrentId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else if (sb.ToString() == "True")
            {
                Response.Redirect("21.aspx");
            }
            else
            {
                Response.Write("<script>alert('对不起，你没有权限查看')</script>");
            }
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            var result = from m in db.Emp
                         where m.Emp_name == Label1.Text
                         select m;
            StringBuilder sb = new StringBuilder();
            foreach (var s in result)
            {
                sb.Append(s.Emp_manager);
            }
            if (Session["CurrentId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else if (sb.ToString() == "True")
            {
                Response.Redirect("22.aspx");
            }
            else
            {
                Response.Redirect("1.aspx");
            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            var result = from m in db.Emp
                         where m.Emp_name == Label1.Text
                         select m;
            StringBuilder sb = new StringBuilder();
            foreach (var s in result)
            {
                sb.Append(s.Emp_manager);
            }
            if (Session["CurrentId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else if (sb.ToString() == "True")
            {
                Response.Redirect("23.aspx");
            }
            else
            {
                Response.Write("<script>alert('对不起，你没有权限查看')</script>");
            }
        }

        protected void btnToLog_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
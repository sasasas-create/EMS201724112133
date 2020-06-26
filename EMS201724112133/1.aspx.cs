using EMS201724112133.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMS201724112133
{
    public partial class _1 : System.Web.UI.Page
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('对不起，你没有权限查看')</script>");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('对不起，你没有权限查看')</script>");
        }

        protected void btnToLog_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
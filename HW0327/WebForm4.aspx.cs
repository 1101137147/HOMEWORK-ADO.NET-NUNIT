using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW0327
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnselect_Click(null, null);
        }

        protected void btnselect_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HomeworkConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "select * from Student where StudentName like @StudentName";
                    cmd.Parameters.Add(new SqlParameter("@StudentName", "%" + selecttext.Text + "%"));

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        GridView1.DataSource = ds;
                        GridView1.DataMember = "Table";
                        GridView1.DataBind();
                        da.Fill(ds);
                    }
                }
            }
        }
        protected void btnadd_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HomeworkConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "select * from Student";
                    cmd.Parameters.Add(new SqlParameter("@StudentName", "%" + selecttext.Text + "%"));

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        DataSet ds = new DataSet();
                        ds.Clear();
                        da.Fill(ds);
                        DataTable dt = ds.Tables["Table"];
                        DataRow dr = dt.NewRow();
                        dr["StudentName"] = name.Text;
                        dr["StudentAge"] = age.Text;
                        dr["StudentPhone"] = phone.Text;
                        dt.Rows.Add(dr);
                        da.Update(dt);

                        btnselect_Click(null, null);
                    }
                }
            }
        }
        protected void btnupdate_Click(object sender, EventArgs e)
        {
            string sql = @"update [Student] set [StudentName] = @StudentName, [StudentAge] = @StudentAge,[StudentPhone] = @StudentPhone
                             where StudentId = @StudentId";
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HomeworkConnectionString"].ConnectionString))
            {
                cn.Open();
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new SqlParameter("@StudentId", sid.Text));
                    cmd.Parameters.Add(new SqlParameter("@StudentName", name2.Text));
                    cmd.Parameters.Add(new SqlParameter("@StudentAge", age2.Text));
                    cmd.Parameters.Add(new SqlParameter("@StudentPhone", phone2.Text));
                    cmd.ExecuteNonQuery();
                }
                btnselect_Click(null, null);
            }
        }

        protected void btndel_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HomeworkConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandText = "select * from Student";

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        DataSet ds = new DataSet();
                        ds.Clear();
                        da.Fill(ds);
                        DataTable dt = ds.Tables[0];
                        DataRow dr = dt.Select(string.Format("StudentId= {0}", Studentid.Text)).First();
                        dr.Delete();
                        da.Update(dt);
                        btnselect_Click(null, null);
                    }
                }
            }
        }

    }


}

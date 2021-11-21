using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HRBAL1;


namespace HRDAL
{
    public class EmpProjectDAL
    {
        public DataTable EmpProject()
        {
            string s = "select * from EmpProject";
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-JF2QMSQ6\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable t = ds.Tables[0];
            return t;
        }
        public List<EmpProject> showdetails()
        {
            List<EmpProject> emp = new List<EmpProject>();
            string s = "select * from EmpProject";
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-JF2QMSQ6\\SQLEXPRESS;Initial Catalog=HRdb;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(s, cn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable t = ds.Tables[0];
            int p = t.Rows.Count;
            for (int i = 0; i < p; i++)
            {
                EmpProject e = new EmpProject();
                e.EmpId = Convert.ToInt32(t.Rows[i][0]);
                e.ProjId = Convert.ToInt32(t.Rows[i][1]);
              

                emp.Add(e);

            }
            return emp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagerTab.Repositories;

namespace TaskManagerTab.Repositories
{
    public class SqlTaskRespository : ITaskRepository
    {
        public DataTable GetAll()
        {
            string connectionstring = "Data Source=.\\sqlexpress;Initial Catalog=TaskManagerDB;Integrated Security=True; TrustServerCertificate=True";
            var con = new SqlConnection(connectionstring);
            var da = new SqlDataAdapter(@"
            SELECT
                t.TaskID,
                t.Description,
                t.Expected_Date,
                t.Task_Date,
                t.Expected_Hours,
                a.AssigneeName
            FROM Tasks t
            JOIN Assignees a ON t.AssigneeID = a.AssigneeID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

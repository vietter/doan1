using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class DataAccess
    {
        SqlConnection connect = null;
        Exception error;
        public DataAccess()
        {
            string connectString = @"Data Source=DESKTOP-SJULKJC;Initial Catalog=TheNewStarHotel_DB;Integrated Security=True ";
            connect = new SqlConnection(connectString);

        }
        public int Execute(string cmdtext, params SqlParameter[] para)
        {
            int result = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(cmdtext, connect);
                cmd.Parameters.AddRange(para);
                connect.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                error = ex;
            }
            finally
            {
                if(connect != null && connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }
               
            }
            return result;
        }
        public DataSet getdataset (string sqlcmd, params SqlParameter[] para)
        {
            Exception error;
            DataSet result = new DataSet();
            try
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd, connect);
                adapter.SelectCommand.Parameters.AddRange(para);
                adapter.Fill(result);
            }
            catch(Exception ex)
            {
                error = ex;
            }
            finally
            {
                if(connect != null & connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }
            }
            return result;

            }
        }

    }
    



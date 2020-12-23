using DTOLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class ADODBProvider: IDBProvider
    {
        private String sql_conn_string;

        public ADODBProvider(): this(@"Data Source=DESKTOP-N5TF96M;Initial Catalog=Northwind;Integrated Security=True")
        {
        }
        public ADODBProvider(string connectionString)
        {
            sql_conn_string = connectionString;
        }

        public List<DTO_Employee> GetAllEmployees()
        {
            List<DTO_Employee> result_list = new List<DTO_Employee>();

            using (SqlConnection sql_conn = new SqlConnection(sql_conn_string))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sql_conn;
                    cmd.CommandText = "Select * from Employees";
                    try
                    {
                        sql_conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            DTO_Employee emp = new DTO_Employee();
                            emp.ID = (int)dr[0];
                            emp.FirstName = dr[1].ToString();
                            emp.LastName = dr[2].ToString();

                            DateTime? hiredate = dr[6] as DateTime?;
                            emp.HireDate = hiredate.HasValue ? hiredate.Value : new DateTime(2000, 1, 1);

                            result_list.Add(emp);
                        }
                        dr.Close();
                    }
                    catch (Exception excp)
                    {
                        OperationResult res = new OperationResult()
                        {
                            Message = excp.Message,
                            IsOperationOK = false
                        };
                    }
                    finally
                    {                        
                        sql_conn.Close();
                    }                  
                }
            }
            return result_list;
        }

        public DTO_Employee GetEmployeeByID(int EmployeeID)
        {
            DTO_Employee result = new DTO_Employee();

            using (SqlConnection sql_conn = new SqlConnection(sql_conn_string))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sql_conn;
                    cmd.CommandText = "Select * from Employees where EmployeeID=" + EmployeeID;
                    try
                    {
                        sql_conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            DTO_Employee emp = new DTO_Employee();
                            emp.ID = (int)dr[0];
                            emp.FirstName = dr[1].ToString();
                            emp.LastName = dr[2].ToString();

                            DateTime? hiredate = dr[6] as DateTime?;
                            emp.HireDate = hiredate.HasValue ? hiredate.Value : new DateTime(2000, 1, 1);

                            result = emp;
                        }
                        dr.Close();
                    }
                    catch (Exception excp)
                    {
                        OperationResult res = new OperationResult()
                        {
                            Message = excp.Message,
                            IsOperationOK = false
                        };
                    }
                    finally
                    {
                        sql_conn.Close();
                    }
                }
            }
            return result;
        }
    }
}

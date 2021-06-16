using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using Dapper;
using System.Data;

namespace day1.Controllers
{
    public class DapperHelper<T>
    {

        //实例化数据库
        public static SqlConnection Gett()
        {
            return new SqlConnection("server=.;uid=sa;pwd=123456;database=db518");
        }
        public static object Scalar(string sql) 
        {
            using (IDbConnection conn= Gett()) 
            {
                conn.Open();
                var result = conn.ExecuteScalar(sql);
                return result;
            }
        }
        //public static SqlConnection Get() 
        //{
        //    return new SqlConnection("");
        //}

        //CUD
        public static int Execute(string sql,object param) 
        {
            using (IDbConnection conn= Gett()) 
            {
                conn.Open();
                return conn.Execute(sql,param);
            }
        }

        //R
        public static IDataReader ExecuteReader(string sql,object param) 
        {
            using (IDbConnection conn = Gett())
            {
                return conn.ExecuteReader(sql,param);
            }
        }

        //查询
        public static List<T> Query(string sql,object param) 
        {
            using (IDbConnection conn = Gett()) 
            {
                return conn.Query<T>(sql, param).ToList();
            }
        }
    }
}

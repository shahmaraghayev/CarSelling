using CarSellingDAL.Domain;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSellingDAL.DAL
{
    public class LoginDal : BaseDal
    {
        Logger logger;
        public LoginDal()
        {
            logger = LogManager.GetCurrentClassLogger();
        }
        public bool LoginUser(Login f)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@name", f.Name, DbType.String));
            parameters.Add(sqlHelper.CreateParameter("@password", f.Password, DbType.String));

            var dataReader = sqlHelper.GetDataReader
                ("SELECT * FROM Users WHERE Name = @name AND Password = @password",
                CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                while (dataReader.Read())
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
        }

        public Users GetUserByUserName(string Email)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Email", Email, DbType.String));

            var dataReader = sqlHelper.GetDataReader("SELECT Id, Email,Password,Code,CodeDate,CreateDate ,Salt FROM Users Where Email=@Email ",

                CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                var users = new Users();
                while (dataReader.Read())
                {
                    users.Id = dataReader["Id"] == System.DBNull.Value ? default(int) : (int)dataReader["Id"];
                    users.Email = dataReader["Name"].ToString();
                    users.Password = dataReader["Password"].ToString();
                    users.Code = dataReader["Code"] == System.DBNull.Value ? default(int) : (int)dataReader["Code"];
                    users.CodeDate =Convert.ToDateTime(dataReader["CodeDate"]);
                    users.CreateDate = Convert.ToDateTime(dataReader["CreateDate"]);
                    users.Salt = dataReader["Salt"].ToString();
                }

                return users;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "GetUserByUserName");
                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
        }

    }
}

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
 public   class UsersDal:BaseDal
    {
        Logger logger;
        public UsersDal()
        {
            logger = LogManager.GetCurrentClassLogger();
        }

        public int Insert(Users users)
        {
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(sqlHelper.CreateParameter("@Email", 50, users.Email, DbType.String));
                parameters.Add(sqlHelper.CreateParameter("@Password", 100, users.Password, DbType.String));
                parameters.Add(sqlHelper.CreateParameter("@Salt", 50, users.Salt, DbType.String));
                parameters.Add(sqlHelper.CreateParameter("@Code", users.Code, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@Name", users.Name, DbType.String));
                parameters.Add(sqlHelper.CreateParameter("@PhoneNumber", users.Number, DbType.Int32));
               

                int lastId = 0;
                sqlHelper.Insert("INSERT INTO Users(Email,Password,Code,Salt,Name,PhoneNumber) VALUES (@Email,@Password,@Code,@Salt,@Name,@PhoneNumber)",
                    CommandType.Text, parameters.ToArray(), out lastId);

                return lastId;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "Users update");
                throw;
            }

        }

        public Users GetByEmail(string email)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Email", email, DbType.String));

            var dataReader = sqlHelper.GetDataReader("SELECT Id, Email,Password,Code,CreateDate,Salt,PhoneName,PhoneNumber FROM Users WHERE  Email=@Email",

                CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                var users = new Users();
                while (dataReader.Read())
                {
                    users.Id = dataReader["Id"] == System.DBNull.Value ? default(int) : (int)dataReader["Id"];
                    users.Email = dataReader["Email"].ToString();
                    users.Password = dataReader["Password"].ToString();
                    users.Code = dataReader["Code"] == System.DBNull.Value ? default(int) : (int)dataReader["Code"];
                    //users.CodeDate = Convert.ToDateTime(dataReader["CodeDate"].ToString());
                   // users.CreateDate = Convert.ToDateTime(dataReader["CreateDate"].ToString());
                    users.Salt = dataReader["Salt"].ToString();
                    users.Name = dataReader["Name"].ToString();
                    users.Number = dataReader["PhoneNymber"].ToString();
                }
            
                return users;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "Users GetByEmail");
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

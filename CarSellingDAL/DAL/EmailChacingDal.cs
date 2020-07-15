using CarSellingDAL.DAL;
using CarSellingDAL.Domain;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSellingDAL
{
  public  class EmailChacingDal: BaseDal
    {
        Logger logger;
        public EmailChacingDal()
        {
            logger = LogManager.GetCurrentClassLogger();
        }

        public int Insert(EmailChecking emailChaching)
        {
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(sqlHelper.CreateParameter("@Email", 150, emailChaching.Email, DbType.String));

                parameters.Add(sqlHelper.CreateParameter("@Kod", emailChaching.Kod, DbType.Int32));

                parameters.Add(sqlHelper.CreateParameter("@KodGenerateDate", emailChaching.KodGenerateDate, DbType.DateTime));
                int lastId = 0;

                sqlHelper.Insert("INSERT INTO EmailChacking(Email,Kod,KodGenerateDate) VALUES (@Email,@Kod,@KodGenerateDate)",
                    CommandType.Text, parameters.ToArray(), out lastId);

                return lastId;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "EmailChacking");
                throw;
            }

        }

        public bool GetByCode(int Code,string Email)
        {
            bool netice = false;
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Code", Code, DbType.Int32));
            parameters.Add(sqlHelper.CreateParameter("@Email",Email,DbType.String));

            var dataReader = sqlHelper.GetDataReader("SELECT Id,Email,Kod,KodGenerateDate FROM EmailChacking WHERE Kod=@Code AND Email=@Email",  
                CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                var codes = new EmailChecking();
                while (dataReader.Read())
                {
               
                    codes.KodGenerateDate = dataReader["KodGenerateDate"] == System.DBNull.Value ? default(DateTime) : (DateTime)dataReader["KodGenerateDate"];
                }
                DateTime t = codes.KodGenerateDate ?? (DateTime.Now.AddDays(-10));
                double minutes = (DateTime.Now - t).TotalMinutes;
                if (minutes<5)
                {
                    netice = true;
                }
            }
            catch (Exception exp)
            {
                logger.Error(exp, "EmailChacking");
                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return netice;
        }
    }
}

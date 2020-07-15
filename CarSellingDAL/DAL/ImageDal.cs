using CarSellingDAL.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSellingDAL.DAL
{
  public  class ImageDal:BaseDal
    {
        public int Insert(CarImages image)
        {
            try
            {
                var parameters = new List<SqlParameter>();
                int lastId = 0;
                parameters.Add(sqlHelper.CreateParameter("@Url",image.Url,DbType.String));
                parameters.Add(sqlHelper.CreateParameter("@CarId", image.CarId, DbType.Int32));
                sqlHelper.Insert(" INSERT INTO CarImages(Url,CarId) VALUES (@Url, @CarId) ", CommandType.Text, parameters.ToArray(), out lastId);
                return lastId;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

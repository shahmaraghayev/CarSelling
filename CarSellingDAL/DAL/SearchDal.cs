using CarSellingDAL.ViewModel;
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
   public class SearchDal:BaseDal
    {
        Logger logger;
        public SearchDal()
        {
            logger = LogManager.GetCurrentClassLogger();
        }
        public IEnumerable<SearchViewModel> GetAllByCarName(int BrandId,int ModelId,decimal PriceMin,decimal PriceMax,DateTime ManifactureDateMin, DateTime ManifactureDateMax, int CitiId)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@BrandId",BrandId, DbType.Int32));
            parameters.Add(sqlHelper.CreateParameter("@ModelId", ModelId, DbType.Int32));
            parameters.Add(sqlHelper.CreateParameter("@PriceMin", PriceMin, DbType.Decimal));
            parameters.Add(sqlHelper.CreateParameter("@PriceMax", PriceMax, DbType.Decimal));

            parameters.Add(sqlHelper.CreateParameter("@ManifactureDateMin", ManifactureDateMin, DbType.DateTime));
            parameters.Add(sqlHelper.CreateParameter("@ManifactureDateMax", ManifactureDateMax, DbType.DateTime));

            parameters.Add(sqlHelper.CreateParameter("@CitiId", CitiId, DbType.Int32));


            string sql = "SELECT C.Id as Car,B.Id as Brand,M.Id as Model,K.Id as Color,C.Price,F.Id as FuelType,T.Id as Transmition,G.Id as Gearbox,C.ManifactureDate,E.Id EngineCapacity,C.EnginePower,C.AZN,C.USD,C.EURO,C.Description,C.AlloyWheels,"+
" C.CentralClosure,C.LeatherSalon,C.SeatVentilation,C.ABS,C.ParkingRadar,C.KsenonLamps,C.Lyuk,C.Conditioner,C.RearViewCamera, "+
 "C.RainSensor,C.SeatHeating,C.SideCurtains,U.Id as Users,B.Id as BanTaype,ci.Id as Citi,C.Kilometerage "+
      "FROM Cars C "+
      "   LEFT JOIN Brands B "+
      "   ON C.BrandId = B.Id "+
        " LEFT JOIN Models M "+
        " ON C.ModelId = M.Id "+
        " LEFT JOIN Colors K "+
        " ON C.ColorId = K.Id "+
        " LEFT JOIN FuelTypes F "+
        " ON C.FuelTypeId = F.ID "+
        " LEFT JOIN TransmitionTypes T "+
        " ON C.TransmitionTypeId = T.Id "+
        " LEFT JOIN GearboxTypes G "+
        " ON C.GearboxTypeId = G.Id " +
        " LEFT JOIN EngineCapacities E "+
        " On C.EngineCapaciyId = E.Id " +
        " LEFT JOIN Users U "+
        " ON C.UserId = U.Id "+
        " LEFT JOIN BanTypes Ba "+
        " ON C.BanTypeId = Ba.Id "+
        " LEFT JOIN Cities ci "+
        " ON C.CitiId = ci.Id ";
            var dataReader = sqlHelper.GetDataReader(sql, CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                var searchResult = new List<SearchViewModel>();
                while (dataReader.Read())
                {
                    var search = new SearchViewModel();
                    search.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    search.Price =Convert.ToDecimal( dataReader["Price"].ToString());
                    search.ManifactureYear =Convert.ToBoolean(dataReader["ManifactureYear"].ToString());
                    search.AllCities = dataReader["AllCities"].ToString();
             
                   
                    searchResult.Add(search);
                }

                return searchResult;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "SeachViewModel");
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

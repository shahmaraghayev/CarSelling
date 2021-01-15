using CarSellingDAL.Domain;
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
  public class CarDal:BaseDal
    {
        Logger logger;
        public CarDal()
        {
            logger = LogManager.GetCurrentClassLogger();
        }

        public int Insert(Cars car)
        {
            try
            {
                var parameters = new List<SqlParameter>();
                int lastId = 0;
                parameters.Add(sqlHelper.CreateParameter("@BrandId", car.BrandId, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@ModelId", car.ModelId, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@ColorId", car.ColorId, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@Price", car.Price, DbType.Decimal));
                parameters.Add(sqlHelper.CreateParameter("@FuelTypeId", car.FuelTypeId, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@TransmitionTypeId", car.TransmitionTypeId, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@GearboxTypeId", car.GearboxTypeId, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@ManifactureDate", car.ManifactureDate, DbType.DateTime));
                parameters.Add(sqlHelper.CreateParameter("@EngineCapaciyId", car.EngineCapaciyId, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@EnginePower", car.EnginePower, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@AZN", car.AZN, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@USD", car.USD, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@EURO", car.EURO, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@Description",1500, car.Description, DbType.String));
                parameters.Add(sqlHelper.CreateParameter("@AlloyWheels", car.AlloyWheels, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@CentralClosure", car.CentralClosure, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@LeatherSalon", car.LeatherSalon, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@SeatVentilation", car.SeatVentilation, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@ABS", car.ABS, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@ParkingRadar", car.ParkingRadar, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@KsenonLamps", car.KsenonLamps, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@Lyuk", car.Lyuk, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@Conditioner", car.Conditioner, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@RearViewCamera", car.RearViewCamera, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@RainSensor", car.RainSensor, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@SeatHeating", car.SeatHeating, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@SideCurtains", car.SideCurtains, DbType.Boolean));
                parameters.Add(sqlHelper.CreateParameter("@UserId", car.UserId, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@BanTypeId", car.BanTypeId, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@CitiId", car.CitiId, DbType.Int32));
                parameters.Add(sqlHelper.CreateParameter("@Kilometerage", car.Kilometerage, DbType.Int32));
                sqlHelper.Insert(            
 " INSERT INTO Cars " +
          " (BrandId " +
           ",ModelId " +
           ",ColorId " +
           ",Price " +
           ",FuelTypeId " +
           ",TransmitionTypeId " +
           ",GearboxTypeId " +
           ",ManifactureDate " +
           ",EngineCapaciyId " +
           ",EnginePower " +
           ",AZN " +
           ",USD " +
           ",EURO " +
           ",Description " +
           ",AlloyWheels " +
           ",CentralClosure " +
           ",LeatherSalon " +
           ",SeatVentilation " +
           ",ABS " +
           ",ParkingRadar " +
           ",KsenonLamps " +
           ",Lyuk " +
           ",Conditioner " +
           ",RearViewCamera " +
           ",RainSensor " +
           ",SeatHeating " +
           ",SideCurtains " +
           ",UserId " +
           ",BanTypeId " +
           ",CitiId " +
           ",Kilometerage)  Output Inserted.Id " +
    " VALUES " +
           "(@BrandId " +
           ",@ModelId " +
           ",@ColorId " +
           ",@Price " +
           ",@FuelTypeId " +
           ",@TransmitionTypeId " +
           ",@GearboxTypeId " +
           ",@ManifactureDate " +
           ",@EngineCapaciyId " +
           ",@EnginePower " +
           ",@AZN " +
           ",@USD " +
           ",@EURO " +
           ",@Description " +
           ",@AlloyWheels " +
           ",@CentralClosure " +
           ",@LeatherSalon " +
           ",@SeatVentilation " +
           ",@ABS " +
           ",@ParkingRadar " +
           ",@KsenonLamps " +
           ",@Lyuk " +
           ",@Conditioner "+
           ",@RearViewCamera " +
           ",@RainSensor " +
           ",@SeatHeating " +
           ",@SideCurtains " +
           ",@UserId "+
           ",@BanTypeId " +
           ",@CitiId " +
           ",@Kilometerage) ",
            CommandType.Text, parameters.ToArray(), out lastId);


                return lastId;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "Insert Cars");
                throw;
            }

        }

        public Cars GetById(int id)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@Id", id, DbType.Int32));

            var dataReader = sqlHelper.GetDataReader("SELECT BrandId,ModelId,ColorId,Price,FuelTypeId,TransmitionTypeId,GearboxTypeId,ManifactureDate,EngineCpaciyId,EnginePower,AZN,USD,EURO,Description,AlloyWheels,CentralClosure,LeatherSalon,SeatVentilation,ABS,ParkingRadar,KsenonLamps,Lyuk,Conditioner,RearViewCamera,RainSensor,SeatHeating,SideCurtains,UserId,BanTypeId,CitiId FROM Cars WHERE d=@Id",
                CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                var cars = new Cars();
                while (dataReader.Read())
                {
                    cars.Id = dataReader["Id"] == System.DBNull.Value ? default(int) : (int)dataReader["Id"];
                    cars.BrandId = dataReader["BrandId"] == System.DBNull.Value ? default(int) : (int)dataReader["BrandId"];
                    cars.ModelId = dataReader["ModelId"] == System.DBNull.Value ? default(int) : (int)dataReader["ModelId"];
                    cars.ColorId = dataReader["ColorId"] == System.DBNull.Value ? default(int) : (int)dataReader["ColorId"];
                    cars.Price = dataReader["Price"] == System.DBNull.Value ? default(decimal) : (decimal)dataReader["Price"];
                    cars.FuelTypeId = dataReader["FuelTypeId"] == System.DBNull.Value ? default(int) : (int)dataReader["FuelTypeId"];
                    cars.TransmitionTypeId = dataReader["TransmitionTypeId"] == System.DBNull.Value ? default(int) : (int)dataReader["TransmitionTypeId"];
                    cars.GearboxTypeId = dataReader["GearboxTypesId"] == System.DBNull.Value ? default(int) : (int)dataReader["GearboxTypeId"];
                    cars.ManifactureDate = Convert.ToDateTime(dataReader["ManifactureDate"]);
                    cars.EngineCapaciyId = dataReader["EngineCapaciyId"] == System.DBNull.Value ? default(int) : (int)dataReader["EngineCapaciyId"];
                    cars.EnginePower = dataReader["EnginePower"] == System.DBNull.Value ? default(int) : (int)dataReader["EnginePower"];
                    cars.AZN = dataReader["AZN"] == System.DBNull.Value ? default(bool) : (bool)dataReader["AZN"];
                    cars.USD = dataReader["USD"] == System.DBNull.Value ? default(bool) : (bool)dataReader["USD"];
                    cars.EURO = dataReader["EURO"] == System.DBNull.Value ? default(bool) : (bool)dataReader["EURO"];
                    cars.Description = dataReader["Description"].ToString();
                    cars.AlloyWheels = dataReader["AlloyWheels"] == System.DBNull.Value ? default(bool) : (bool)dataReader["AlloyWheels"];
                    cars.CentralClosure = dataReader["CentralClosure"] == System.DBNull.Value ? default(bool) : (bool)dataReader["CentralClosure"];
                    cars.LeatherSalon = dataReader["LeatherSalon"] == System.DBNull.Value ? default(bool) : (bool)dataReader["LeatherSalon"];
                    cars.SeatVentilation = dataReader["SeatVentilation"] == System.DBNull.Value ? default(bool) : (bool)dataReader["SeatVentilation"];
                    cars.ABS = dataReader["ABS"] == System.DBNull.Value ? default(bool) : (bool)dataReader["ABS"];
                    cars.ParkingRadar = dataReader["ParkingRadar"] == System.DBNull.Value ? default(bool) : (bool)dataReader["ParkingRadar"];
                    cars.KsenonLamps = dataReader["KsenonLamps"] == System.DBNull.Value ? default(bool) : (bool)dataReader["KsenonLamps"];
                    cars.Lyuk = dataReader["Lyuk"] == System.DBNull.Value ? default(bool) : (bool)dataReader["Lyuk"];
                    cars.Conditioner = dataReader["Conditioner"] == System.DBNull.Value ? default(bool) : (bool)dataReader["Conditioner"];
                    cars.RearViewCamera = dataReader["RearViewCamera"] == System.DBNull.Value ? default(bool) : (bool)dataReader["RearViewCamera"];
                    cars.RainSensor = dataReader["RainSensor"] == System.DBNull.Value ? default(bool) : (bool)dataReader["RainSensor"];
                    cars.SeatHeating = dataReader["SeatHeating"] == System.DBNull.Value ? default(bool) : (bool)dataReader["SeatHeating"];
                    cars.SideCurtains = dataReader["SideCurtains"] == System.DBNull.Value ? default(bool) : (bool)dataReader["SideCurtains"];
                    cars.UserId = dataReader["UserId"] == System.DBNull.Value ? default(int) : (int)dataReader["UserId"];
                    cars.BanTypeId = dataReader["BanTypeId"] == System.DBNull.Value ? default(int) : (int)dataReader["BanTypeId"];
                    cars.CitiId = dataReader["CitiId"] == System.DBNull.Value ? default(int) : (int)dataReader["CitiId"];
                }

                return cars;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "Cars GetById");
                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
        }
        public int GetLastId()
        {
            int id = 0;

            var parameters = new List<SqlParameter>();
           
            var dataReader = sqlHelper.GetDataReader("SELECT IDENT_CURRENT ('CarImages') Id", CommandType.Text, 
                parameters.ToArray(), out connection);

            try
            {
                while (dataReader.Read())
                {
                   id = Convert.ToInt32(dataReader["Id"]);
     
                }
     
            }
            catch (Exception exp)
            {
                logger.Error(exp, "max id");

                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return id ;
        }

        public IEnumerable<CarViewModel> GetAll()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("AllCars", CommandType.StoredProcedure, null, out connection);

            try
            {
                var cars = new List<CarViewModel>();
                while (dataReader.Read())
                {
                    var car = new CarViewModel();
                    car.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    car.BrandName = Convert.ToInt32(dataReader["BrandName"].ToString());
                    car.ModelName = Convert.ToInt32(dataReader["ModelName"].ToString());
                    car.ColorName = Convert.ToInt32(dataReader["ColorName"].ToString());
                    car.Price = Convert.ToDecimal(dataReader["Price"].ToString());
                    car.FuelTypeName = Convert.ToInt32(dataReader["FuelTypeName"].ToString());
                    car.TransmitionTypeName = Convert.ToInt32(dataReader["TransmitionTypeName"].ToString());
                    car.GearboxTypeName = Convert.ToInt32(dataReader["GearboxTypeName"].ToString());
                    car.ManifactureDate = Convert.ToDateTime(dataReader["ManifactureDate"].ToString());
                    car.EngineCapaciyName = Convert.ToInt32(dataReader["EngineCapaciyName"].ToString());
                    car.EnginePower = Convert.ToInt32(dataReader["EnginePower"].ToString());
                    car.AZN = Convert.ToBoolean(dataReader["AZN"].ToString());
                    car.USD = Convert.ToBoolean(dataReader["USD"].ToString());
                    car.EURO = Convert.ToBoolean(dataReader["EURO"].ToString());
                    car.Description =dataReader["Description"].ToString();
                    car.AlloyWheels = Convert.ToBoolean(dataReader["AlloyWheels"].ToString());
                    car.CentralClosure = Convert.ToBoolean(dataReader["CentralClosure"].ToString());
                    car.LeatherSalon = Convert.ToBoolean(dataReader["LeatherSalon"].ToString());
                    car.SeatVentilation = Convert.ToBoolean(dataReader["SeatVentilation"].ToString());
                    car.ABS= Convert.ToBoolean(dataReader["ABS"].ToString());
                    car.ParkingRadar = Convert.ToBoolean(dataReader["ParkingRadar"].ToString());
                    car.KsenonLamps = Convert.ToBoolean(dataReader["KsenonLamps"].ToString());
                    car.Lyuk = Convert.ToBoolean(dataReader["Lyuk"].ToString());
                    car.Conditioner = Convert.ToBoolean(dataReader["Conditioner"].ToString());
                    car.RearViewCamera = Convert.ToBoolean(dataReader["RearViewCamera"].ToString());
                    car.RainSensor = Convert.ToBoolean(dataReader["RainSensor"].ToString());
                    car.SeatHeating = Convert.ToBoolean(dataReader["SeatHeating"].ToString());
                    car.SideCurtains = Convert.ToBoolean(dataReader["SideCurtains"].ToString());
                    car.UserId = Convert.ToInt32(dataReader["UserId"].ToString());
                    car.BanTypeName = Convert.ToInt32(dataReader["BanTypeName"].ToString());
                    car.CitiName= Convert.ToInt32(dataReader["CitiName"].ToString());

                    cars.Add(car);
                }

                return cars;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "CarViewModel");
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

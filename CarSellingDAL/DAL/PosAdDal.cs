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
  public   class PosAdDal:BaseDal
    {
        Logger logger;
        public PosAdDal()
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
                parameters.Add(sqlHelper.CreateParameter("@Description", 1500, car.Description, DbType.String));
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

                sqlHelper.Insert("INSERT INTO Cars(BrandId,ModelId,ColorId,Price,FuelTypeId,TransmitionTypeId,GearboxTypeId,ManifactureDate,EngineCpaciyId,EnginePower,AZN,USD,EURO,Description,AlloyWheels,CentralClosure,LeatherSalon,SeatVentilation,ABS,ParkingRadar,KsenonLamps,Lyuk,Conditioner,RearViewCamera,RainSensor,SeatHeating,SideCurtains,UserId,BanTypeId,CitiId) VALUES (@BrandId,@ModelId,@ColorId,@Price,@FuelTypeId,@TransmitionTypeId,@GearboxTypeId,@ManifactureDate,@EngineCpaciyId,@EnginePower,@AZN,@USD,@EURO,@Description,@AlloyWheels,@CentralClosure,@LeatherSalon,@SeatVentilation,@ABS,@ParkingRadar,@KsenonLamps,@Lyuk,@Conditioner,@RearViewCamera,@RainSensor,@SeatHeating,@SideCurtains,@UserId,@BanTypeId,@CitiId)",
                    CommandType.Text, parameters.ToArray(), out lastId);

                return lastId;
            }
            catch (Exception exp)
            {
                logger.Error(exp, "Insert PosAdDal");
                throw;
            }
           
        }

    }
}

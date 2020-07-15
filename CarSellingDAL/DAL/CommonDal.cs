using CarSellingDAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSellingDAL.DAL
{
 public   class CommonDal:BaseDal
    {
        public IEnumerable<IdNameViewModel> GetBrandsByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Name From Brands ",
                CommandType.Text, null, out connection);

            try
            {
                var brands = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var brand = new IdNameViewModel();
                    brand.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    brand.Name = dataReader["Name"].ToString();
                    brands.Add(brand);
                }

                return brands;
            }
            catch (Exception exp)
            {

                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }
        public IEnumerable<IdNameViewModel> GetModelsByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Name From Models ",
                CommandType.Text, null, out connection);

            try
            {
                var models = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var model = new IdNameViewModel();
                    model.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    model.Name = dataReader["Name"].ToString();
                    models.Add(model);
                }

                return models;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }

        public IEnumerable<IdNameViewModel> GetBanTypesByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id, Name From BanTypes ",
                CommandType.Text, null, out connection);

            try
            {
                var banTypes = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var banType = new IdNameViewModel();
                    banType.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    banType.Name = dataReader["Name"].ToString();
                    banTypes.Add(banType);
                }

                return banTypes;
            }
            catch (Exception exp)
            {

                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }
        public IEnumerable<IdNameViewModel> GetModelByBrandIdName(int brandId)
        {
            var parameters = new List<SqlParameter>();
            parameters.Add(sqlHelper.CreateParameter("@BrandId", brandId, DbType.Int32));
            var dataReader = sqlHelper.GetDataReader("SELECT Id, Name From Models WHERE BrandId=@BrandId",
                CommandType.Text, parameters.ToArray(), out connection);

            try
            {
                var banTypes = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var banType = new IdNameViewModel();
                    banType.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    banType.Name = dataReader["Name"].ToString();
                    banTypes.Add(banType);
                }

                return banTypes;
            }
            catch (Exception exp)
            {

                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }
        public IEnumerable<IdNameViewModel> GetColorsByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Name From Colors ",
                CommandType.Text, null, out connection);

            try
            {
                var colors = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var color = new IdNameViewModel();
                    color.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    color.Name = dataReader["Name"].ToString();
                    colors.Add(color);
                }

                return colors;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }
        public IEnumerable<IdNameViewModel> GetFuelTypesByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Name From FuelTypes ",
                CommandType.Text, null, out connection);

            try
            {
                var fuelTypes = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var fuelType = new IdNameViewModel();
                    fuelType.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    fuelType.Name = dataReader["Name"].ToString();
                    fuelTypes.Add(fuelType);
                }

                return fuelTypes;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }

        public IEnumerable<IdNameViewModel> GetGearboxTypesByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Name From GearboxTypes ",
                CommandType.Text, null, out connection);

            try
            {
                var gearBoxTypes = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var gearboxType = new IdNameViewModel();
                    gearboxType.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    gearboxType.Name = dataReader["Name"].ToString();
                    gearBoxTypes.Add(gearboxType);
                }

                return gearBoxTypes;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }

        public IEnumerable<IdNameViewModel> GetTansmitionTypesByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Name From TransmitionTypes ",
                CommandType.Text, null, out connection);

            try
            {
                var transmitionTypes = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var transmitionType = new IdNameViewModel();
                    transmitionType.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    transmitionType.Name = dataReader["Name"].ToString();
                    transmitionTypes.Add(transmitionType);
                }

                return transmitionTypes;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }

        public IEnumerable<IdNameViewModel> GetEngineCapacitiesByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Capacity From EngineCapacities ",
                CommandType.Text, null, out connection);

            try
            {
                var engineCapacities = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var engineCapacitie = new IdNameViewModel();
                    engineCapacitie.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    engineCapacitie.Name = dataReader["Capacity"].ToString();
                    engineCapacities.Add(engineCapacitie);
                }

                return engineCapacities;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

        }

        public IEnumerable<IdNameViewModel> GetCityByIdName()
        {
            var parameters = new List<SqlParameter>();
            var dataReader = sqlHelper.GetDataReader("SELECT Id,Name From Cities ",
                CommandType.Text, null, out connection);

            try
            {
                var cities = new List<IdNameViewModel>();
                while (dataReader.Read())
                {
                    var citiy = new IdNameViewModel();
                    citiy.Id = Convert.ToInt32(dataReader["Id"].ToString());
                    citiy.Name = dataReader["Name"].ToString();
                    cities.Add(citiy);
                }

                return cities;
            }
            catch (Exception ex)
            {
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

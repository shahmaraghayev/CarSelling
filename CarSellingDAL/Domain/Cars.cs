using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSellingDAL.Domain
{
    public class Cars
    {
        public int Id { get; set; }

        public int? BrandId { get; set; }
        public int? CarId { get; set; }

        public int? ModelId { get; set; }

        public int? ColorId { get; set; }

        public decimal? Price { get; set; }

        public int? FuelTypeId { get; set; }

        public int? TransmitionTypeId { get; set; }

        public int? GearboxTypeId { get; set; }

        public DateTime ManifactureDate { get; set; }

        public int? EngineCapaciyId { get; set; }

        public int? EnginePower { get; set; }

        public bool? AZN { get; set; }

        public bool? USD { get; set; }

        public bool? EURO { get; set; }

        public string Description { get; set; }
        public string  Url { get; set; }

        public bool? AlloyWheels { get; set; }

        public bool? CentralClosure { get; set; }

        public bool? LeatherSalon { get; set; }

        public bool? SeatVentilation { get; set; }

        public bool? ABS { get; set; }

        public bool? ParkingRadar { get; set; }

        public bool? KsenonLamps { get; set; }

        public bool? Lyuk { get; set; }

        public bool? Conditioner { get; set; }

        public bool? RearViewCamera { get; set; }

        public bool? RainSensor { get; set; }

        public bool? SeatHeating { get; set; }

        public bool? SideCurtains { get; set; }

        public int? UserId { get; set; }

        public int? BanTypeId { get; set; }

        public int? CitiId { get; set; }

        public int Kilometerage { get; set; }

    }
}

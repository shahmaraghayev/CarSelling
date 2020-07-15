using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSellingDAL.ViewModel
{
   public class CarViewModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("Marka")]
        public int? BrandName { get; set; }

        [DisplayName("Model")]
        public int? ModelName { get; set; }

        [DisplayName("Rəng")]
        public int? ColorName { get; set; }

        [DisplayName("Ad")]
        public decimal? Price { get; set; }

        [DisplayName("Yanacaq növü")]
        public int? FuelTypeName { get; set; }

        [DisplayName("Ötürücü")]
        public int? TransmitionTypeName { get; set; }

        [DisplayName("Sürətlər qutusu")]
        public int? GearboxTypeName { get; set; }

        [DisplayName("Buraxılış ili ")]
        public DateTime ManifactureDate { get; set; }

        [DisplayName("Mühərrikin həcmi")]
        public int? EngineCapaciyName { get; set; }

        [DisplayName("Mühərrikin gücü")]
        public int? EnginePower { get; set; }

        [DisplayName("Manat")]
        public bool? AZN { get; set; }

        [DisplayName("Dollar")]
        public bool? USD { get; set; }

        [DisplayName("Evro")]
        public bool? EURO { get; set; }

        [DisplayName("Haqqında məlumat")]
        public string Description { get; set; }

        [DisplayName("Yüngül lehimli disklər")]
        public bool? AlloyWheels { get; set; }

        [DisplayName("Mərkəzi qapanma")]
        public bool? CentralClosure { get; set; }

        [DisplayName("Dəri salon")]
        public bool? LeatherSalon { get; set; }

        [DisplayName("Oturacaqlarin isidilməsi")]
        public bool? SeatVentilation { get; set; }

        [DisplayName("ABS Əyləc sistemi")]
        public bool? ABS { get; set; }

        [DisplayName("Park radarı")]
        public bool? ParkingRadar { get; set; }

        [DisplayName("Ksenon lanpalar")]
        public bool? KsenonLamps { get; set; }

        [DisplayName("Luk")]
        public bool? Lyuk { get; set; }

        [DisplayName("Kondisioner")]
        public bool? Conditioner { get; set; }

        [DisplayName("Arxa göruntu kamerası")]
        public bool? RearViewCamera { get; set; }

        [DisplayName("Yağış sensoru")]
        public bool? RainSensor { get; set; }

        [DisplayName("Oturacaqlarin isidilməsi")]
        public bool? SeatHeating { get; set; }

        [DisplayName("Yan pərdələr")]
        public bool? SideCurtains { get; set; }

       
        public int? UserId { get; set; }

        [DisplayName("Ban növü")]
        public int? BanTypeName { get; set; }

        [DisplayName("Şəhər")]
        public int? CitiName { get; set; }
    }
}

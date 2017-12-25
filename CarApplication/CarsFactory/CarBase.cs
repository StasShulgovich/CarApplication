using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarApplication.Enums;

namespace CarApplication
{
    public abstract class CarBase
    {
        public int Price;
        public TransmissionType Transmission;
        public VolumeType Volume;
        public CarModel CarModel;
        public int BasePrice;
        protected Dictionary<string, int> Prices;

        public CarBase(int basePrice, CarModel carModel, TransmissionType transmission, VolumeType volume)
        {
            BasePrice = basePrice;
            CarModel = carModel;
            Transmission = transmission;
            Volume = volume;
            Prices = new Dictionary<string, int>();
        }

        public abstract int GetPrice();
    }
}

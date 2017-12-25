using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarApplication.Enums;

namespace CarApplication
{
    public class Corolla : CarBase
    {
        public Corolla(int basePrice, CarModel carModel, TransmissionType transmission, VolumeType volume) : base(basePrice, carModel, transmission, volume)
        {
            Prices.Add(TransmissionType.ManualTransmission.ToString(), 900);
            Prices.Add(TransmissionType.AutomaticTransmission.ToString(), 1300);
            Prices.Add(TransmissionType.VariatorTransmission.ToString(), 1800);
            Prices.Add(VolumeType.Volume_1_3.ToString(), 1900);
            Prices.Add(VolumeType.Volume_1_5.ToString(), 2300);
            Prices.Add(VolumeType.Volume_2_0.ToString(), 2800);
            Prices.Add(VolumeType.Volume_2_5.ToString(), 3800);
            Price = GetPrice();
        }
       
        public override int GetPrice()
        {
            int price = BasePrice;
            price += Prices[Transmission.ToString()];
            price += Prices[Volume.ToString()];
            return price;
        }
    }
}

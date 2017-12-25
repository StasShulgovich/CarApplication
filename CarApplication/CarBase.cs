using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
   abstract class CarBase
    {
        public enum TransmissionType
        {
            Manual_Transmission,
            Automatic_Transmission,
            Variator_Transmission,
        }

        public enum VolumeType
        {
            Volume_1_3,
            Volume_1_5,
            Volume_2_0,
            Volume_2_5,
        }

        public enum CarModels
        {
            Corolla,
            Camry,
            LandCruiser
      
        }
        public int Price;
        public TransmissionType Transmission;
        public VolumeType Volume;

        public CarModels CarModel;

        public CarBase(CarModels carmodel,int price, TransmissionType transmission, VolumeType volume)
        {
            Transmission = transmission;
            Volume = volume;
            Price = price;
            CarModel = carmodel;

        }



        public abstract int GetPrice();

        public void GetCar()
        {
            Console.WriteLine("{0}" + " {1}" + " {2}", Price, Transmission, Volume);
            Console.ReadLine();
        }

    }
}

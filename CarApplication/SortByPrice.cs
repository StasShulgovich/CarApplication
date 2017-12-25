using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarApplication;

namespace CarApplication
{
   public class SortByPrice
    {

        public void Sort()
        {

            List<CarBase> cars = new List<CarBase>();
            cars.Add(new Corolla(10000, Corolla.TransmissionType.Automatic_Transmission, Corolla.VolumeType.Volume_1_3));
            cars.Add(new Camry(3000, Camry.TransmissionType.Manual_Transmission, Camry.VolumeType.Volume_1_5));

            foreach (CarBase car in cars)
            {
                car.GetPrice();



            }

            cars = cars.Where<CarBase>(x => x.Price > 3000 && x.Price < 25000).ToList();


            foreach (CarBase car in cars)
            {
                Console.WriteLine("{0} {1} {2}", car.Price, car.Transmission, car.Volume);



            }
            Console.ReadLine();



        }


    };


        







    }





















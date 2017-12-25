using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class SortyByCharacteristics
    {
       

        public void SortCharacteristics()
        {

            Console.WriteLine("To sort cars by manual transmission type 1" + "\n" + "To sort cars by automatic transmission type 2" + "\n" +
                    "To sort cars by variator transmission type 3" + "\n" + "Please, choose your option and click enter button from the keyboard");
            int ChosenTransmission = Convert.ToInt32(Console.ReadLine());



            List<CarBase> cars = new List<CarBase>();
            //My cars collection
            cars.Add(new Corolla(Corolla.CarModels.Corolla, 0, Corolla.TransmissionType.Automatic_Transmission, Corolla.VolumeType.Volume_1_3));
            cars.Add(new Corolla(Corolla.CarModels.Corolla, 0, Corolla.TransmissionType.Manual_Transmission, Corolla.VolumeType.Volume_1_5));
            cars.Add(new Corolla(Corolla.CarModels.Corolla, 0, Corolla.TransmissionType.Variator_Transmission, Corolla.VolumeType.Volume_2_5));
            cars.Add(new Camry(Camry.CarModels.Camry, 0, Camry.TransmissionType.Manual_Transmission, Camry.VolumeType.Volume_1_3));
            cars.Add(new Camry(Camry.CarModels.Camry, 0, Camry.TransmissionType.Manual_Transmission, Camry.VolumeType.Volume_1_5));
            cars.Add(new Camry(Camry.CarModels.Camry, 0, Camry.TransmissionType.Manual_Transmission, Camry.VolumeType.Volume_2_0));
            cars.Add(new Camry(Camry.CarModels.Camry, 0, Camry.TransmissionType.Manual_Transmission, Camry.VolumeType.Volume_2_5));
            cars.Add(new LandCruiser(LandCruiser.CarModels.LandCruiser, 0, LandCruiser.TransmissionType.Automatic_Transmission, LandCruiser.VolumeType.Volume_2_0));
            cars.Add(new LandCruiser(LandCruiser.CarModels.LandCruiser, 0, LandCruiser.TransmissionType.Automatic_Transmission, LandCruiser.VolumeType.Volume_2_5));
            cars.Add(new LandCruiser(LandCruiser.CarModels.LandCruiser, 0, LandCruiser.TransmissionType.Variator_Transmission, LandCruiser.VolumeType.Volume_2_0));
            cars.Add(new LandCruiser(LandCruiser.CarModels.LandCruiser, 0, LandCruiser.TransmissionType.Variator_Transmission, LandCruiser.VolumeType.Volume_2_5));

            foreach (CarBase car in cars)
            {
                car.GetPrice();
            }
            switch (ChosenTransmission)
            {
                case 1:
                    cars = cars.Where<CarBase>(x => x.Transmission == CarBase.TransmissionType.Manual_Transmission).ToList();
                    break;
                case 2:
                    cars = cars.Where<CarBase>(x => x.Transmission == CarBase.TransmissionType.Automatic_Transmission).ToList();
                    break;
                case 3:
                    cars = cars.Where<CarBase>(x => x.Transmission == CarBase.TransmissionType.Variator_Transmission).ToList();
                    break;
                default:
                    Console.WriteLine("You didn't choose any parameters");
                    break;
            }

                                           

            foreach (CarBase car in cars)
            {
                Console.WriteLine("{0} {1} {2} {3}", car.CarModel, car.Price, car.Transmission, car.Volume);



            }
            Console.ReadLine();

        }


    }
}

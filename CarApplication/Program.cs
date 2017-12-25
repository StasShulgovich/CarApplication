using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarApplication.Enums;

namespace CarApplication
{
    public class Program
    {
        private static void showCars(List<CarBase> cars)
        {
            foreach (CarBase car in cars)
            {
                Console.WriteLine("{0} {1} {2} {3}", car.CarModel, car.Price, car.Transmission, car.Volume);
            }
            if (cars.Count == 0)
            {
                Console.WriteLine("Sorry, no cars have been found under specified criteria");
            }
        }

        public static void Main(string[] args)
        {
            for (;;)
            {
                List<CarBase> cars = new List<CarBase>();
                cars.Add(new Corolla(0, CarModel.Corolla, TransmissionType.AutomaticTransmission, VolumeType.Volume_1_3));
                cars.Add(new Corolla(0, CarModel.Corolla, TransmissionType.ManualTransmission, VolumeType.Volume_1_5));
                cars.Add(new Corolla(0, CarModel.Corolla, TransmissionType.VariatorTransmission, VolumeType.Volume_2_5));
                cars.Add(new Camry(0, CarModel.Camry, TransmissionType.ManualTransmission, VolumeType.Volume_1_3));
                cars.Add(new Camry(0, CarModel.Camry, TransmissionType.ManualTransmission, VolumeType.Volume_1_5));
                cars.Add(new Camry(0, CarModel.Camry, TransmissionType.ManualTransmission, VolumeType.Volume_2_0));
                cars.Add(new Camry(0, CarModel.Camry, TransmissionType.ManualTransmission, VolumeType.Volume_2_5));
                cars.Add(new LandCruiser(0, CarModel.LandCruiser, TransmissionType.AutomaticTransmission, VolumeType.Volume_2_0));
                cars.Add(new LandCruiser(0, CarModel.LandCruiser, TransmissionType.AutomaticTransmission, VolumeType.Volume_2_5));
                cars.Add(new LandCruiser(0, CarModel.LandCruiser, TransmissionType.VariatorTransmission, VolumeType.Volume_2_0));
                cars.Add(new LandCruiser(0, CarModel.LandCruiser, TransmissionType.VariatorTransmission, VolumeType.Volume_2_5));

                Console.WriteLine("To show all cars type 1" + "\n" +
                                  "To sort cars by price type 2" + "\n" +
                                  "To sort cars by transmission type 3" + "\n" +
                                  "To sort cars by volume type 4" + "\n" +
                                  "Please, type your option and click enter button from the keyboard");
                try
                {
                    int userChoice = Convert.ToInt32(Console.ReadLine());
                    switch (userChoice)
                    {
                        case 1:
                            showCars(cars);
                            break;
                        case 2:
                            Console.WriteLine("Write the minimal price:");
                            int minPrice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Write the maximum price:");
                            int maxPrice = Convert.ToInt32(Console.ReadLine());

                            cars = cars.Where(x => x.Price > minPrice && x.Price < maxPrice).ToList();
                            showCars(cars);
                            break;
                        case 3:
                            Console.WriteLine("To sort cars by manual transmission type 1" + "\n" +
                                              "To sort cars by automatic transmission type 2" + "\n" +
                                              "To sort cars by variator transmission type 3" + "\n" +
                                              "Please, choose your option and click enter button from the keyboard");
                            int chosenTransmission = Convert.ToInt32(Console.ReadLine());

                            switch (chosenTransmission)
                            {
                                case 1:
                                    cars = cars.Where(x => x.Transmission == TransmissionType.ManualTransmission).ToList();
                                    break;
                                case 2:
                                    cars = cars.Where(x => x.Transmission == TransmissionType.AutomaticTransmission).ToList();
                                    break;
                                case 3:
                                    cars = cars.Where(x => x.Transmission == TransmissionType.VariatorTransmission).ToList();
                                    break;
                                default:
                                    Console.WriteLine("Incorrect input");
                                    break;
                            }

                            showCars(cars);
                            break;
                        case 4:
                            Console.WriteLine("To sort cars by volume 1_3 type 1" + "\n" +
                                              "To sort cars by volume 1_5 type 2" + "\n" +
                                              "To sort cars by volume 2_0 type 3" + "\n" +
                                              "To sort cars by volume 2_5 type 4" + "\n" +
                                              "Please, choose your option and click enter button from the keyboard");
                            int chosenVolume = Convert.ToInt32(Console.ReadLine());

                            switch (chosenVolume)
                            {
                                case 1:
                                    cars = cars.Where(x => x.Volume == VolumeType.Volume_1_3).ToList();
                                    break;
                                case 2:
                                    cars = cars.Where(x => x.Volume == VolumeType.Volume_1_5).ToList();
                                    break;
                                case 3:
                                    cars = cars.Where(x => x.Volume == VolumeType.Volume_2_0).ToList();
                                    break;
                                case 4:
                                    cars = cars.Where(x => x.Volume == VolumeType.Volume_2_5).ToList();
                                    break;
                                default:
                                    Console.WriteLine("Incorrect input");
                                    break;
                            }

                            showCars(cars);
                            break;
                        default:
                            Console.WriteLine("Incorrect input");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect input");
                }
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Corolla : CarBase
    {
        public Corolla(CarModels carmodel, int price, TransmissionType transmission, VolumeType volume) : base(carmodel,price, transmission, volume)
        {
           
            Transmission = transmission;
            Volume = volume;
            Price = price;
            CarModel = carmodel;



        }
       
        public override int GetPrice()
        {
            this.Price = 1000;

            if (Transmission == TransmissionType.Manual_Transmission)
            {
                this.Price += 900;

            }
            else
            {
                if (Transmission == TransmissionType.Automatic_Transmission)
                {
                    this.Price += 1300;
                }
                else
                {
                    this.Price += 1800;
                }
            }




            if (Volume == VolumeType.Volume_1_3)
            {
                this.Price += 1900;

            }
            else
            {
                if (Volume == VolumeType.Volume_1_5)
                {
                    this.Price += 2300;
                }
                else
                {
                    if (Volume == VolumeType.Volume_2_0)
                    {
                        this.Price += 2800;
                    }
                    else
                    {
                        this.Price += 3800; //2,5
                    }
                }
            }


            return Price;

          
        }

        




    }
}

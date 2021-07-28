using System;
using System.Collections.Generic;
using System.Text;

namespace GrayHat1
{
                                //Abstrata      //Interface
    public class Firefitghter : PublicServant, IPerson
    {

        public Firefitghter(string name, int age)
        {
           
            this.Name = name;
            this.Age = age;
        }


        //Interface
        public string Name { get; set; }
        public int Age { get; set; }


        //Abstração
        public override void DriveToPlaceOfInterest()
        {
            GetInFireTruck();
            TurnOnSiren();
            FollowDirections();
        }

        private void GetInFireTruck()
        {
            //Metodo para a Abstração
        }
        private void TurnOnSiren()
        {
            //Outro metodo para a Abtração
        }
        private void FollowDirections()
        {
            //Mais outro metodo para a Abstração
        }

        public override string ToString()
        {
            return Name + ", " + Age;
        }
    }
}

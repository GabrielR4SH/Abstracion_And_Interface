using System;
using System.Collections.Generic;
using System.Text;

namespace GrayHat1
{
    public class PoliceOfficer : PublicServant, IPerson
    {
        
        //Prestando atenção na Logica, a sirene é bool e so liga se tiver Emergencia
        //Class
        private bool _hasEmergency;

        //Constructor
        public PoliceOfficer(string name, int age)
        {
            this.Name =
          name;
            this.Age = age;
            _hasEmergency = false;
        }

        //implement the IPerson interface
        public string Name { get; set; }
        public int Age { get; set; }
        public bool HasEmergency
        {
            get { return _hasEmergency; }
            set{ _hasEmergency = value; }
        }
        public override void DriveToPlaceOfInterest()
        {
            //Implementing Abstraction
            GetInPoliceCar();
            if (this.HasEmergency)
                TurnOnSiren();
            FollowDirections();
        }
        private void GetInPoliceCar()
        {

        }
        private void TurnOnSiren()
        {

        }
        private void FollowDirections()
        {

        }

        
        public override string ToString()
        {
            StringBuilder sasa = new StringBuilder();

            sasa.AppendLine(Name);
            sasa.Append(" ,");
            sasa.Append(" " + Age);

            return sasa.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GrayHat1
{
   public abstract class PublicServant
    {
        //Proper
        public int PersionAmount { get; set; }

        //Metodo Abstrato
        public abstract void DriveToPlaceOfInterest();

        
    }
}

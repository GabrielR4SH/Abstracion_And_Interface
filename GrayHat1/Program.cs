using System;

namespace GrayHat1
{
    class Program
    {
        static void Main(string[] args)
        {

            Firefitghter firefitghter = new Firefitghter("Fernando Lima", 35);
            
            //Instanciado a classe e o PersionAmount que é a abstração

            firefitghter.PersionAmount = 5000;
            //Perceba que a classe em si herda de PublicServant e por isso eu consigo instanciar

            //Caso eu fosse chamar pelo override e o String Builder
            //Console.WriteLine(firefitghter);
            //Console.WriteLine(firefitghter.PersionAmount);

            PrintNameAndAge(firefitghter);
            PrintPersionAmount(firefitghter);

            Console.WriteLine();

            firefitghter.DriveToPlaceOfInterest();

            PoliceOfficer office = new PoliceOfficer("Verme PMLizoso", 52);
            office.PersionAmount = 2000;

            office.HasEmergency = true;

            PrintNameAndAge(office);
            PrintPersionAmount(office);
        
        }



//Name e Age tem para as duas classes, tratar deles de maneira isolada é o correto
        static void PrintNameAndAge(IPerson person)
        {
            //Meu metodo fora do metodo Main, usando a abstração

            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.Age);
        
            //Metodos Staticos para printar
        } 


        //
        static void PrintPersionAmount(PublicServant servant)
        {
            if (servant is Firefitghter)
            {
                //A abstração Resume tanta coisa...
                Console.WriteLine("Persion of Fire Figther: " + servant.PersionAmount);
            }
            else if(servant is PoliceOfficer)
            {
                Console.WriteLine("Persion of PoliceOfficer: " + servant.PersionAmount);
            }
        }
    }
}

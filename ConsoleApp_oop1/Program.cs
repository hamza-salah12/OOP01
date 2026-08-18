using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp_oop1
{
    internal class Program
    {

        #region Theoretical Questions
        //Part 01 : Theoretical Questions
        //Question 1 : in case 1 : the data is copied completely therefor modifying the new var  don't effected about new var   
        //------------------------
        //Question 2 :  in case 2 : to copy is address therefor the two var look at the same object in the heap therefor the original effected by change 

        #endregion

        // Part 02 : Practical Questions
        #region Create a DeliveryAddress struct

        public struct DeliveryAddress
        {
            public string City { get; set; }
            public string Street { get; set; }
            public int BuildingNumber { get; set; }


            public DeliveryAddress (string City , string Street , int BuildingNumber) 
            {
                this.City = City;
                this.Street = Street;
                this.BuildingNumber = BuildingNumber;
            }
            public string GetfullAddress()
            {
                return $"City : {City} , Street : {Street} , BuildingNumber : {BuildingNumber}";
            }
        }

            #endregion

    }
        
    
}

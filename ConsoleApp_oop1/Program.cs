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


            public DeliveryAddress(string City, string Street, int BuildingNumber)
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

        #region Ceate a Shipment struct

        public struct Shipment
        {
            private string _trackingCode;
            private string _description;
            private double _weight;
            private decimal _deliveryFee;

            public string TrackingCode
            {
                get => _trackingCode;

                private set
                {
                    if (!string.IsNullOrWhiteSpace(value)) 
                    _trackingCode = value;
                }
            }

            public string Description
            {
                get => _description;

                set
                {
                    if (!string.IsNullOrWhiteSpace(value)) 
                    _description = value;

                }
            }
            public double Weight
            {
                get => _weight;
                set
                {
                    if (value > 0)
                    {
                        _weight = value;
                    }


                }


            }
            public decimal DeliveryFee
            {
             get => _deliveryFee;
                private set
                {
                    if (value > 0)
                    {
                        _deliveryFee = value;
                          

                    }

                }









            }

            public DeliveryAddress Destination { get; set;}

            public decimal EstimatedCost 
            { 
            get => DeliveryFee + (decimal)(Weight * 5);
            }


        #endregion
        }

    }
}

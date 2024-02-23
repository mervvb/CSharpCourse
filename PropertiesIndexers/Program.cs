using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesIndexers
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarCompany car = new CarCompany("ford", 12345678, 1000);
            car.NativePlace = "London";
            CarCompany car1 = new CarCompany("range rower", 1000);

            Console.WriteLine("Id: " + car.CarID + " / Car Brand: " + car.CarBrand);
            Console.WriteLine("Id: " + car.CarID + " / Car Brand: " + car.CarBrand +
                "Salary: " + car.Salary + " / Place: " + car.NativePlace);
            Console.WriteLine("Car Brand: " + car1.CarBrand + "Salary: " + car1.Salary);
            Console.ReadLine();

        }

    }
    class CarCompany
    {
        public CarCompany(string carBrand, int carID, int salary)
        {
            this._carBrand = carBrand;
            this._carID = carID;
            this._salary = 1000;
        }
        public CarCompany(string carBrand, int salary)
        {
            this._carBrand = carBrand;
            this._salary = 1000;
        }

        private string _carBrand;
        public string CarBrand
        {

            set
            {
                if (value.Length <= 10) { _carBrand = value; } //string
            }
            get { return _carBrand; }
        }
        private int _carID;
        public int CarID
        {
            get { return _carID; }
            set
            {
                if (value >= 12) //int
                {
                    _carID = value;
                }
            }
        }

        private int _salary;
        public int Salary
        {
            get { return _salary; }

        }

        //automatic properties

        public string NativePlace { internal get; set; } = "Turkey";

    }
}

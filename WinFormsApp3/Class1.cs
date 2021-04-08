using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp3
{
    class Customer
    {
        private string name;
        private string alamat;
        private string TypeCar;

        // the customer ID can't be changed because the system will check the validity of CustoMer ID
        public Customer(string _name, string Alamat,string typeCar)
        {
            name = _name;
            alamat = Alamat;
            TypeCar = typeCar;
        }
        public string Name
        {
            get { return name; }
            set { Name = value; }
            // Name can be changed
        }
        public string _alamat
        {
            get { return alamat; }

        }
        public void GetDetails()
        {
            Console.WriteLine(name);
            Console.WriteLine(alamat);
        }


    }
    class Booking
    {
        private string Date;
        private string Time;
        private string _GarageSelection;
        public Booking(string _date, string _time, String _garageselection)
        {
            Date = _date;
            Time = _time;
            _GarageSelection = _garageselection;
        }
        public string date
        {
            get { return Date; }
            set { date = value; }
            //the date can be edited anytime
        }
        public string time
        {
            get { return Time; }
            set { time = value; }
            //the time can be change anytime
        }
        public string _garageSelection
        {
            get { return _GarageSelection; }
            set { _garageSelection = value; }
            //the garage can be change anytime

        }
    }


    interface ServiceSelection
    {
        double QuickService(double _hp, double _years);
        double FullService(double _hp, double _years);
        double TuneUp(double _hp, double _years);
        double ModifyCar(double _hp, double _years);

    }



    class CustomerService
    {
        private string name;
        private string ID;

    }


    abstract class Car
    {
        private string type;
        private double HP;
        private double years;
        private bool turbo;
        private double price;

        public Car(string _type, double _hp, double _years, bool _turbo)
        {
            type = _type;
            HP = _hp;
            years = _years;
            turbo = _turbo;

        }
        public double Price
        {

            get { return price; }
            set { Price = value; }
        }
        public double Hp
        {
            get { return HP; }
        }
        public double Years
        {
            get { return years; }
        }

    }
    sealed class Type1Car : Car, ServiceSelection
    {
        private double HPtotal;
        private double TurboValue;
        private double EstimatedPrice;
        public Type1Car(string type, double HP, double years, bool turbo) : base(type, HP, years, turbo)
        {
            TurboValue = 0.8;
        }
        public double GetMaxHP()
        {

            HPtotal = (TurboValue * base.Hp) + base.Hp;
            return HPtotal;
        }
        public double QuickService(double _hp, double _years)
        {
            EstimatedPrice = 1000000;
            return EstimatedPrice;
        }
        public double FullService(double _hp, double _years)
        {
            EstimatedPrice = 1500000;
            return EstimatedPrice;

        }
        public double TuneUp(double _hp, double _years)
        {
            EstimatedPrice = 1200000;
            return EstimatedPrice;

        }
        public double ModifyCar(double _hp, double _years)
        {
            EstimatedPrice = 0;
            return EstimatedPrice;
        }




    }

    sealed class Type2Car : Car, ServiceSelection
    {
        private double EstimatedPrice;
        public Type2Car(string type, double HP, double years, bool turbo) : base(type, HP, years, turbo)
        {
        }
        public double QuickService(double _hp, double _years)
        {
            EstimatedPrice = 500000;
            return EstimatedPrice;
        }
        public double FullService(double _hp, double _years)
        {
            EstimatedPrice = 1200000;
            return EstimatedPrice;

        }
        public double TuneUp(double _hp, double _years)
        {
            EstimatedPrice = 1000000;
            return EstimatedPrice;

        }
        public double ModifyCar(double _hp, double _years)
        {
            EstimatedPrice = 0;
            return EstimatedPrice;

        }
    }
    sealed class Type3Car : Car, ServiceSelection
    {
        private double EstimatedPrice;
        public Type3Car(string type, double HP, double years, bool turbo) : base(type, HP, years, turbo)
        {
        }
        public double QuickService(double _hp, double _years)
        {
            EstimatedPrice = 300000;
            return EstimatedPrice;
        }
        public double FullService(double _hp, double _years)
        {
            EstimatedPrice = 700000;
            return EstimatedPrice;

        }
        public double TuneUp(double _hp, double _years)
        {
            EstimatedPrice = 500000;
            return EstimatedPrice;

        }
        public double ModifyCar(double _hp, double _years)
        {
            EstimatedPrice = 0;
            return EstimatedPrice;

        }
    }

}

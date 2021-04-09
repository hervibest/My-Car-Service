using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp3
{
    class PaymentMethod
        //Class yang memiliki hubungan composition dengan customer
    {
        private bool Cash;
        private bool Transfer;

    }
    
    
    class Customer
    {
        private string name;
        private string alamat;
        private string TypeCar;
        private PaymentMethod Cash = new PaymentMethod();//Implementasi Hubungan Composition karena Class Customer
                                                         //// Memiliki class PaymentMethod dan hubunganyan sangat erat

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

        private DateTime dt;
        private string _GarageSelection;
        public Booking(DateTime _dt, String _garageselection)
        {
            dt = _dt;
            _GarageSelection = _garageselection;
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


    abstract class Car//menerapkan Abstraction,Dependency, Encapsulation  serta PolyMorphism
    {
        private string type;//properties
        private double HP;//properties
        private double years;//properties
        public abstract void GetDetails();//akan dioverride di class anak sehingga menerapkan Polymorphism
        
    

        public Car(string _type, double _hp, double _years)
        {
            type = _type;
            HP = _hp;
            years = _years;
          

        }
        public string _Type
        {
            get { return type; }

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
        //menerapkan Liskov, Inheritance, Interface
    {
        private double HPtotal;
        private double TurboValue;
        private double EstimatedPrice;
        public Type1Car(string type, double HP, double years) : base(type, HP, years)
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
            EstimatedPrice = 500000;
            return EstimatedPrice;
        }

        public override void GetDetails()
        {
            Console.WriteLine("Tipe mobil adalah :" + _Type + "Tahun pembuatan mobil adalah " + Years+ "Total HP dari mobil ini adalah " + GetMaxHP());

        }


    }

    sealed class Type2Car : Car, ServiceSelection
    {
        private double EstimatedPrice;
        public Type2Car(string type, double HP, double years) : base(type, HP, years)
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
            EstimatedPrice = 400000;
            return EstimatedPrice;

        }
        public override void GetDetails()
        {
            Console.WriteLine("Tipe mobil adalah :" + _Type + "Tahun pembuatan mobil adalah " + Years + "Total HP dari mobil ini adalah " + Hp);

        }

    }
    sealed class Type3Car : Car, ServiceSelection
    {
        private double EstimatedPrice;
        public Type3Car(string type, double HP, double years) : base(type, HP, years)
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
            EstimatedPrice = 300000;
            return EstimatedPrice;

        }
        public override void GetDetails()
        {
            Console.WriteLine("Tipe mobil adalah :" + _Type + "Tahun pembuatan mobil adalah " + Years + "Total HP dari mobil ini adalah " + Hp);

        }
    }

}

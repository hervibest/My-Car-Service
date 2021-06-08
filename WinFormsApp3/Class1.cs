using System;

namespace WinFormsApp3
{
    
    
    
    class Customer
    {
        
        public string TypeCar { get; set; }
      
        
       
        public string Name
        {
            get;set;
           
        }
        public string _alamat
        {
            get;set;

        }
        public void GetDetails()
        {
            Console.WriteLine(Name);
            Console.WriteLine(_alamat);
        }
        public string Password
        {get;set;
        }
        public string Username
        {
            get;set;
        }


    }
    class Booking
    {

        
        private string _GarageSelection;
        
        public string _garageSelection
        {
            get { return _GarageSelection; }
            set { _GarageSelection = value; }
            //the garage can be change anytime

        }
    }


    interface IServiceSelection
    {
        double QuickService(double _hp, double _years);
        double FullService(double _hp, double _years);
        double TuneUp(double _hp, double _years);
        double ModifyCar(double _hp, double _years);

    }

    public class dateTime
    {
        public string Time { get; set; }



    }

  

     class Car//menerapkan Abstraction,Dependency, Encapsulation  serta PolyMorphism
    {
        private string type;//properties
        private double HP;//properties
        private double years;//properties
        public virtual void GetDetails() { }//akan dioverride di class anak sehingga menerapkan Polymorphism
        
    

        public Car(string _type, double _hp, double _years)
        {
            type = _type;
            HP = _hp;
            years = _years;
          

        }
        public string Type
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
    sealed class Type1Car : Car, IServiceSelection
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
            Console.WriteLine("Tipe mobil adalah :" + Type + "Tahun pembuatan mobil adalah " + Years+ "Total HP dari mobil ini adalah " + GetMaxHP());

        }


    }
    public class Cars
    {
        public string Jenis;
        public string PerkiraanHarga;
        public string JenisMobil;
    }
    sealed class Type2Car : Car, IServiceSelection
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
            Console.WriteLine("Tipe mobil adalah :" + Type + "Tahun pembuatan mobil adalah " + Years + "Total HP dari mobil ini adalah " + Hp);

        }

    }
    sealed class Type3Car : Car, IServiceSelection
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
            Console.WriteLine("Tipe mobil adalah :" + Type + "Tahun pembuatan mobil adalah " + Years + "Total HP dari mobil ini adalah " + Hp);

        }
    }

}

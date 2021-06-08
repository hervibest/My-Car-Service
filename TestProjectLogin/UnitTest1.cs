using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace TestProjectLogin
{
    [TestClass]
    public class UnitTest1
    {
        
        class Customer
        {
            IFirebaseConfig fcon = new FirebaseConfig()
            {
                AuthSecret = "DloYF0U5Z2AsSZWD8J23D4vgIqt3f6KvhZfvX1oj",
                BasePath = "https://my-car-service-59f5f-default-rtdb.firebaseio.com/"
            };
            IFirebaseClient client;
            public string TypeCar { get; set; }

            public Customer(string username,string password)
            {
               Username = username;
                Password = password;
                }

            public string Name
            {
                get; set;

            }
            public string _alamat
            {
                get; set;

            }
            
            public string Password
            {
                get; set;
            }
            public string Username
            {
                get; set;
            }
            public bool Loginstatus
            {
                get;set;
            } = false;
            public void Login()
            { 
                var result1 = client.Get("Username/" + Username);
                Customer User = result1.ResultAs<Customer>();
                if (Username == User.Username && Password == User.Password) Loginstatus = true;
               else Loginstatus = false;
            }

        }

        [TestMethod]
        public void TestMethod1()
        {
            Customer customer = new Customer("hervinurr", "Hh250799");
            Assert.AreEqual(false, customer.Loginstatus);
            customer.Login();
            Assert.AreEqual(true, customer.Loginstatus);



        }
    }
}

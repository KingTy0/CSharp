using TestProjectStub;
using TestStubLibrary;
namespace TestforStub
{
    [TestClass]
    public class UnitTest1
    {
        //Lamborghini lamborghini1= new Lamborghini();
        [TestMethod]
        public void RunTest()
        {
            Lamborghini lamborghini = new Lamborghini();
            lamborghini.StartUP();
            Console.WriteLine(lamborghini.About());
            lamborghini.SpeedUp(199);
            Console.WriteLine($"Your current speed is {lamborghini.CurrentSpeed}");
            lamborghini.SlowDown(100);
            Console.WriteLine($"You say hey let not die today in the Author theme song candanice and you slow down your current speed is {lamborghini.CurrentSpeed}");
            Console.WriteLine("you decide to check your dash");
            Console.WriteLine($"{lamborghini.CheckingTheDash()}");
            Console.WriteLine("you decide that you had enough and decide to slow down to a stop");
            lamborghini.SlowDown(99);
            lamborghini.TurnOFF();

            //ShiftTest();
            //Console.WriteLine(lamborghini1.GetGearCount());
            //lamborghini1.transmission.ShiftUP();
            //Console.WriteLine(lamborghini1.GetGearCount());
            //lamborghini1 .transmission.ShiftDOWN();
            //Console.WriteLine(lamborghini1.GetGearCount());
        }
        [TestMethod]
        public void ShiftTest()
        {
            Lamborghini lamborghini = new Lamborghini();
            int testvar = lamborghini.transmission.currentGear;
            lamborghini.transmission.ShiftUP();

            Assert.AreEqual(testvar + 1, lamborghini.transmission.currentGear);


            //do a version of this for shiftDOWN
            // temp var set to current gear var
            //cal shift up
            // assert equal var plus one shift up 
        }
        [TestMethod]
        public void isrunningtest()
        {


            //do a test for isrunning
            Lamborghini lamborghini = new Lamborghini();

            bool testvar = true;
            lamborghini.StartUP();
            Assert.IsTrue(lamborghini.IsEngineRunning());
            lamborghini.TurnOFF();
            Assert.IsFalse(lamborghini.IsEngineRunning());


        }
        [TestMethod]
        public void isIsItOnTest()
        {
            Lamborghini lamborghini = new Lamborghini();

            //start up and turnoff
            lamborghini.StartUP();

            Assert.IsTrue(lamborghini.engine.IsStarted);

            lamborghini.TurnOFF();

            Assert.IsFalse(lamborghini.engine.IsStarted);


        }
        [TestMethod]
        public void SetgearCounttest()
        {
            Lamborghini lamborghini = new Lamborghini();


            //set gear count 
            lamborghini.transmission.HowManyGears = 7;

            Assert.AreEqual(lamborghini.transmission.HowManyGears = 7, lamborghini.GetGearCount());
            //mad broken cause im dum dum womp womp 



        }
        [TestMethod]
        public void EngineCheckTest()
        {
            Lamborghini lamborghini = new Lamborghini();
            //engine check 

            string expectedresult = $"You have a {lamborghini.engine.Name}  your engine is currently {lamborghini.engine.IsStarted}  and your {lamborghini.IsEngineRunning()} ";

            string result = lamborghini.EngineCheck();

            Assert.AreEqual(expectedresult, result);

        }
        [TestMethod]
        public void SpeedupTest()
        {
            Lamborghini lamborghini = new Lamborghini();


            //speed up 
            int testvar;
            testvar = lamborghini.CurrentSpeed;
            lamborghini.SpeedUp(10);

            Assert.AreEqual(testvar + 10, lamborghini.CurrentSpeed);

        }

        [TestMethod]
        public void TestMethod7()
        {
            Lamborghini lamborghini = new Lamborghini();

            //slow down
            int testvar;
            testvar = lamborghini.CurrentSpeed;
            lamborghini.SlowDown(10);
            testvar = 0;
            Assert.AreEqual(testvar, lamborghini.CurrentSpeed);
        }
        [TestMethod]
        public void CheckingTheDashTest()
        {

            Lamborghini lamborghini = new Lamborghini();
            //checking the dash 
            string expectresult = $"{lamborghini.EngineCheck()} and your current speed is {lamborghini.CurrentSpeed}";
            string result = lamborghini.CheckingTheDash();
            Assert.AreEqual(expectresult, result);

        }
        [TestMethod]
        public void TestMethod9()
        {

            Lamborghini lamborghini = new Lamborghini();
            //shift down 
            int testvar;
            //testvar = lamborghini.transmission.ShiftDOWN();


        }
        [TestMethod]
        public void TestMethod10()
        {
            Lamborghini lamborghini = new Lamborghini();
            //about test for supe class 
            string expectedresult = $" You are drive a {lamborghini.Name} with a {lamborghini.SetEngineName(lamborghini.Name)} engine which top speed is set at {lamborghini.TopSpeed} mph with a {lamborghini.transmission.HowManyGears} transmission";
            string result = lamborghini.About();


            Assert.AreEqual(expectedresult, result);
        }
        [TestMethod]
        public void TestMethod11()
        {

            Lamborghini lamborghini = new Lamborghini();
            //var test to make sure that the names are reading correclty 

            string expectedresult1 = "Aventador SV";
            string results1 = lamborghini.Name;

            //second set

            string expectedresult2 = "V12";
            string result2 = lamborghini.SetEngineName(lamborghini.engine.Name);

            Assert.AreEqual(expectedresult1, results1);
            Assert.AreEqual(expectedresult2, result2);

        }
        [TestMethod]
        public void TestMethod12()
        {
            Lamborghini lamborghini = new Lamborghini();

            //var test to make sure that data is being passed right 
            int expectedresult = 218;
            int result = lamborghini.TopSpeed;

            int expectedresult2 = 30;
            lamborghini.SpeedUp(30);
            int result2 = lamborghini.CurrentSpeed;

            Assert.AreEqual(expectedresult, result);
            Assert.AreEqual(expectedresult2, result2);

        }
        [TestMethod]
        public void TestMethod13()
        {
            Lamborghini lamborghini = new Lamborghini();
            //ACT

            //ARRANGE

            //ASSERT
            Assert.IsInstanceOfType(lamborghini, typeof(ILaunchable));
            Assert.IsInstanceOfType(lamborghini, typeof(ILiftable));


        }
    }
}
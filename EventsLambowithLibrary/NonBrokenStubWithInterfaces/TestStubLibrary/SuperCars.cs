using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectStub
{
    public abstract class SuperCars
    {
        public Transmission transmission { get;  set; }

       public  Engine engine { get; set; }

        public int TopSpeed { get; set; }

        public int CurrentSpeed { get; set; }

        public string Name { get; set; }

        public SuperCars()
        {
            this.Name = "";


            this.engine = new Engine(); 
            this.transmission = new Transmission();

        }
        public void SpeedUp(int HowMuch)
        {
            //call shift up when speeding up 
            if (CurrentSpeed + HowMuch < TopSpeed)
            {
                // the two var add togather 
                CurrentSpeed += HowMuch;
            }
            else if (CurrentSpeed + HowMuch > TopSpeed)
            {
                CurrentSpeed = TopSpeed;
                Console.WriteLine("You have the pedtal to the metal you are at top speed cannot go past this speed");

            }
            else
            {
                CurrentSpeed = TopSpeed;
                Console.WriteLine("you are at top speed");

            }

        }
        public bool IsEngineRunning()
        {
            if (engine.IsStarted == true)
            {
                engine.IsRunning = true;
                Console.WriteLine("your engine is currently running perfectly!");
            }
            else if (engine.IsStarted == false) 
            {
                engine.IsRunning = false;
                Console.WriteLine("your engine is currently not running your gonna have to turn it on or walk!");

            }
            return engine.IsRunning;
        
        }
        public void StartUP()
        {
            engine.IsStarted = true;
            Console.WriteLine("you hear the powerful roar of a engine");
            
        }
        public void TurnOFF()
        {
            engine.IsStarted = false;
            Console.WriteLine("You turn off your Super car and step out");


        }
        //public int SetGearCount(int count)
        //{
           
        //    count = transmission.HowManyGears;
        //    return transmission.HowManyGears;

        //}
        public int GetGearCount() { return transmission.HowManyGears; }
            
        //make a method to check isrunning 
        public string EngineCheck()
        {
            // is the engine on? 
            //Is it running 
         return  $"You have a {engine.Name}  your engine is currently {engine.IsStarted}  and your  ";

        }
        public string SetEngineName( string name)
        {
            engine.Name = name;   
            return engine.Name; 
        }
        public void SlowDown(int HowMuch)
        {
            if (CurrentSpeed - HowMuch > 0)
            {
                Console.WriteLine("You are slowing down");
                CurrentSpeed -= HowMuch;
                Console.WriteLine($" your current speed is {CurrentSpeed}");
            }
            else if (CurrentSpeed - HowMuch < 0)
            {
              
                CurrentSpeed = 0;
                Console.WriteLine($"You have reach {CurrentSpeed}mph/Kph");
            }
            else 
            {
               
                CurrentSpeed = 0;
                Console.WriteLine($"you are at {CurrentSpeed}mph/kph");
            }
        }
        public string About()
        {
            //spec of car
            return $" You are drive a {this.Name} with a {engine.Name} engine which top speed is set at {TopSpeed} mph with a {transmission.HowManyGears} transmission";
        }
        public string CheckingTheDash()
        {
            //condidtion of car 
            return $"{EngineCheck} and your current speed is {CurrentSpeed}";
        }
    }
}

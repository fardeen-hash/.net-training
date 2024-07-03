using System;
using System.Threading;
using System.Diagnostics;
 

    public class Stopwatcher
    {
        
        public Stopwatch clock{get; set;}
        
        TimeSpan ts ;
        public Stopwatcher(){
             clock= new Stopwatch();
        }
        public  void Start(){
            
            clock.Start();
            
            
        }

         public  void Stop( ){
            
            clock.Stop();
            ts = clock.Elapsed; 
        }
        public void Display()
        {
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.Write(elapsedTime);
        }
    }

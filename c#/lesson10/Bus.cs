using System;
namespace lesson10{
    public class Bus{
        protected static readonly DateTime globalStartTime;
        protected int RouteNumber { get; set; }
        static Bus()
        {
            globalStartTime = DateTime.Now;

         // The following statement produces the first line of output, 
         // and the line occurs only once.
            Console.WriteLine("Static constructor sets global start time to {0}",
                globalStartTime.ToLongTimeString());
        }
        public Bus(int routeNum)
        {
            RouteNumber = routeNum;
            Console.WriteLine("Bus #{0} is created.", RouteNumber);
        }
        public void Drive()
        {
            TimeSpan elapsedTime = DateTime.Now - globalStartTime;

            // For demonstration purposes we treat milliseconds as minutes to simulate
            // actual bus times. Do not do this in your actual bus schedule program!
            Console.WriteLine("{0} is starting its route {1:N2} minutes after global start time {2}.",
                                 this.RouteNumber,
                                 elapsedTime.TotalMilliseconds,
                                 globalStartTime.ToShortTimeString());
        }
    }
}
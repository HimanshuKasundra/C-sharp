using System;

namespace Lab3
{
    class TrafficSignal
    {
        public static void RunTrafficSignalProgram()
        {
            TrafficSignal.TrafficDel trafficDel = TrafficSignal.Green;
            trafficDel += TrafficSignal.Yellow;
            trafficDel += TrafficSignal.Red;
            trafficDel();
        }

        public delegate void TrafficDel();

        public static void Yellow()
        {
            Console.WriteLine("Yellow Light Signal To Get Ready");
        }

        public static void Green()
        {
            Console.WriteLine("Green Light Signal To Go");
        }

        public static void Red()
        {
            Console.WriteLine("Red Light Signal To Stop");
        }
    }
}
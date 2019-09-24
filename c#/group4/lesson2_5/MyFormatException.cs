using System;
using System.Runtime.Serialization;

namespace lesson2_5
{
    public class MyFormatException : DivideByZeroException
    {
        public string MyMessage = "error format";
        public MyFormatException()
        {
            MyMessage = "Error format";
        }

        public MyFormatException(string message) : base(message)
        {
            MyMessage = message;
        }

        public MyFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public void PrintMessage()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(MyMessage);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;


        }
    }
}
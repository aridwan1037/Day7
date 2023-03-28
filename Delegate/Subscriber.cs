namespace MyProgram
{
    public class Subscriber
    {
        public void MyEventHandler(string message)
        {
            Console.WriteLine("Event Handler by subscriber 1. Message : " + message);
        }
        // public static int Add(int a, int b)
        // {
        //     return a + b;
        // }
        // public static int Multiply(int c, int d)
        // {
        //     return c * d;
        // }
    }
    class Subscriber2
    {
        public static void MyEventHandler(string message)
        {
            Console.WriteLine("Event Handler by subscriber 2. Message : " + message);
        }
        public static void MyEventHandler2(string message)
        {
            Console.WriteLine("Event Handler2 by subscriber 2. Message : " + message);
        }
    }
    class Subscriber3
    {
        public static void MyEventHandler(string message)
        {
            Console.WriteLine("Event Handler by subscriber 3 Message : " + message);
        }
    }
}
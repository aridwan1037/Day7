namespace MyProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Publisher publisher = new ();
            Subscriber subscriber = new ();
            publisher.MyEvent += subscriber.MyEventHandler;
            // publisher.MyEvent += Subscriber2.MyEventHandler;
            // publisher.MyEvent += Subscriber2.MyEventHandler2;
            // publisher.MyEvent += Subscriber3.MyEventHandler;
            // publisher.MyEvent("Hello");
            publisher.DoSomething();
            // Console.Write("Ini punya -=");
            // publisher.MyEvent += subscriber1.MyEventHandler1;
            // publisher.DoSomething();

            // int a = 3;
            // int b = 4;
            // myDelegate addDelegate = new myDelegate(Subscriber.Add);
            // myDelegate mulDelegate = new myDelegate(Subscriber.Multiply);
            // Console.WriteLine(addDelegate(a, b));
            // Console.WriteLine(mulDelegate(a, b));
            // Console.WriteLine(divDelegate(a, b));
        }
    }


}
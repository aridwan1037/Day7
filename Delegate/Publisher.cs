namespace MyProgram
{
    // delegate int myDelegate(int a, int b);
    public class Publisher
    {
        public delegate void MyDelegate(string message);
        // public MyDelegate myPub;
        public event MyDelegate? MyEvent;
        public void DoSomething()
        {
            Console.WriteLine("Do something");
            RaiseEvent("Nama saya");
        }
        public virtual void RaiseEvent(string name)
        {
            MyEvent?.Invoke(name);
        }
    }


}
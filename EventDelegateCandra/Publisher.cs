namespace EventDelegateCandra;

class Publisher
{
    // public delegate void container(object publisher);
    public delegate int container(int c, int b);
    public event container eventContainer;
    // public string data;
    public int _a;
      public  int _b;

    public void Add(container sub)
    {
        eventContainer += sub;
        Console.WriteLine("new subcriber added");
    }

    public void run(int a, int b)
    {
        // data = "rice";
        _a = a;
        _b = b;
        eventContainer?.Invoke(_a, _b);
    }
}
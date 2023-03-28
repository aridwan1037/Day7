namespace EventDelegateCandra;

class Subscriber
{
    public string data2;
    // public void message(object sender)
    // {
    //     data2 = ((Publisher)sender).data;
    //     Console.WriteLine($"data : {data2}");
    // }

    public int message_2(int a, int b)
    {
        Console.WriteLine($"message : {a+b}");
        return a+b;
        // Console.WriteLine("Text2");
    }
}


// public class Program
// {
    // public static void Main(string[] args)
    // {
        LongRunningClass objC = new LongRunningClass();
        objC.LongRunningFunction(callbackfunc);
    // }

    void callbackfunc(int i)
    {
        Console.WriteLine(i.ToString());
    }
// }

public class LongRunningClass
{
    public delegate void callbackfunc(int i);
    public void LongRunningFunction(callbackfunc obj)
    {
        for(int i = 0; i <= 1000; i++)
        {
            obj(i);
        }
    }
}

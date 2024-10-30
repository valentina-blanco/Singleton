using System;

namespace Library;

public class Singleton<T>
{
    private Singleton()
    {
        
    }
    private static Singleton<T> instance;
    public static Singleton<T> Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton<T>();
            }

            return instance;
        }
    }
    public void SayHiToTheWorld()
    {
        Console.WriteLine("Hello World!");
    }
}
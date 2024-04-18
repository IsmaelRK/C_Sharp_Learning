namespace FirstApp;

using System;

public class GoodbyeMessage
{
    public static void SayGoodbye()
    {
        Random random = new Random();
        int randomNumber = random.Next(120);
        
        Console.WriteLine("Goodbye " + randomNumber);
    }
    
}
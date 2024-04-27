using System;
using System.IO;

/// <summary>
///    Class to create an upper case copy of a file
/// </summary>
public class CopyFileUpper
    {
		public static void Main()
		{
        string sFrom;
        string sTo;
        StreamReader srFrom;
        StreamWriter swTo;

        Console.WriteLine("Enter filename to read:");
        sFrom = Console.ReadLine();

        Console.WriteLine("Enter filename to write what we changed:");
        sTo = Console.ReadLine();

        Console.WriteLine("Copy from {0} to {1}", sFrom, sTo);

        try 
        {
            srFrom = new StreamReader(sFrom);
            swTo = new StreamWriter(sTo);
            while (srFrom.Peek() != -1) 
            {
                string sBuffer = srFrom.ReadLine();
                sBuffer = sBuffer.ToUpper();
                swTo.WriteLine(sBuffer);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Input file not found");
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected exception");
            Console.WriteLine(e.ToString());
        }
    }
}

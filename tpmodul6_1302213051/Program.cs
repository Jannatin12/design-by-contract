using System;
using System.Security.Cryptography.X509Certificates;
using tpmodul6_1302213051;

class Program
{
    static void Main(string[] args)
    {
        string nama = "Jannatin";
        SayaTubeVideo tubeVideo = new SayaTubeVideo($"Tutorial Design By Contract - {nama}");

        try
        {
            tubeVideo.IncreasePlayCount(15000000);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        for (int i = 0; i < 1000000; i++)
        {
            try
            {
                tubeVideo.IncreasePlayCount(10);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        tubeVideo.PrintVideoDetails();
    }
}
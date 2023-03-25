using System;
using System.Security.Cryptography.X509Certificates;
using tpmodul6_1302213051;

class Program
{
    static void Main(string[] args)
    {
        string nama = "Jannatin";
        SayaTubeVideo tubeVideo = new SayaTubeVideo($"Tutorial Design By Contract - {nama}");

        tubeVideo.IncreasePlayCount(5000);
        tubeVideo.PrintVideoDetails();
    }
}
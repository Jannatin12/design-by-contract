﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302213051
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random randomID = new Random();
            id = randomID.Next(10000, 99999); ;
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video : " + id);
            Console.WriteLine("Judul Video : " + title);
            Console.WriteLine("Play Count : " + playCount);
        }
    }
}
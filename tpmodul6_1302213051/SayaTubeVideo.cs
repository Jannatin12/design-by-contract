using System;
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
            id = randomID.Next(10000, 99999);
            if (title == null || title.Length > 100)
                throw new ArgumentException("Judul tidak boleh kosong dan maksimal 100 karakter");
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count > 10000000)
            {
                throw new ArgumentException("Maksimal play count 10,000,000.");
            }

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException ex)
            {
                throw new ArgumentException("Play count melebihi batas", ex);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID Video : " + id);
            Console.WriteLine("Judul Video : " + title);
            Console.WriteLine("Play Count : " + playCount);
        }
    }
}

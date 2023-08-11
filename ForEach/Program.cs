using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorular = new string[]
            {
                "Kiskanc misin ? (1:hayir,2:evet)",
                "Ask mi para mi? (1:ask, 2:para)",
                "Kopek mi kedi mi ? (1:kopek,2:kedi)",
                "Marka takintin var mi? (1:hayir,2:evet)",
                "Zeka mi tip mi? (1:zeka 2: tip)"
            };

            string[] cevaplar = new string[sorular.Length];
            for (int i = 0; i < sorular.Length; i++)
            {
                Console.WriteLine(sorular[i] + " ");
                cevaplar[i] = Console.ReadLine();
            }

            int sonuc = 0;
            foreach (string cevap in cevaplar)
            {
                if (cevap == "1")
                {
                    sonuc += 20;
                }
            }
            if (sonuc > 70)
            {
                Console.WriteLine("Harik abir iliskiniz olabilir");
            }
            else if (sonuc >= 30 && sonuc <= 70)
            {
                Console.WriteLine("İliskiye bir sans verebilirsin");
            }
            else
            {
                Console.WriteLine("Bu iliskiden vazgecsen iyi olur");
            }


            Console.Read();
        }
    }
}

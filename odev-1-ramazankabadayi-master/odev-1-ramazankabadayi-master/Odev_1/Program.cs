using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Ermeydani Meydan = new Ermeydani();

            for (int i = 0; i < 16; i++)
            {

                for (int j = 0; j < 16; j++)
                {
                    Meydan.Harita[i,j] = new Bolge();
                }
            }


            Takim A = new Takim();
            Takim B = new Takim();

            for (int i = 0; i < 7; i++)
            {
                A.Birlik[i] = new Er();
                A.Birlik[i] = new Tegmen();
                A.Birlik[i] = new Yuzbasi();
            }

            for (int i = 0; i < 7; i++)
            {
                B.Birlik[i] = new Er();
                B.Birlik[i] = new Tegmen();
                B.Birlik[i] = new Yuzbasi();
            }

            int sayacA = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (sayacA<=6)
                    {
                        Meydan.Harita[i, j].BolgedekiAsker = A.Birlik[sayacA];
                        sayacA++;
                    }
                    
                }
            }

            int sayacB = 0;
            for (int i = 15; i > 11; i--)
            {
                for (int j = 15; j > 11; j--)
                {
                    if (sayacB <= 6)
                    {
                        Meydan.Harita[i, j].BolgedekiAsker = B.Birlik[sayacB];
                       
                        sayacB++;
                    }

                }
            }


            int sayac=1;
            while (true)
            {
                Console.WriteLine("Ermeydanı oynunu");

                foreach (var item in Meydan.Harita)
                {
                    if (sayac>16)
                    {
                        sayac=1;
                        System.Console.WriteLine("");
                    }
                    if (item.BolgedekiAsker==null)
                    {
                        Console.Write("{0} ", "[ ]");
                    }
                    else
                    {
                        Console.Write("{0} ", "[*]");
                    }

                    sayac++;
                }
                Thread.Sleep(1000);
                Console.Clear();
            }

        }
    }
}

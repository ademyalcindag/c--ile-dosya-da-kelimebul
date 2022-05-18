using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        
        
        
            static void Main(string[] args)
            {
                
                List<string> klmlr =System.IO.File.ReadAllLines("dosyam.txt").ToList();
                
                while (true)
                {
                    Console.WriteLine("Bir KELİME girin.:");
                    string kelime= Console.ReadLine();
                    if (kelime.ToLower() == "çık")
                        break;
                    if (klmlr.Contains(kelime))
                    {
                        int statirNO = klmlr.IndexOf(kelime) + 1;
                        Console.WriteLine("Girdiğin '" + kelime + " kelimesi  text dosyasında " + statirNO.ToString() + "bulundu\n");
                    }
                    else
                        Console.WriteLine("Girdiğiniz '" + kelime + "' kelime dosyada bulunamadı. Tekrar deneyin\n");
                }

            }
        }
    }
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Alıskanlıkkazanma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yeni Hobiler ve Yeni Yetenekler Edinmek veya Yeni Alışkanlıklar Kazanmak İçin Kişisel Ajanda

            Console.WriteLine("                                                        ♣ Kişisel Gelişim Ajandasına Hoşgeldiniz ♣\n");
            Console.Read();

            string e = "e";

            Console.Write("Bu");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Ajanda");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Haftalık");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Olarak");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Planlanmıştır.");
            System.Threading.Thread.Sleep(200);

            Console.Write(" Bir");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Hafta");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Boyunca");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Neleri");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Öğrenmek");
            System.Threading.Thread.Sleep(200);
            Console.Write(" veya");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Hangi");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Alışkanlıkları");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Kazanmak");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine(" İstiyorsanız.");
            System.Threading.Thread.Sleep(200);

            Console.Write("Ajandanıza");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Gereken");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Bilgileri");
            System.Threading.Thread.Sleep(200);
            Console.Write(" Girmeniz");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine(" Yeterlidir.");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine();

            Console.Read();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Ajanda Sahibinin Adı Soyadı: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string a = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Sevgili ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(a);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" Hoş Geldiniz\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            DateTime tarih = DateTime.Now;
            Console.Write("Bugünün Tarihi: ");
            Console.WriteLine(tarih.ToString("f"));
            Console.Write("\n");


            for (int i = 0; i < 5; i++)

            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("    * ♥ ☻ * ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("    * ♥ ☻ * ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("    * ♥ ☻ * ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("    * ♥ ☻ * ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("    * ♥ ☻ * ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("    * ♥ ☻ * ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("    * ♥ ☻ * ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("    * ♥ ☻ * ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("    * ♥ ☻ * ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("    * ♥ ☻ * ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("    * ♥ ☻ * ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("    * ♥ ☻ * ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("   * ♥ ☻ *");
                System.Threading.Thread.Sleep(110);


            }
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Lütfen Haftalık Planı Görüntülemek İçin Enter'a Basınız ");
            Console.ReadKey();
            Console.WriteLine("\n");

            for (int i = 1; i <= 7; i++)
            {


                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(i + ".Gün: ");
                if (i == 1)
                {
                    Console.Write("");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    DateTime p = new DateTime(2023, 5, 22);
                    Console.WriteLine(p.ToString());
                   
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("3 Lt Su İçilecek\nKitap okunacak");
                    Console.WriteLine();
                }
                else if (i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    DateTime s = new DateTime(2023, 5, 23);
                    Console.WriteLine(s.ToString());
                   
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("3 Lt Su İçilecek\nKitap okunacak");
                    Console.WriteLine();
                }
                else if (i == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    DateTime c = new DateTime(2023, 5, 24);
                    Console.WriteLine(c.ToString());
                   
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("3 Lt Su İçilecek\nKitap okunacak\nFransızca çalışılacak");
                    Console.WriteLine();
                }
                else if (i == 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    DateTime p = new DateTime(2023, 5, 25);
                    Console.WriteLine(p.ToString());
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("3 Lt Su İçilecek\nKitap okunacak\nFransızca çalışılacak");
                    Console.WriteLine();
                }
                else if (i == 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    DateTime c = new DateTime(2023, 5, 26);
                    Console.WriteLine(c.ToString());
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("3 Lt Su İçilecek\nKitap okunacak\nFransızca çalışılacak");
                    Console.WriteLine();
                }
                else if (i == 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    DateTime c = new DateTime(2023, 5, 27);
                    Console.WriteLine(c.ToString());
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("3 Lt Su İçilecek\nKitap okunacak\nSpor yapılacak");
                    Console.WriteLine();
                }
                else if (i == 7)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    DateTime p = new DateTime(2023, 5, 28);
                    Console.WriteLine(p.ToString());
                    
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("3 Lt Su İçilecek\nKitap okunacak\nSpor yapılacak");
                    Console.Write("");
                }



            }

            Console.ReadKey();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Günleri Görmek isterseniz 'e' tuşuna Çıkış yapmak İsterseniz 'h' Tuşuna  Basınız : ");
            string b = Console.ReadLine();
            Console.WriteLine();

            if (b == "e")
            {
                while (e == "e")
                {

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("İstediğiniz Günü Görmek İçin 1/2/3/4/5/6/7 Tuşlarından Birine Basın : ");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (d == 1)
                    {
                        Console.Write("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("1.Gün ");
                        DateTime p = new DateTime(2023, 5, 22);
                        Console.WriteLine(p.ToString());
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        DateTime k = new DateTime(2023, 5, 22, 22, 0, 0);
                        Console.Write(k.ToString());
                        Console.Write("'da 1 Saat Kitap okunacak");
                        Console.WriteLine("");

                        Console.WriteLine("3 Lt Su İçilecek");
                        Console.WriteLine();
                    }
                    else if (d == 2)
                    {
                        Console.Write("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("2.Gün ");
                        DateTime s = new DateTime(2023, 5, 23);
                        Console.WriteLine(s.ToString());
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        DateTime k = new DateTime(2023, 5, 23, 22, 30, 0);
                        Console.Write(k.ToString());
                        Console.Write("'da 1 Saat Kitap okunacak");
                        Console.WriteLine("");
                        Console.WriteLine("3 Lt Su İçilecek");
                        Console.WriteLine();

                    }
                    else if (d == 3)
                    {
                        Console.Write("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("3.Gün ");
                        DateTime c = new DateTime(2023, 5, 24);
                        Console.WriteLine(c.ToString());
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        DateTime f = new DateTime(2023, 5, 24, 19, 30, 0);
                        Console.Write(f.ToString());
                        Console.WriteLine("'da 2 Saat Fransızca çalışılacak");
                        DateTime k = new DateTime(2023, 5, 24, 22, 30, 0);
                        Console.Write(k.ToString());
                        Console.Write("'da 1 Saat Kitap okunacak");
                        Console.WriteLine("");
                        Console.WriteLine("3 Lt Su İçilecek");
                        Console.WriteLine();

                    }
                    else if (d == 4)
                    {
                        Console.Write("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("4.Gün ");
                        DateTime p = new DateTime(2023, 5, 25);
                        Console.WriteLine(p.ToString());
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        DateTime f = new DateTime(2023, 5, 25, 19, 30, 0);
                        Console.Write(f.ToString());
                        Console.WriteLine("'da 2 Saat Fransızca çalışılacak");
                        DateTime k = new DateTime(2023, 5, 25, 22, 15, 0);
                        Console.Write(k.ToString());
                        Console.Write("'da 1 Saat Kitap okunacak");
                        Console.WriteLine("");
                        Console.WriteLine("3 Lt Su İçilecek");
                        Console.WriteLine();

                    }
                    else if (d == 5)
                    {
                        Console.Write("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("5.Gün ");
                        DateTime c = new DateTime(2023, 5, 26);
                        Console.WriteLine(c.ToString());
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        DateTime f = new DateTime(2023, 5, 26, 19, 30, 0);
                        Console.Write(f.ToString());
                        Console.WriteLine("'da 2 Saat Fransızca çalışılacak");
                        DateTime k = new DateTime(2023, 5, 26, 22, 30, 0);
                        Console.Write(k.ToString());
                        Console.Write("'da 1 Saat Kitap okunacak");
                        Console.WriteLine("");
                        Console.WriteLine("3 Lt Su İçilecek");
                        Console.WriteLine();
                    }
                    else if (d == 6)
                    {
                        Console.Write("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("6.Gün ");
                        DateTime c = new DateTime(2023, 5, 27);
                        Console.WriteLine(c.ToString());
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        DateTime s = new DateTime(2023, 5, 27, 7, 0, 0);
                        Console.Write(s.ToString());
                        Console.WriteLine("'da 1 Saat Spor yapılacak");
                        DateTime k = new DateTime(2023, 5, 27, 9, 0, 0);
                        Console.Write(k.ToString());
                        Console.Write("'da 1 Saat Kitap okunacak");
                        Console.WriteLine("");
                        Console.WriteLine("3 Lt Su İçilecek");
                        Console.WriteLine();

                    }
                    else if (d == 7)
                    {
                        Console.Write("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("7.Gün ");
                        DateTime p = new DateTime(2023, 5, 28);
                        Console.WriteLine(p.ToString());
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        DateTime s = new DateTime(2023, 5, 28, 7, 0, 0);
                        Console.Write(s.ToString());
                        Console.WriteLine("'da 1 Saat Spor yapılacak");
                        DateTime k = new DateTime(2023, 5, 28, 9, 0, 0);
                        Console.Write(k.ToString());
                        Console.Write("'da 1 Saat Kitap okunacak");
                        Console.WriteLine("");
                        Console.WriteLine("3 Lt Su İçilecek");
                        Console.WriteLine();

                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Başka Bir Günü Görmek İster Misiniz ? e/h ");
                    e = Console.ReadLine();
                    Console.WriteLine();
                }

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bir Motivasyon Konuşması Dinlemek İster Misiniz ? e/h ");
            string x = Console.ReadLine();

            if( x =="e")
            {
                System.Diagnostics.Process.Start("hayaller.mp3");
                Console.Write("\n");
            }

            else if ( x =="h")
            {
                Console.WriteLine("");
            }

            else if (b == "h")
            {
                Console.WriteLine("");
            }

            #endregion

        }
    }
}

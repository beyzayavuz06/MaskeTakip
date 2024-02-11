using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WorkAround
{
    internal class Program
  {
    static void Main(string[] args)
    {
        Vatandas vatandas1 = new Vatandas();
        Selamver(isim: "BEYZA");

        int sonuc = Topla(6, 58);

        string ogrenci1 = "ENGİN";
        string ogrenci2 = "KEREM";
        string ogrenci3 = "BERKAY";

        Console.WriteLine(ogrenci1);
        Console.WriteLine(ogrenci2);
        Console.WriteLine(ogrenci3);

        string[] ogrenciler = new string[3];

        ogrenciler[0] = "ENGİN";
        ogrenciler[1] = "KEREM";
        ogrenciler[2] = "BERKAY";

        ogrenciler = new string[4];
        ogrenciler[3] = "İLKER";


        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        String[] sehirler1 = new[] { "ankara", "istanbul", "izmir" };
        String[] sehirler2 = new[] { "bursa", "Antalya", "Diyarbakır" };

        sehirler2 = sehirler1;
        sehirler1[0] = "adana";
        Console.WriteLine(sehirler2[0]);

        List<string> yenisehirler1 = new List<string> { "ankara", "istanbul", "izmir" };
        yenisehirler1.Add("artvin");

        Person person1 = new Person();
        person1.FirstName = "ENGİN";
        person1.LastName = "DEMİROĞ";
        person1.DateOfBirthYear = 1985;
        person1.NationalIdentity = 123;

        Person person2 = new Person();
        person2.FirstName = "MURAT";
        person2.LastName = "TAŞ";
        person2.DateOfBirthYear = 1975;
        person2.NationalIdentity = 234;

        foreach (var sehir in yenisehirler1)
        {
            Console.WriteLine(sehir);
        }

        PttManager pttManager = new PttManager( new ForeignerManager(new PersonManager()));
        pttManager.GiveMask(person1);


        Console.ReadLine();
    }
    static void Selamver(string isim = "isimsiz")
    {
        Console.WriteLine("Merhaba" + isim);
    }

    static int Topla(int sayi1 = 5, int sayi2 = 10)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam :" + sonuc.ToString());
        return sonuc;
    }
}

        public class Vatandas
          {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string DogumYili { get; set; }
            public long TcNo { get; set; }

           }   
}
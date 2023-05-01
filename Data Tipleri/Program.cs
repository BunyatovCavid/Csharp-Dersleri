using System;
using System.Collections.Generic;
using System.Security;
using System.Threading.Channels;
using System.Transactions;

namespace Data_Tipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Deyisen Teyin Etmek
            ////Tip Ad Deyer
            //string name = "Cavid";
            //int number = 45;
            ////Tip Ad
            ////daha sonra Deyer.
            //string surname;
            //int number2;
            //Console.WriteLine();
            //surname = "Bunyatov";
            //number2 = 89;
            //Console.WriteLine();


            ////Deyisenlerimizin adin menali adlar qoymaliyiq!!!!

            ////Deyisenin adi reqem ile baslaya bilmez
            //int number = 87;
            ////Deyisenin adinda xususi simvol ola bilmez.Istisna alttan xett _ .
            //string _name = "Cavid";
            ////Deyisenin adinda bosluq ola bilmez.
            //string fullname = "Bunyatov Cavid";
            ////Deyisenin adi C# dili ucun xususi olan adlar ola bilmez.(data tipleri, keyword ve.s..)
            //string name = "Cavid";
            ////Eyni bir scopun icinde eyni adli deyisenler ola bilmez.
            //string namE = "Cavid";

            #endregion

            #region Data Tipleri

            #region object
            //object data tipi base data tipdi, C# -da var olan butun data tipleri object data tipinden toreyib.
            ////Buna gorede istenilen data tipindeki deyeri ozunde saxlayir.
            
            //object name = "Cavid";
            //object number = 45;
            //object number2 = -45.3648;
            //object check = true;
            //object herf = '*';

            #region Referance
            ////Referance tip kategorisine aid olan bir data tipinde / referance tipinde bir deyisen teyin etdikde deyisenin deyeri Heap-de.
            ////Bu deyerin adressi ise Stack-da saxlanilir.

            //string name = "Cavid";
            //string surname = name;

            //string,class,array,list,interface ve.s....
            #region string
            //string data tipi referance tipi olmasina baxmayaraq, ozunu value tipliymis kimi aparir.
            //string data tipi referance tip kategorisine aid olmasina baxmayaraq, ozunu value tip kategorisine aidmis kimi aparir.

            //string data tipi ozunde bir ve ya bir nece simvol saxlayir.Qosa dirnaqla yazilir.

            //string name =  "Cavid dsadhl aldju9ue@P9uEJPIUPwu9ajh   ua8iwu @ l";

            #endregion

            #endregion

            #region Value
            ////Value tip kategorisine aid olan bir data tipinde / value tipinde bir deyisen teyin etdikde deyisenin hem deyeri,
            ////hemde adi Stack-da saxlanilir.

            //int number = 45;
            //int number2 = number;

            #region Simvol
            //char data tipi sadece bir simvolu ozunde saxlaya bilir.Tek dirnaqla yazilir.
            char herf = '0';
            #endregion

            #region Mentiq
            ////bool data tipi ozunde true ve ya false saxlayir.
            ////bool data tipinin default hali false-du.
            //bool check = true;//1
            //bool yoxlama = false;//0
            #endregion

            #region Ededler
            ////Yaddasda tuttuqlari yer ve Proqram terefinde ala bilecekleri minimum ve maksimum deyerlerdi.

            #region Tam
            //////byte,short,int,long
            //byte number = 255;

            //Console.WriteLine("byte min : " + byte.MinValue);
            //Console.WriteLine("int min : " + int.MinValue);
            //Console.WriteLine("/////");
            //Console.WriteLine("byte max : " + byte.MaxValue);
            //Console.WriteLine("int max : " + int.MaxValue);


            #endregion

            #region Kesr
            ////float , double , decimal

            ////float data tipinde bir deyisen teyin etdikde deyisenin deyerinin sonuna f yazilir.
            //float number2 = 5.26f;
            //float num;
            //num = 63.5f;

            ////decimal data tipinde bir deyisen teyin etdikde deyisenin deyerinin sonuna m yazilir.
            //decimal number3 = -15.36m;

            //double number4 = 10.36;
            #endregion

            #endregion

            #endregion

            #endregion
            #endregion
        }
    }
}

using System.Runtime.CompilerServices;

namespace Tip_Çevrilmələri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tip Çevrilmələri

            #region Cast

            ////Eyni data structuruna(Primitive ve Primitive olmayan data tipileri) sahip olan data tipileri arasinda mumkudu. 

            ////Implicit conversions -gizli cevrilmeler
            ////Data itkisi mumkun olmayan hallarda,
            ////yeni kicik deyer araligina sahip olan data tipinden boyuk deyer araligina sahip olan data tipine cevrilmelerde istifade olunur

            //byte number = 5;//0-255
            //int num = number;//(-2m) - 2m

            //int num5 = 45;

            ////Explicit conversions - Aciq-askar cevrilmeler
            ////Data itkisi mumkun hallarda, yeni boyuk deyer araligina sahip olan data tipinden kicik deyer araligina sahip olan data tipine ce,vrilmelerde istifade olunur.
            ////Signature-u(imzasi) - Tip Ad = (Tip) deyer;

            ////CLR- Common Language RunTime
            //int number2 = 653;
            //byte num2 = (byte) number2;//653-256= 397 -256 = 141
            //Console.WriteLine(num2);

            #endregion

            #region Convert
            ////Convert.ToInt16 - short
            ////Convert.ToInt32 - int
            ////Convert.ToInt64 - long
            //int number3 = 83;
            //byte num3 = Convert.ToByte(number3);//0-255

            //int check_number = 1;
            //int check_number2 = 0;
            //bool check = Convert.ToBoolean(check_number);//1 - True
            //bool check2 = Convert.ToBoolean(check_number2);//0 - False
            //Console.WriteLine(check);
            //Console.WriteLine(check2);
            #endregion

            #region Convert Vs Cast
            ////Convert cast-a gore daha gucludu
            //int check_number3 = 1;
            //bool check3 = Convert.ToBoolean(check_number3);

            ////Convert usulunda ferqli data structura sahip olan deyisenlerin deyerlerin bir birine teyin ede bilirik. Cast usulunda ise data strucura diqqet etmeliyik.
            //int number5 = 45;
            //string str = Convert.ToString(number5);
            //Console.WriteLine(str.GetType());
            //string str2 = number5.ToString();
            ////Convert deyisenin deyerini alir ve basqa bir data tipine teyin edir
            ////Cast ise deyisenin deyerinin data tipini deyisir.
            #endregion

            #region Parse
            ////sadece ve sadece string data tipindeki deyisenin deyerin gosterilen data tipindeki deyisene teyin edir.

            ////Signature-u(imzasi) - Tip Ad = Tip.Parse(string deyisen//deyer)

            //string str3 = "489";
            //int num4 = int.Parse(str3);
            #endregion

            #region as
            ////nullable data tipileri isletmek mumkundu.
            ////nullable- null deyer qebul eden

            ////as keyword-u deyiseni gosterilen data tipine cevire bilir deyisenin deyerin, yox eger cevire bilmirse o zaman null deyerin qaytarir.
            ////Signature-u(imzasi) - Tip Ad = deyisen/deyer as tip;

            //////Value tiplerden sonra ? isarise qoyularsa, hemin data tipindeki deyisene null deyer vere bilerik.
            ////int number6 = null;
            ////int? number5 = null;
            //string str5 = "Cavid";
            //object obj = str5 as object;
            //Console.WriteLine(obj);
            //int? number7 = obj as int?;
            #endregion

            #region is
            ////verilen deyisenin istenilen data tipinde olub olmamasin yoxlayir.
            ////Signature-u(imzasi) - Tip Ad = deyisen/deyer is tip
            //byte number10 = 89;
            //bool check7 = number10 is int;
            //Console.WriteLine(check7);
            #endregion

            #region TryParse
            ////verilen deyisenin istenilenilen data tipine cevrile bilmesin yoxlayir.
            ////Signature-u(imzasi) - Tip Ad = Tip.TryParse(deyisen)

            //string str8 = "397";
            //int c;
            //bool check6 = int.TryParse(str8, out c);
            //Console.WriteLine(check6);
            #endregion

            #endregion

        }

    }
}
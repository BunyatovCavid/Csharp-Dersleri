namespace IfElse_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else 

            ////Sert if blokunda moterizeler daxilinde qeyd olunur.

            ////eger sert dogru olarsa, yeni true cavabin qaytararsa o zaman if blokundaki kodlarimiz ise dusecek
            ////eger sert sehc olarsa, yeni false cavabin qaytararsa o zaman else blokundaki kodlarimi ise dusecek

            //// Ic - ice yazilan if - ler *Nested* if-ler adlanir

            ////Sertlerimiz if bloklarinda olduguna gore if bloklari else bloklari olmadan qeyd oluna biler, amma else bloklari if bloklari olmadan qeyd oluna bilmez

            //// Else if - else if bloklar if blokundaki sert sehv olarsa o zaman hansi sert yoxlanmalidir qeyd edir. her bir else if blokunda sert qeyd edilmelirdir.
            ////else if bloklarin oz else olmur cunki if bloklarinin alternativleridir. Istenilen sayda qeyd oluna biler.
            
            ////If ve else if bloklarinda nizam yuxardan asagidir (yazilma sirasina goredir), yeni if blokundaki sert true olarsa o zaman else if bloklarina girmir
            //// eger if blokundaki sert false ve  o zaman ozunun alternativi olan serte yeni bir altindaki else if serti baxir ve bu sertlerden her hansi biri 
            ///true olana qeder devam edir, eger hec bir sertimiz true olmazsa, o zaman else blokundaki koduuz ise dusur.


            //if(15 < 13) 
            //{
            //    Console.WriteLine("15 boyukdur 13.");

            //}
            //else if(7 < 6)
            //{
            //    Console.WriteLine("7 boyukdur 6");
            //}
            //else if(5 >4)
            //{
            //    Console.WriteLine("5 boyukdur 4");
            //}
            //else
            //{
            //    Console.WriteLine("Sehvdir.");
            //}

            //int number = 5;
            //if(number == 5)
            //{
            //    Console.WriteLine("number = 5");
            //}


            //// Eger ise salinacaq kod sadece bir setirden ibaretdirse o zaman if ve ya else (her ikiside ola biler) blokundaki kodu scopsuz qeyd ede bilersiz

            //if (true)
            //    Console.
            //               WriteLine();
            //else
            //    Console.WriteLine("B");



            //if (true)
            //{

            //}
            //else Console.WriteLine("45");
            #endregion
            
            #region Switch Case
            ////switch bloku if blokundan ferqli olaraq sadece boolean data tipindeki deyerleri qebul etmek yerine, butun data tiplerindeki deyerleri qebul edir
            //// ve deyer hansi case blokundaki deyer ile ust-uste duserse hemin case blokundaki kodu ise salir.


            //// case bloklarindaki kodlarimiz bitdikden sonra utleq sekilde reak keywordu ile qirilmalidir.

            ////goto keywordu compilerin bir-birinden elaqesiz setirler arasinda kecid elemesin saxliyir.

            ////default bloku switch-deki deyerin hec bir case-deki deyer ile uygunlasmadigi halda kodumuzun ne etmeli oldugunu qeyd etdiyimiz hissedir.

            ////default keywordu value data tipindeki data tiplerinin default deyerlerin qaytarir.

            //int number = default(int);
            //Console.WriteLine(default(bool));

            //bool check = true;
            //switch(6)
            //{
            //    case 3:
            //        Console.WriteLine("3-dur");
            //        break;

            //    case 5:
            //        Console.WriteLine("5-dir");
            //        break;

            //    case 6:
            //        goto case 3;
            //        break;

            //    default:
            //        Console.WriteLine("Hec bir reqemle ust uste dusmur");
            //        break;
            //}


            #endregion
        }
    }
}
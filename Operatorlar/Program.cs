namespace Operatorlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Arifmetik (Arithmetic) 
            //// + , - , * ,/ ,% , ++ , --
            //int number1 = 5;
            //int number2 = 2;
            //int number3 = number1 + number2;
            //int number4 = number1 / number2; // 5 / 10 = 0.5
            //int number5 = number1 % number2;
            //Console.WriteLine(number5);

            ////Increment ++ : verilen deyisenin deyerin 1 vahid artir.
            //number1++; // number1 = number1 + 1

            ////Decrement -- : verilen deyisenin deyerin 1 vahid azaldar.
            //number1--; // number1 = number1 - 1
            #endregion

            #region Muqayise (Comparison) 
            //// > , < , >= , <= , == , != , muqayise operatorlari bool data tipinde deyer qaytarir.
            //int num1 = 15;
            //int num2 = 13;

            //bool check1 = num1 > num2; // 15 > 13
            //bool check2 = num1 >= num2; // 15>=13

            //bool check3 = num1 == num2; // 15 == 13 (False)
            //bool check4 = num1 != num2; // 15 != 13 (True)
            //Console.WriteLine(check3);
            //Console.WriteLine(check4);
            #endregion

            #region Mentiq (Logical)
            ////&& , || , !, ^ , bool data tipinde deyer qaytarir

            //// && (ve) - True cavabini ala bilmek ucun operatorun her iki terefindeki sertde True olmalidi.
            //bool check6 = 15 > 13 && 4 < 9; // True && True = True

            //// || (ya) - True cavabini ala bilmek ucun verilen sertlerden her hansi birinin True olasi yeterlidi
            //bool check7 = 15 < 13 || 4 < 9; // False || True = True



            //// ! (xeyr) - verilen bool data tipindeki deyerin tam eksini qaytarir.
            //bool check8 = !(15 > 13); // !True = False
            //bool check9 = !(15 < 13); // !False = True



            //// ^ (ve ya) - True cavabin ala bilmek ucun yanliz bir sert True olmalidi
            //bool check10 = 15 < 13 ^ 4 < 9; // False ^ True = True


            //bool check11 = false ^ true;
            //Console.WriteLine(check11);

            #endregion

            #region Teyin Etme (Assigment)
            //// = , +=,-=,*=,/=....

            //// = (teyin etme) - sag terefdeki deyeri sol terefdeki deyisene teyin edir.
            //string str = "Cavid";

            //int number11 = 45;
            //number11 += 20; // number11 = number11 + 20
            //Console.WriteLine(number11);
            #endregion

            #region Bitwise         

            #region 10-luq say siteminden 2-lik say sistemine ve eksine

            ///* 8
            // *  
            // * 8/2 = 4 (0)
            // * 4/2 = 2 (0)
            // * 2/2 = 1 (0)
            // * 1/2 = 0 (1)
            // *
            // * 0000 1000
            // *
            // * 0      0      0      0      1      0      0      0
            // * 2**7   2**6   2**5   2**4   2**3   2**2   2**1   2**0
            // * 
            // * 0 + 0 + 0 + 0 + 8 + 0 + 0 + 0 = 8
            // */

            ///* 18 
            // * 
            // * 18/2 = 9 (0)
            // * 9/2 = 4 (1)
            // * 4/2 = 2 (0)
            // * 2/2 = 1 (0) 
            // * 1/2 = 0 (1)
            // * 
            // * 
            // * 0001 0010
            // * 
            // *    0       0       0      1       0      0     1      0
            // *    2**7    2**6    2**5   2**4    2**3   2**2  2**1   2**0
            // *    
            // *    0 + 0 + 0 + 16 + 0 + 0 + 2 + 0 = 18
            // *    
            // */


            #endregion

            ///* & - Bitwise And : operatorun sol ve sag terefindeki ededlerin 2-lik say sistemindeki bitlerini qarsilastirir,
            // * eger uygun gelen her iki bit 1 olarsa o zaman uygun gelen bitlerin yerine cavabda 1 yazir, eks halda hemin bitin yerin cavabda 0 yazir.
            // * 
            // * | - Bitwise Or : operatorun sol ve sag terefindeki ededlerin 2-lik say sistemindeki bitlerini qarsilastir,
            // * eger uygun gelen bitlerden her hansi biri 1 olarsa o zaman uygun gelen bitlerin yerine cavabda 1 yazir, eks halda 0 yazir
            // * 
            // * ^ - Bitwise Exclusive Or (XOR) :  operatorun sol ve sag terefindeki ededlerin 2-lik say sistemindeki bitlerini qarsilastir,
            // * eger uygun gelen bitlerden yanliz ve yanliz biri 1 olarsa o zaman uygun gelen bitlerin yerine cavabda 1 yazacaq, eks halda 0 yazacaqdir.
            // * 
            // * ~ - Bitwise Compliment : bir deyer ile isleyir, hemin deyerin tamamlayicisin qaytarir, bunun ucunde evvelce hemen deyerin bitlerinin eks tapir,
            // * daha sonra hemin eksin bir defede eksin tapir  ustune 1 gelir ve menfi 1-e vurur.
            // * -(N + 1)
            // * N = ~(~N)
            // * 
            // * >> - Bitwise shift rigth : operatorun sol terefinde yazilan deyerin bitlerini operatorun sag terefinde yazilan tam eded qeder sag terefe surusdurur.
            // *
            // * << - Bitwise shift left : operatorun sol terefinde yazilan deyerin bitlerini operatorun sag terefinde yazilan tam eded qeder sol terefe surusdurur.
            // */

            //int number1 = 8; //0000 1000
            //int number2 = 18;//0001 0010
            
            //int number3 = number1 & number2; // 0 - 0000 0000

            ///*
            // *  0000 1000  1 -True
            // *  0001 0010  0- False
            // *  
            // *  0000 0000  
            // */

            //int number4 = number1 | number2;// 26 - 0001 1010
            ///*
            // * 26/2 = 13 (0)
            // * 13/2 = 6 (1)
            // * 6/2 = 3 (0)
            // * 3/2 = 1 (1)
            // * 1/2 = 0 (1)
            // * 
            // * 0001 1010
            // * 
            // */


            ///*
            // *  0000 1000  1 -True
            // *  0001 0010  0-False
            // *  
            // *  0001 1010 
            // */

            //int number5 = 2 ^ number2; // 26 - 0001 1010

            ///*
            // *  0000 1000  1 -True
            // *  0001 0010  0-False
            // *  
            // *  0001 1010
            // */


            ///* 2 /2 = 1 (0)
            // * 1/2 = 0 (1)
            // * 
            // * 
            // * 
            // * 0000 0010 1-True
            // * 0001 0010 0-False
            // * 
            // * 0001 0000
            // * 
            // * 
            // * 
            // *  0     0     0     1     0     0     0     0
            // *  2**7  2**6  2**5  2**4  2**3  2**2  2**1  2**0
            // *  
            // *   0 + 0 + 0 + 16 + 0 + 0 +0 +0 = 16
            // */

            //int number6 = ~53;
            //// 0000 1000
            //// 1111 0111
            //// 0000 1000
            //// 0000 1001
            //// - (0000 1001) = -9

            ////  -(N + 1)
            //// N = ~(~N)

            //int number7 = number1 >> 4; // 0000 1000
            ///*
            // *  0000 1000
            // *  
            // *  0000 0010
            // * 
            // */
            //int number8 = number1 << 5; // 0000 1000
            ///*
            // *  0000 1000
            // *  0010 0000
            // */


            //// Console.WriteLine(number8);

            #endregion

            #region Ternary
            //// ? :

            //// sert  ? True : False

            //string str = 15 < 13 ? "Dogrudur" : "Sehvdir";
            ////Console.WriteLine(str);

            #endregion

            #region Null-Coalescing
            //// ?? , ??=  : iki operatorda eger sol terefde yazilan deyisenin deyeri null-a beraberdise o zaman sag terefdeki deyisenin deyerin/deyeri geriye qaytarir.
            ////??= : bu operator sadece geriye deyer qaytarmir hemde sol terefdeki null deyere malik olan deyisenin deyerin sag terefde qeyd edilen deyere beraber edir.

            //int? num1 = null;

            //int? num2 = num1 ?? 45;

            //int? num3 = num1 ??= 45;
            ////Console.WriteLine(num3);
            #endregion

        }
    }
}
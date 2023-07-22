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

            #region verilen tam ededi 10-luq say sisteminden 2-lik say sistemine cevirmek ve eksine
            /* 8 
             * 
             *  8/2=4 (0)
             *  4/2=2 (0)
             *  2/2=1 (0)
             *  1/2 =0 (1)
             * 
             *  0000 1000
             *  
             *  0      0      0       0     1      0      0      0
             *  2**7   2**6   2**5    2**4  2**3   2**2   2**1   2**0
             *  
             *  
             *  0+0+0+0+8+0+0+0 = 8
             */

            /* 18
             * 
             * 18/2=9 (0)
             * 9/2=4 (1)
             * 4/2=2 (0)
             * 2/2=1 (0)
             * 1/2 =0 (1)
             * 
             * 
             *  0001 0010
             *  
             *  
             *  0       0      0      1      0       0      1      0
             *  2**7    2**6   2**5   2**4   2**3    2**2   2**1   2**0
             *  
             *  0+0+0+16+0+0+2+0 =18
             *  
             */

            #endregion

            //int number1 = 8;
            //int number2 = 18;

            //// & (Bitwise And) : verilen ededlerin 2-lik say sistemindeki uygun bitleri qarsilastir ve eger her ikisi 1 olarsa o zaman cavab uygun bite 1 qeyd edir,
            ////eks halda uygun bite 0 qeyd edir.

            //int number3 = 2 & number2; //8 & 18  = >0000 1000 & 0001 0010 = > 0000 0000 => 0

            ///*
            // * 0000 1000 (8)  1 - True
            // * 0001 0010 (18)   0 - False
            // * 
            // * 0000 0000 (0)
            // */

            ///* 0001 0010 (18)  1- True
            // * 0000 0010 (2)   0 - False
            // * 
            // * 0000 0010 (2)
            // */


            //// | (Bitwise Or) : verilen ededlerin 2-lik say sistemindeki uygun bitlerini qarsilastirir ve bitlerden en az biri 1 olarsa o zaman cavabda uygun bite 1 qeyd edir,
            ////eks halda uygun bite 0 qeyd edir

            //int number4 = number1 | number2;
            ///*
            // * 0000 1000 (8)   1-True
            // * 0001 0010 (18)  0-False
            // * 
            // * 0001 1010 (26)
            // *    16+  8 +  2 =26
            // */

            //// ^ (Bitwise Exclusive Or (XOR)) : verilen ededlerin 2-lik say sistemindeki uygun bitlerinden yanliz biri 1 olarsa o zaman cavabdaki uygun bitin yerine 1 qeyd edir,
            ////eks halda uygun bitin yerine 0 qeyd edir.

            //int number5 = 2 ^ number2;

            ///*
            // * 0000 1000 (8)   1- True
            // * 0001 0010 (18)  0-False
            // * 
            // * 0001 1010 (26)
            // * 
            // * 
            // * 0001 0010 (18)  1-True
            // * 0000 0010 (2)   0-False
            // * 
            // * 0001 0000 (16)
            // * 
            // */

            //// ~ (Bitwise Compliment) : bir deyisenle istifade olunur. Verilen deyisenin deyerinin 2-lik say sistemindeki
            //// bitlerini tam eksine cevirir( 0 -lar 1-e, 1-ler 0-a), istenilen N sayli ededin tamamlayicisini tapa bilmek ucun asagdaki qaydadan istifade ede bilersiz.
            ////-(N+1)
            //// N = ~(~N)
            //int number6 = ~number2;

            ///*
            // * 0001 0010 (18)
            // * 1110 1101 
            // * 0001 0010
            // * +       1
            // * -(0001 00011) = -19
            // */


            //// >> (Bitwise shift right) :operatonun sol terefinde qeyd edilen deyerin bitlerini operatorun sag terefinde gosterilen tam eded qeder saga surusdurur.

            //int number7 = number1 >> 4;
            ///*
            // * 0000 1000 (8)
            // * 
            // * 0000 0010 (2)
            // * 
            // * 0000 0000 (0)
            // */

            //// << (Bitwise shift left) : operatonun sol terefinde qeyd edilen deyerin bitlerini operatorun sag terefinde gosterilen tam eded qeder sola surusdurur

            //int number8 = number1 << 6;
            ///*
            // * 0000 1000 (8)
            // * 
            // * 0010 0000 (32)
            // */
            //Console.WriteLine(number8);

            #endregion

            #region Ternary
            //// ? :

            //// sert ? True : False

            //int num = 15 < 13 ? 15 : 13;

            //Console.WriteLine(num);
            #endregion

            #region Null-Coalescing
            ////?? ,??=  - Her iki operatorda yanliz nullable-type'larla istifade olunur. Her iki operatorda deyer qaytarir, eger verilen deyisen(sol terefdeki) null deyilse
            ////o zaman hemin deyisenin deyeri geri donderilir, eks halda diger value(sag terefdeki) geri donderilir.

            //// null deyer qebul eden data tipili (nullable-type) deyisen ?? value
            //// null deyer qebul eden data tipili (nullable-type) deyisen ??= value

            //int? num1 = null;

            //int? num2 = num1 ?? 45;

            //int num3 = num1 ??= 66;

            //Console.WriteLine("num2 :" + num2);
            //Console.WriteLine("num3 :" + num3);

            #endregion


        }
    }
}
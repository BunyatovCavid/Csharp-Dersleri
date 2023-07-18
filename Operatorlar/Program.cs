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
        }
    }
}
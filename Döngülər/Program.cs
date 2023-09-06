namespace Döngülər
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = 0;

            #region While
            //// While dongusu moterizeleri daxilinde sert qebul edir, eger sert true olarsa while dongusunun scope'lari daxilindeki kod ise dusur,
            ////eger sert false olarsasa o zaman while dongusu ise dusmur.

            ////while(number<100)
            ////{
            ////    Console.WriteLine(number);
            ////    number++;
            ////}

            #endregion

            #region Do While
            ////Do While dongusunun moterizeleri daxilinde sert qeyd olunur, sert true ve ya false olmasina baxmiyaraq do while
            ////dongusu bir defe ise dusur, daha sonra eger sert true olarsa dongu devam edir, eks halda yeni sert false olarsa
            ////o zaman compiler donguden cixir.


            ////do
            ////{
            ////    Console.WriteLine(number);
            ////    number++;
            ////} while (number>100);

            #endregion

            #region For
            ////For dongusunun moterizelerinin daxilinde 3 hisse olur
            ////1-ci hisse sadece for dongusunde istifade oluna bilecek deyisen teyin etmek
            ////2-ci hisse for dongusun sertini qeyd etmek
            ////3-cu hisse deyisenin increement ve ya decreement edilmesi ucundur.


            ////for(int i=0;i<100;i++)
            ////{
            ////    Console.WriteLine(i);
            ////}

            #endregion
            
            #region Foreach
           // //Foreach Kolleksiyalardan deyerleri goturmek ucun istifade olunur.
           // //Buna gorede foreach dongusunun moterizeleri daxiline sert qeyd olunmur, eger kolleksiyada goturule bilecek bir deyer 
           // //qalmiyibsa o zaman compiler foreach dongusununden cixir.


           // string[] datas = new string[] { "Cavid", "Bunyatov", "YouTube", "GitHub" };
           ////foreach(Tip ad in kolleksiya)
           // foreach(string item in datas)
           // {
           //     Console.WriteLine(item);
           // }

            #endregion

        }
    }
}
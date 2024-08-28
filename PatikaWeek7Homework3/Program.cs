using System.IO;

namespace PatikaWeek7Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Series> seriesList = new List<Series>() { } ;
          
            bool status=true;
            while (status)
            {

            seriesGo: Console.WriteLine("Yeni bir dizi oluşturmak için istiyor musunuz?(EVET/HAYIR)");

            string seriesStatus= (Console.ReadLine()).ToUpper();

                if (seriesStatus == "EVET")
                {
                   Series series = SeriesList();//Dönüş tipi Series olan Metot
                    seriesList.Add(series);
                }
                else if (seriesStatus == "HAYIR")
                {
                    status=false;
                }
                else 
                {
                    Console.WriteLine("Geçersiz giriş.");
                    goto seriesGo;
                }

            }




            //İlk listede bulunan komedi dizilerinden yeni bir liste oluşturuluyor..

            List<SeriesNew> seriesNews = seriesList.Where(s=>s.Genre.ToLower().Contains("komedi"))
                                                   .Select(s => new SeriesNew { SeriesName=s.SeriesName,Genre=s.Genre,Director=s.Director})
                                                   .ToList();

            //öncelikle dizi isimleri sonra da yönetmen isimleri baz alınarak sıralanmasınacak.. 
            var series1 = seriesNews.OrderBy(s => s.SeriesName).ThenBy(s =>s.Director).Select(s => s);

            foreach (var s in series1)
            {
                Console.WriteLine($"Dizi adı..:{s.SeriesName}     Dizi türü..:{s.Genre}     Dizi yönetmeni..:{s.Director}");
            }


        }
        static Series SeriesList()
        {
            Series series = new Series();

            Console.WriteLine("Dizinin Adı..:");
            series.SeriesName=Console.ReadLine();

            Console.WriteLine("Yapım Yılı..:");
            series.ProductionYear =int.Parse(Console.ReadLine());


            Console.WriteLine("Türü..:");
            series.Genre = Console.ReadLine();


            Console.WriteLine("Yayınlamaya Başlama Tarihi..:");
            series.StartedYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Yönetmen..:");
            series.Director = Console.ReadLine();

            Console.WriteLine("Yayınlandığı ilk Platform..:");
            series.FirstPlatform = Console.ReadLine();


            return series;
        }
    }
}

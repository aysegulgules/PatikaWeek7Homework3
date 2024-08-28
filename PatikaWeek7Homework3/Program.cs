using System.IO;

namespace PatikaWeek7Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Series> seriesList = new List<Series>()
             {
                new Series{SeriesName="Avrupa Yakası",ProductionYear=2004,Genre="Komedi",StartedYear=2004,Director="Yüksel Aksu",FirstPlatform="Kanal D" },
                new Series{SeriesName="Yalan Dünya",ProductionYear=2012,Genre="Komedi",StartedYear=2012,Director="Gülseren Buda Başkaya",FirstPlatform="Fox TV"},
                new Series{SeriesName="Jet Sosyete",ProductionYear=2018,Genre="Komedi",StartedYear=2018,Director="Gülseren Buda Başkaya",FirstPlatform="Kanal D"},
                new Series{SeriesName="Dadı",ProductionYear=2006,Genre="Komedi",StartedYear=2006,Director="Yusuf Pirhasan",FirstPlatform="Kanal D"},
                new Series{SeriesName="Belalı Baldız",ProductionYear=2007,Genre="Komedi",StartedYear=2007,Director="Yüksel Aksu",FirstPlatform="Kanal D"},
                new Series{SeriesName="Arka Sokaklar",ProductionYear=2004,Genre="Polisiye,Dram",StartedYear=2004,Director="Orhan Oğuz",FirstPlatform="Kanal D"},
                new Series{SeriesName="Aşk-ı Memnu",ProductionYear=2008,Genre="Dram, Romantik",StartedYear=2008,Director="Hilal Saral",FirstPlatform="Kanal D"},
                new Series{SeriesName="Muhteşem Yüzyıl",ProductionYear=2011,Genre="Tarihi, Dram",StartedYear=2011,Director="Mercan Çilingiroğlu",FirstPlatform="Kanal D"},
                new Series{SeriesName="Yaprak Dökümü ",ProductionYear=2006,Genre="Dram",StartedYear=2006,Director="Serdar Akar",FirstPlatform="Kanal D"}

             };


            //İlk listede bulunan komedi dizilerinden yeni bir liste oluşturuluyor..

            List<SeriesNew> seriesNews = seriesList.Where(s=>s.Genre.Contains("Komedi"))
                                                   .Select(s => new SeriesNew { SeriesName=s.SeriesName,Genre=s.Genre,Director=s.Director})
                                                   .ToList();

            //öncelikle dizi isimleri sonra da yönetmen isimleri baz alınarak sıralanmasınacak.. 
            var series1 = seriesNews.OrderBy(s => s.SeriesName).ThenBy(s =>s.Director).Select(s => s);

            foreach (var s in series1)
            {
                Console.WriteLine($"Dizi adı..:{s.SeriesName}     Dizi türü..:{s.Genre}     Dizi yönetmeni..:{s.Director}");
            }

            
            




        }
    }
}

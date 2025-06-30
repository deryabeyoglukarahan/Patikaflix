namespace Patikaflix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dizi> diziListesi = new List<Dizi>();
            string cevap;

            do
            {
                Dizi yeniDizi = new Dizi();

                Console.Write("Dizi Adı: ");
                yeniDizi.DiziAdi = Console.ReadLine();

                Console.Write("Türü: ");
                yeniDizi.Tur = Console.ReadLine();

                Console.Write("Yönetmen: ");
                yeniDizi.Yonetmen = Console.ReadLine();

                Console.Write("Sezon Sayısı: ");
                yeniDizi.SezonSayisi = int.Parse(Console.ReadLine());

                Console.Write("Yayın Yılı: ");
                yeniDizi.YayinYili = int.Parse(Console.ReadLine());

                diziListesi.Add(yeniDizi);

                Console.Write("Yeni bir dizi eklemek istiyor musunuz? (E/H): ");
                cevap = Console.ReadLine().ToUpper();
            }
            while (cevap == "E");

            // Komedi türündeki dizileri filtrele ve yeni liste oluştur
            List<KomediDizisi> komediListesi = diziListesi
                .Where(d => d.Tur.ToLower() == "komedi")
                .Select(d => new KomediDizisi
                {
                    DiziAdi = d.DiziAdi,
                    Tur = d.Tur,
                    Yonetmen = d.Yonetmen
                })
                .OrderBy(d => d.DiziAdi)
                .ThenBy(d => d.Yonetmen)
                .ToList();

            Console.WriteLine("\n--- KOMEDİ DİZİLERİ LİSTESİ ---");
            foreach (var dizi in komediListesi)
            {
                Console.WriteLine($"Dizi Adı: {dizi.DiziAdi} | Tür: {dizi.Tur} | Yönetmen: {dizi.Yonetmen}");
            }
        }
    }
}

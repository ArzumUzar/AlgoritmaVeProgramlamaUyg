namespace AlgoritmaVeProgramlamaUyg.ArzumUzar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Kaç öğrenci kaydetmek istiyorsunuz?:");
                int ogrencisayi = int.Parse(Console.ReadLine());
                Console.WriteLine();

                string[,] ogrencibilgileri = new string[ogrencisayi, 7];
                double toplamnot = 0;
                double endusuk = 101;
                double enyuksek = -1;

                for (int i = 0; i < ogrencisayi; i++)
                {
                    Console.Write($"{i + 1}.Öğrencinin numarasını giriniz:");
                    ulong numara = ulong.Parse(Console.ReadLine());
                    ogrencibilgileri[i, 0] = numara.ToString();

                    Console.Write($"{i + 1}.Öğrencinin adını giriniz:");
                    string ad = Console.ReadLine();
                    ogrencibilgileri[i, 1] = ad;

                    Console.Write($"{i + 1}.Öğrencinin soyadını giriniz:");
                    string soyad = Console.ReadLine();
                    ogrencibilgileri[i, 2] = soyad;

                    double vize, final, ortalama;

                    while (true)
                    {
                        Console.Write($"{i + 1}.Öğrencinin vize notunu giriniz:");
                        vize = double.Parse(Console.ReadLine());

                        if (vize >= 0 && vize <= 100)
                            break;
                        else
                            Console.WriteLine("Hatalı giriş! Lütfen 0 ile 100 arasında bir not girişi yapınız.");
                    }
                    ogrencibilgileri[i, 3] = vize.ToString();

                    while (true)
                    {
                        Console.Write($"{i + 1}.Öğrencinin final notunu giriniz:");
                        final = double.Parse(Console.ReadLine());

                        if (final >= 0 && final <= 100)
                            break;
                        else
                            Console.WriteLine("Hatalı giriş! Lütfen 0 ile 100 arasında bir not girişi yapınız.");
                    }
                    ogrencibilgileri[i, 4] = final.ToString();

                    ortalama = vize * 0.4 + final * 0.6;
                    ogrencibilgileri[i, 5] = ortalama.ToString();

                    toplamnot += ortalama;
                    if (ortalama > enyuksek)
                        enyuksek = ortalama;
                    if (ortalama < endusuk)
                        endusuk = ortalama;

                    string harfnotu;
                    if (ortalama >= 85)
                        harfnotu = "AA";
                    else if (ortalama >= 75)
                        harfnotu = "BA";
                    else if (ortalama >= 60)
                        harfnotu = "BB";
                    else if (ortalama >= 50)
                        harfnotu = "CB";
                    else if (ortalama >= 40)
                        harfnotu = "CC";
                    else if (ortalama >= 30)
                        harfnotu = "DC";
                    else if (ortalama >= 20)
                        harfnotu = "DD";
                    else if (ortalama >= 10)
                        harfnotu = "FD";
                    else
                        harfnotu = "FF";

                    ogrencibilgileri[i, 6] = harfnotu;
                    Console.WriteLine();
                }
                Console.WriteLine("{0,-15} {1,-20} {2,-20} {3,-10} {4,-10} {5,-10} {6,-10}", "Numara", "Ad", "Soyad", "Vize Notu", "Final Notu", "Ortalama", "Harf Notu");
                Console.WriteLine(new string('-', 100));

                for (int i = 0; i < ogrencisayi; i++)
                {
                    Console.WriteLine("{0,-15} {1,-20} {2,-20} {3,-10} {4,-10} {5,-10} {6,-10}", ogrencibilgileri[i, 0], ogrencibilgileri[i, 1], ogrencibilgileri[i, 2], ogrencibilgileri[i, 3], ogrencibilgileri[i, 4], ogrencibilgileri[i, 5], ogrencibilgileri[i, 6]);
                }

                double sınıfort = toplamnot / ogrencisayi;
                Console.WriteLine($"\nSınıf Ortalaması:{sınıfort}\nEn düşük not:{endusuk}\nEn yüksek not:{enyuksek}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş yaptınız. Lütfen giriş yaparken sayı giriniz.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmeyen bir hata oluştu..");
                Console.WriteLine($"Date:{DateTime.Now}\nMessage:{ex.Message}\nStack Trace:{ex.StackTrace}");
            }
            Console.ReadLine();
        }
    }
}
public class Araba
{
    // Public özellikler
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    
    // Private field - gerçek değeri saklar
    private int _kapiSayisi;
    
    // Public Property - Kapsülleme ile kontrol edilir
    public int KapiSayisi
    {
        get 
        { 
            return _kapiSayisi; 
        }
        set 
        { 
            if (value == 2 || value == 4)
            {
                _kapiSayisi = value;
            }
            else
            {
                Console.WriteLine("Uyarı: Kapı sayısı sadece 2 veya 4 olabilir! Değer -1 olarak atandı.");
                _kapiSayisi = -1;
            }
        }
    }
    
    // Constructor - Nesne oluşturulurken çalışır
    public Araba(string marka, string model, string renk, int kapiSayisi)
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapiSayisi = kapiSayisi; // Property kullanarak atama yapıyoruz
    }
    
    // Parametresiz constructor
    public Araba()
    {
        _kapiSayisi = -1; // Varsayılan değer
    }
    
    // Araba bilgilerini ekrana yazdıran method
    public void BilgileriGoster()
    {
        Console.WriteLine($"Marka: {Marka}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Renk: {Renk}");
        Console.WriteLine($"Kapı Sayısı: {KapiSayisi}");
        Console.WriteLine(new string('-', 25));
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Merhaba Dünya!");
    }
}
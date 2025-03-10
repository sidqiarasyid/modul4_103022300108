// See https://aka.ms/new-console-template for more information

class KodeProduk
{
    string[] produk= { "Laptop", "Smartphone", "Tablet", "Headset", "Keyboard", "Mouse", "Printer", "Monitor", "Smartwatch", "Kamera" };
    string[] kode= { "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109" };

    public string getKode(string nmProduk)
    {
        for (int i = 0; i < produk.Length; i++) { 
            if(produk[i] == nmProduk)
            {
                return kode[i];
            }
        }

        return "";
    }
}

class Run
{
    static void Main()
    {
        KodeProduk prod = new KodeProduk();
        Console.Write("Masukkan nama produk: ");
        string input = Console.ReadLine();
        string kode = prod.getKode(input);
        Console.WriteLine("Kode Produk: " + kode);
    }
}

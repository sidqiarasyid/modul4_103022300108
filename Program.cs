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

class FanLaptop
{
    enum State { QUIET, BALANCED, PERFORMANCE, TURBO };
    public void changeState()
    {
        State state = State.QUIET;
        Console.Write("Ganti power fan: ");
        string fanPower = Console.ReadLine();
        Console.WriteLine("");
        while (fanPower != "TURN OFF")
        {
            switch (state)
            {
                case State.QUIET:
                    if (fanPower == "BALANCED")
                    {
                        state = State.BALANCED;
                        Console.WriteLine("Fan Quiet berubah menjadi Balanced");
                    }
                    else if (fanPower == "PERFORMANCE")
                    {
                        state = State.PERFORMANCE;
                        Console.WriteLine("Fan Quiet berubah menjadi Performance");
                    }
                    else if (fanPower == "TURBO")
                    {
                        state = State.TURBO;
                        Console.WriteLine("Fan Quiet berubah menjadi Turbo");
                    }
                    break;
                case State.BALANCED:
                    if (fanPower == "QUIET")
                    {
                        state = State.QUIET;
                        Console.WriteLine("Fan Balanced berubah menjadi Quiet");
                    }
                    else if (fanPower == "PERFORMANCE")
                    {
                        state = State.PERFORMANCE;
                        Console.WriteLine("Fan Balanced berubah menjadi Performance");
                    }
                    else if (fanPower == "TURBO")
                    {
                        state = State.TURBO;
                        Console.WriteLine("Fan Balanced berubah menjadi Turbo");
                    }
                    break;
                case State.PERFORMANCE:
                    if (fanPower == "QUIET")
                    {
                        state = State.QUIET;
                        Console.WriteLine("Fan Performance berubah menjadi Quiet");
                    }
                    else if (fanPower == "BALANCED")
                    {
                        state = State.BALANCED;
                        Console.WriteLine("Fan Performance berubah menjadi Balanced");
                    }
                    else if (fanPower == "TURBO")
                    {
                        state = State.TURBO;
                        Console.WriteLine("Fan Performance berubah menjadi Turbo");
                    }
                    break;
                case State.TURBO:
                    if (fanPower == "QUIET")
                    {
                        state = State.QUIET;
                        Console.WriteLine("Fan Turbo berubah menjadi Quiet");
                    }
                    else if (fanPower == "BALANCED")
                    {
                        state = State.BALANCED;
                        Console.WriteLine("Fan Turbo berubah menjadi Balanced");
                    }
                    else if (fanPower == "PERFORMANCE")
                    {
                        state = State.PERFORMANCE;
                        Console.WriteLine("Fan Turbo berubah menjadi Performance");
                    }
                    break;

            }
            Console.Write("Ganti power fan: ");
            fanPower = Console.ReadLine();
            Console.WriteLine("");
        }
        Console.WriteLine("Fan Dimatikan..");
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

        FanLaptop fan = new FanLaptop();
        fan.changeState();
    }
}

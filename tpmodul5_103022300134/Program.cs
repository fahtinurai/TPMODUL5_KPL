using tpmodul5_103022300134;

class Program
{
    static void Main(string[] args)
    {
        // Membuat instance dari DataGeneric dengan tipe data string (gunakan NIM sebagai data)
        DataGeneric<string> dataGeneric = new DataGeneric<string>("103022300134");

        // Memanggil method PrintData untuk mencetak data
        dataGeneric.PrintData();

        Console.ReadLine(); // Agar console tidak langsung tertutup
    }
}


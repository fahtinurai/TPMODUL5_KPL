using tpmodul5_103022300134;

class Program
{
    static void Main(string[] args)
    {
        // Membuat instance dari HaloGeneric dengan tipe data string
        HaloGeneric<string> halo = new HaloGeneric<string>();

        // Memanggil method SapaUser dengan input nama user
        halo.SapaUser("Praktikan");

        Console.ReadLine();
    }
}

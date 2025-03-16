using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300134
{
    public class DataGeneric<T>
    {
        private T data;

        // Constructor untuk menginisialisasi data
        public DataGeneric(T data)
        {
            this.data = data;
        }

        // Method PrintData untuk mencetak nilai data
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }
    }

}

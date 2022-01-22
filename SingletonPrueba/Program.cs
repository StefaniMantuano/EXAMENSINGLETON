using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPrueba
{
    class Program
    { 
      static void Main(string[] args)
    {
            Console.WriteLine(Singleton.Instance.mensaje);
            Singleton.Instance.mensaje = "HOLA USUARIO";

            Console.WriteLine(Singleton.Instance.mensaje);


    }
}
}
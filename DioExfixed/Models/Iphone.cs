using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DioExfixed.Models;

    public class Iphone : Smartphone
    {


        public Iphone (string numero, string modelo, string imei, int memoria) 
        : base(numero, modelo, imei, memoria) { }
            // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
         Console.WriteLine("Recebendo ligação de ");
        }
    }

// See https://aka.ms/new-console-template for more information
using DioExfixed.Models;



Console.WriteLine("SmartFone Nokia");
Smartphone nokia = new Nokia(numero: "123", modelo: "modelo 1", imei: "212121212", memoria: 65);
nokia.Ligar();
nokia.InstalarAplicativo("app");

Console.WriteLine("\n");

Console.WriteLine("SmartFone Iphone");
Smartphone iphone = new Iphone(numero: "1313131313", modelo: "modelo xx1", imei: "111111", memoria: 11);
nokia.Ligar();
nokia.InstalarAplicativo("app");
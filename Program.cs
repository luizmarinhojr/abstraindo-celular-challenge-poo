using Desafio_de_Projeto_3.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: 988888888, modelo: "Nokia Experia 6", imei: "888888888", memoria: 6);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\nSmartphone iPhone");
Smartphone iphone = new Iphone(numero: 977777777, modelo: "Iphone 15 Pro Max", imei: "999999999", memoria: 8);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iPhone = new Iphone(numero: "4897", modelo: "modelo 2", imei: "222222222", memoria: 128);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Telegram");







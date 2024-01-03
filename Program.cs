using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero : "12313123", modelo : "Nokia 6100", imei : "11111111", memoria : 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero : "12321321", modelo :"Iphone XS MAX", imei : "111111111", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

// TODO: Realizar os testes com as classes Nokia e Iphone
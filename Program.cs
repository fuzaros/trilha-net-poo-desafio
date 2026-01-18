using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI123456", 16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI987654", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
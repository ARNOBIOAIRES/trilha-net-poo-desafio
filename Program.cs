using DesafioPOO.Models;


Nokia nokia = new Nokia("123456", "Modelo X", "IMEI123456", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();


Iphone iphone = new Iphone("654321", "Modelo Y", "IMEI654321", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();

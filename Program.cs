using Desafio_.NET_Developer___POO.Models;

Nokia nokia = new Nokia("123456789", "Lumia 1020", "359876421012345", 32);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Iphone iphone = new Iphone("987654321", "iPhone X", "012345678901234", 64);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Samsung samsung = new Samsung("543210987", "Galaxy S20", "543210987654321", 128);

samsung.Ligar();
samsung.ReceberLigacao();
samsung.InstalarAplicativo("Facebook");
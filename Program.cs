using DesafioPOO.Models;

Smartphone iphoneMatheus = new Iphone("999999", "Xs", "000000-00-000000-0", 8);
Smartphone nokiaGabi = new Nokia("88888888", "Aa", "000000-00-000000-1", 12);

nokiaGabi.Ligar();
iphoneMatheus.ReceberLigacao();

nokiaGabi.InstalarAplicativo("Whatsapp");
iphoneMatheus.InstalarAplicativo("Waze");
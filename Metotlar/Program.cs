
//Metotlar tekrar eden seyleri tek emirde yapmak icin
//Dont repeat yourself - DRY - Clean Code - Best Practise
//classlar benzer seyleri gruplamak icin

using Metotlar;

//urun1

Urun urun1 = new Urun();  //urun classimizdan bir urun tanimlattik bu urunun proplarini class icine girmistik .
urun1.Adi = "Elma";       //eger boyle yapmasak urunun proplarini tek tek yazsak bu diziyi olusturamazdik
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elmasi";

//urun2

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakir Karpuzu";



//array 
//artik bunlarla array yapabiliriz 
//string array yapabildigimiz gibi Urun array yapabiliriz. classimiz artik degisken gibi olur

Urun[] urunler = new Urun[] {urun1,urun2 };



//donguye sokalim

foreach (Urun urun in urunler)  //veri tipi Urun    var da yazabilirdik veri tipine  ,urun ise suan verdigimiz bir sey x de yazabilirdik
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama); 
    Console.WriteLine("------------------");
}

Console.WriteLine("---------------Metotlar---------------");

//class cagirirken napiyoduk onun bi ornegini yaziyoduk
//instance
//encapsulation

SepetManager sepetManager = new SepetManager(); //instance = ornek
sepetManager.Ekle(urun1); //sepetmanagerde urun istedik ama urun parametresini burda da vermemiz gerek hangi urun oldugunu
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "Yesil Armut", 12, 16);
sepetManager.Ekle2("Elma", "Yesil Elma", 14 ,17);
sepetManager.Ekle2("Karpuz", "Diyarbakir Karpuzu", 16,18);








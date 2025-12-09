// See https://aka.ms/new-console-template for more information

//Classlar
//CLASSLAR ICERISINDE BIRDEN FAZLA VERI TUTARIZ baska amaclar da var ama suan buna bakicaz



//main kismi
Kurs kurs1 = new Kurs(); //classlar boyle kullanilir kurs dedigskeni boyle tanimlanir. tipi kursdur
kurs1.KursAdi = "C#"; //sonra kurs1e Kurs classindaki degerleri tipine uygun sekilde tanimladik
kurs1.Egitmen = "Engin Demirog";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs(); //kurs2
kurs2.KursAdi = "Java"; 
kurs2.Egitmen = "Ahmet Hamdi";
kurs2.IzlenmeOrani = 100;

Kurs kurs3 = new Kurs(); //kurs3
kurs3.KursAdi = "C++";
kurs3.Egitmen = "Mauro Icardi";
kurs3.IzlenmeOrani = 99;

//Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 }; //dizi mantigi new int yazmadik cunku bunun tipi Kurs 

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " - Egitimci: " + kurs1.Egitmen + " - Izlenme Orani: " + kurs1.IzlenmeOrani);
}



//class kismi   
class Kurs  // hani int yas diyodukya simdi int degiskeni yerine kurs degiskenini kullanabiliriz Kurs kurs1 gibi
{
   public string KursAdi { get; set; }   //prop yazip tab yaptik kisayolu
   public string Egitmen { get; set; }
   public int IzlenmeOrani { get; set; }
}



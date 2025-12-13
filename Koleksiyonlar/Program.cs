using System.Collections.Generic;

//string[] isimler = new string[] { "Ahmet", "Hamdi", "Oguz","Patates" };
//Console.WriteLine(isimler[0]);
//Console.WriteLine(isimler[1]);
//Console.WriteLine(isimler[2]);
//Console.WriteLine(isimler[3]);
////isimler[4] = "Pat"; //boyle yapamazsin cunku arrayimiz 4 taneyle sinirliydi 5 yapamam
////Console.WriteLine(isimler[4]);
////o yuzden isimler = new string[5] deriz sonra Console.WriteLine(isimler[4]); deriz
////bu sefer de Console.WriteLine(isimler[0]); bunu tekrar yazdigimizda gorunmez
////cunku new dedigimiz anda bellekte yeni bi adres olusur 
////yani 4u atadik ama bu sefer de 0 1 2 3 atamadik
////yani 4 elemanli array tanimladigimizda onu artik 5 elemanli yapamiyoruz yaparsak eski elemanlari kaybediyoruz
////bu yuzden koleksiyonlar kullancaz c#da genelde array kullanmayiz
//ctrl k ctrl c komut satiri   geri almak istersen ctrl k ctrl u

List<string> isimler2 = new List<string> { "Ahmet", "Hamdi", "Oguz", "Patates" };
//isimler2.Add("Ahmet");
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);

isimler2.Add("Oguzan");
isimler2.Add("Furk");
isimler2.Add("Saido");
isimler2.Add("Eko");
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);


//c#da list diye bir sey olmasaydi kendi koleksiyonumuzu nasi yazardik
//list aslinda bi sinif
//<> generic eklenmis



// See https://aka.ms/new-console-template for more information
//donguler



for (int i = 1; i < 10; i++)
{
    Console.WriteLine(i); // 1 2 3 4 5 6 7 8 9 alt alta
}

Console.WriteLine();

for (int k = 1; k < 10; k+=2)
{
    Console.WriteLine(k); // 1 3 5 7 9 alt alta
}

Console.WriteLine();

//string bi deger versem 10 kere pespese yazsam donguyle gezmek zor olur
//mesela kurs1 kurs2 kurs3 gibi birsuru sey acmak yerine  dizileri kullaniriz
//array
//dizi kullanmasak hepsini console write ile tek tek yazcaktik dongu yapamicaktik

string[] kurslar = new string[] {"Yazilim gelistirici yetistirme kampi",   //normalde kurslariGetir(); deriz ve veri kaynagindan bu diziler gelir.
    "Programlamaya baslangic kampi",
    "Java Kampi"  };

for (int l = 0; l < kurslar.Length; l++)
{
    Console.WriteLine(kurslar[l]);
}

Console.WriteLine();

foreach (string kurs in kurslar) //foreachle de yapabiliriz dizileri tek tek doner 
    //kurslari tek tek dolas ve kursa ata
{
    Console.WriteLine(kurs);
}

Console.WriteLine();


Console.WriteLine("sayfa sonu - footer");



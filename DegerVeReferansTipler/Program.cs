int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
Console.WriteLine(sayi1); //cevap 30dur   
//int,decimal,float,double,bool   falan deger tipleridir.




int[] sayilar1 = new int[] { 10, 20, 30 };
int[] sayilar2 = new int[] { 100, 200, 300 };
sayilar1 = sayilar2;
sayilar2[0] = 999;
Console.Write(sayilar1[0]); //cevap 999dur
                            //array,class,interface ise referans tiplerdir.



//bellekde stack ve heap diye iki alan var

//deger tipler 
//stackde tanimlanir
//deger tipi olanlar stackde gerceklesir sayi1=10 dersen burda gerceklesir
//burda sayi1=10 dersek sayi1in degeri 10 diye okuruz
//sayi1=sayi2 yi sayi1 in degeri esittir sayi2 nin degeri diye okuruz.Sadece deger aktarilir.
//Sayi2 ile olan tum irtibatin burada kopar


//referans tipler
//int[] sayilar1 dediginde yine stacke kaydolur int[] sayilar1 = new int[]
//ancak new inti yazdiginda yani diziye dondurdugunde
//sayilar 1 icin heapde yeni bi alan olusturur ve degerleri oraya yazdirir
//yani heap kismina [10,20,30] yazar
//bu verilerimiz bi adresde tutuluyo ornegin 101. adreste tutsun bellegimiz
//stack kismi 101. adres sayilar1
//heap kismi 101. adres [10,20,30]

//sonra sayilar2 tanimladigimizda ve newledigimizde(diziye cevirdik) 102 adrese gitsin diyelim
//stack kismi 101. adres sayilar1       102. adres sayilar2
//heap kismi 101. adres [10,20,30]      102. adres [100, 200, 300] oldu

//sonra sayilar1=sayilar2 dedigimizde bu referans tipli sayilar oldugu icin
//sayilar1in refereansi esittir sayilar2nin referansina diye okumaliyiz

//yani artik sayilar1in referansi 102. adres oldu ve stackte 102. adresi tutmaya basladi 
//deger tiplerde degeri referans tiplerde referansi atamis olduk
//stack kismi 102. adres sayilar1       102. adres sayilar2
//heap kismi 101. adres [10,20,30]      102. adres [100, 200, 300] oldu

//sayilar2[0] = 999;   burda da diyorki sayilar2nin referans numarasinin 0. adresi 999 olsun
//orasi 999 olunca sayilar 1imiz de ordan referans aldigi icin sayilar1[0] da 999 olmus oldu

//heaptaki 101i stackde tutan kalmayinca garbage collector gelip bellekten [10,20,30] u atacak
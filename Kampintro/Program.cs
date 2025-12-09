// See https://aka.ms/new-console-template for more information

//type safety
//do not repeat yourself
//deger tutucu,alias(takma ad)

string kategoriEtiketi = "Kategori";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = false; //burasi veri kaynagindan gelecek
double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun > dolarBugun)
{
    Console.WriteLine("Azalis butonu");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Artis butonu");
}
else
{
    Console.WriteLine("Degismedi Butonu");
}


if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanici ayarlari butonu /Kullanici sisteme giris yapmis.");
    //normalde giris yaptiysa buraya
    //button falan koyariz giris yapan kisinin gorebilecegi seyler icin
}
else
{
    Console.WriteLine("Giris yap butonu");
}

Console.WriteLine(kategoriEtiketi);

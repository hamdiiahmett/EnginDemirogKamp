//c#da list diye bir sey olmasaydi kendi koleksiyonumuzu nasi yazardik
//list aslinda bi sinif
//<> generic eklenmis


using GenericsIntro;

MyList<string> isimler = new MyList<string>();  
isimler.Add("Ahmet");

Console.WriteLine(isimler.Length);


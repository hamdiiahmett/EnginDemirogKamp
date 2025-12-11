using OOP1;

Product product1 = new Product();//product olusturduk 
product1.Id = 1;
product1.CategoryId = 2; //2. kategori mobilyaymis gibi dusunelim
product1.ProductName = "Masa"; //tbxProductName.Text; diyip kullanicinin girdigi degeri alicaz ilerde
product1.UnitPrice = 500;
product1.UnitsInStock = 3;


Product product2 = new Product //{}    
{ 
    Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice=35
};


ProductManager productManager = new ProductManager(); 
productManager.Add(product1); 
Console.WriteLine(product1.ProductName);


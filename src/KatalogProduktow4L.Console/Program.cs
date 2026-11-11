using KatalogProduktow4L.Core;

var produkty = new List<Produkt>
{
    new() { Nazwa = "Produkt1", Cena = 10.0, Kategoria = "Kategoria1", Ilosc = 5 },
    new() { Nazwa = "Produkt2", Cena = 20.0, Kategoria = "Kategoria2", Ilosc = 3 },
    new() { Nazwa = "Produkt3", Cena = 15.0, Kategoria = "Kategoria1", Ilosc = 8 },
    new() { Nazwa = "Produkt4", Cena = 30.0, Kategoria = "Kategoria3", Ilosc = 2 },
    new() { Nazwa = "Produkt5", Cena = 25.0, Kategoria = "Kategoria2", Ilosc = 6 }
};

var produktyWKategoriach = produkty
    .GroupBy(p => p.Kategoria)
    .ToDictionary(g => g.Key, g => g.ToList());

Console.WriteLine("Produkty w kategorii 'Kategoria1':");
foreach (var produkt in produktyWKategoriach["Kategoria1"])
{
    Console.WriteLine($"- {produkt.Nazwa} ({produkt.Cena} zł)");
}

Console.WriteLine("\nWszystkie produkty:");
foreach (var produkt in produkty)
{
    Console.WriteLine(produkt.ToString());
}

Console.WriteLine("\nProdukty o cenie mniejszej niż 20:");
foreach (var produkt in produkty.Where(p => p.Cena < 20))
{
    Console.WriteLine(produkt.Nazwa);
}

Console.WriteLine("\nProdukty posortowane według ceny:");
foreach (var produkt in produkty.OrderBy(p => p.Cena))
{
    Console.WriteLine(produkt.Nazwa);
}

Console.WriteLine("\nSprawdzanie wartości magazynu:");
Produkt.SprawdzWartosc(produkty[0]);

Console.WriteLine("\nSprawdzanie cen:");
Produkt.SprawdzCeny(produkty);
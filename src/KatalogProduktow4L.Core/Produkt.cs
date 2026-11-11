namespace KatalogProduktow4L.Core;

public class Produkt
{
    public string Nazwa { get; set; } = string.Empty;
    public double Cena { get; set; }
    public string Kategoria { get; set; } = string.Empty;
    public int Ilosc { get; set; }

    public double WartoscMagazynu => Cena * Ilosc;

    public static void SprawdzWartosc(Produkt p)
    {
        if (p.WartoscMagazynu == p.Cena * p.Ilosc)
        {
            Console.WriteLine("Wartość magazynu jest poprawna.");
        }
        else
        {
            Console.WriteLine("Wartość magazynu jest niepoprawna.");
        }
    }

    public static void SprawdzCeny(List<Produkt> produkty)
    {
        foreach (var produkt in produkty)
        {
            if (produkt.Cena < 0)
            {
                Console.WriteLine($"Produkt {produkt.Nazwa} ma niepoprawną cenę: {produkt.Cena}");
            }
        }
    }

    public override string ToString()
    {
        return $"Nazwa: {Nazwa}, Cena: {Cena}, Kategoria: {Kategoria}, Ilość: {Ilosc}, Wartość magazynu: {WartoscMagazynu}";
    }

    public virtual string Opis()
    {
        return "Tu jest opis produktu";
    }
}
namespace KatalogProduktow4L.Core;

/// <summary>
/// Klasa podzespol ma dziedziczyc z klasy Produkt i reprezentuje jakąś fizyczną część na magazynie.
/// </summary>
public class Podzespol : Produkt
{
    public string Producent { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Nazwa: {Nazwa}, Cena: {Cena}, Kategoria: {Kategoria}, Ilość: {Ilosc}, Wartość magazynu: {WartoscMagazynu}, Producent: {Producent}";
    }

    public new string Opis()
    {
        return "Tu jest opis podzespolu dla podzespolu";
    }
}
namespace Zwierzaki;

public static class Database
{
    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal() { id = 1, imie = "asd", kategoria = "pies", masa = 10, kolorSiersci = "siwy" },
        new Animal() { id = 2, imie = "kit", kategoria = "kot", masa = 4, kolorSiersci = "brązowy" },
        new Animal() { id = 3, imie = "kwas", kategoria = "mysz", masa = 1, kolorSiersci = "biała" },
        new Animal() { id = 4, imie = "rom", kategoria = "koń", masa = 145, kolorSiersci = "czarny" },
        new Animal() { id = 5, imie = "rom", kategoria = "pies", masa = 20, kolorSiersci = "biały" },
        new Animal() { id = 6, imie = "rom", kategoria = "kot", masa = 5, kolorSiersci = "szary" },
        new Animal() { id = 7, imie = "rom", kategoria = "mysz", masa = 1, kolorSiersci = "czarny" },
        new Animal() { id = 8, imie = "rom", kategoria = "koń", masa = 150, kolorSiersci = "brązowy" },
        new Animal() { id = 9, imie = "rom", kategoria = "ptak", masa = 2, kolorSiersci = "żółty" }
    };
    
    public static List<Wizyta> Wizytas = new List<Wizyta>()
    {
        new Wizyta() { cena = 100, animalId = 1, data = new DateTime(2023, 10, 1), opis = "Szczepienie" },
        new Wizyta() { cena = 150, animalId = 1, data = new DateTime(2023, 10, 15), opis = "Badanie kontrolne" },
        new Wizyta() { cena = 120, animalId = 1, data = new DateTime(2023, 10, 20), opis = "Szczepienie przeciwko wściekliźnie" },
        new Wizyta() { cena = 180, animalId = 1, data = new DateTime(2023, 10, 25), opis = "Czyszczenie zębów" },
        new Wizyta() { cena = 200, animalId = 1, data = new DateTime(2023, 10, 30), opis = "RTG łapy" },
        new Wizyta() { cena = 250, animalId = 1, data = new DateTime(2023, 11, 5), opis = "Operacja usunięcia guza" },
        new Wizyta() { cena = 200, animalId = 2, data = new DateTime(2023, 10, 5), opis = "Kontrola zdrowia" },
        new Wizyta() { cena = 300, animalId = 3, data = new DateTime(2023, 10, 10), opis = "Odrobaczanie" }
    };
    
}
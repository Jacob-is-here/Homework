namespace Zwierzaki;

public class Animal
{
    public int id { get; set; }
    public string imie { get; set; }
    public string kategoria { get; set; }
    public int masa { get; set; }
    public string kolorSiersci { get; set; }
    public List<Wizyta> wizyty {get; set; }
}
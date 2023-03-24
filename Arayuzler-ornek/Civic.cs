namespace Arayuzler_ornek;

public class Civic:IOtomobil
{
    public int KacTekerlektenOlusur()
    {
        return 4;
    }

    public Marka HagniMarkanınAraci()
    {
        return Marka.Honda;
    }

    public Renk StandartRengiNe()
    {
        return Renk.Gri;
    }
}
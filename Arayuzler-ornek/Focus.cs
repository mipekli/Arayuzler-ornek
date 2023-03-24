namespace Arayuzler_ornek;

public class Focus:IOtomobil
{
    public int KacTekerlektenOlusur()
    {
        return 4;
    }

    public Marka HagniMarkanınAraci()
    {
        return Marka.Ford;
    }

    public Renk StandartRengiNe()
    {
        return Renk.Beyaz;
    }
}
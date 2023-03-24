namespace Arayuzler_ornek;

public class NewCivic:Otomobil
{
    public override Marka HagniMarkanınAraci()
    {
        return Marka.Honda;

    }

    public override Renk StandartRengiNe()
    {
        return base.StandartRengiNe();
    }
}
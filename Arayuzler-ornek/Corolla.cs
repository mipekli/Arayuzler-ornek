﻿namespace Arayuzler_ornek;

public class Corolla:IOtomobil
{
    public int KacTekerlektenOlusur()
    {
        return 4;
    }

    public Marka HagniMarkanınAraci()
    {
        return Marka.Toyota;
    }

    public Renk StandartRengiNe()
    {
        return Renk.Beyaz;
    }
}
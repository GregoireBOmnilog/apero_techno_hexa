namespace Domain;

public interface IPrévisionCouvertsPetitDéj
{
    public int PrévoirNombreCouverts();
}

public class PrévisionCouvertsPetitDéj
    : IPrévisionCouvertsPetitDéj
{
    public int PrévoirNombreCouverts()
    {
        throw new NotImplementedException();
    }
}

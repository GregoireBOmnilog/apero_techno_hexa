
namespace Domain;

public interface IPrévisionCouvertsPetitDéj
{
    public int PrévoirNombreCouverts();
}

public class PrévisionCouvertsPetitDéj(ICommandesDePetitsDéjs commandes)
    : IPrévisionCouvertsPetitDéj
{
    public int PrévoirNombreCouverts()
    {
        return commandes.CommandésAujourdhui() + prévoirMarge(commandes.CommandésHier(), commandes.ServisHier());
    }

    private int prévoirMarge(int commandésHier, int servisHier)
    {
        throw new NotImplementedException();
    }
}

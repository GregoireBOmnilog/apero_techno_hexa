namespace Domain;

public interface ICommandesDePetitsDéjs
{
    public int CommandésHier();
    public int ServisHier();
    public int CommandésAujourdhui();
}

public class CommandesDePetitsDéjs : ICommandesDePetitsDéjs
{
    public int CommandésAujourdhui()
    {
        throw new NotImplementedException();
    }

    public int CommandésHier()
    {
        throw new NotImplementedException();
    }

    public int ServisHier()
    {
        throw new NotImplementedException();
    }
}


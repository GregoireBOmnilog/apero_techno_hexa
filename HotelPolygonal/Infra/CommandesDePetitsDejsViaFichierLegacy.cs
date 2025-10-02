using Domain;
using System;

namespace Infra;

public class CommandesDePetitsDéjsViaFichierLegacy(IFichierLegacyRepository repository)
    : ICommandesDePetitsDéjs
{
    public int CommandésAujourdhui() => repository.CommandesDuJour().Sum(dto => dto.commandés);

    public int CommandésHier() => repository.CommandesDeLaVeille().Sum(dto => dto.commandés);

    public int ServisHier() => repository.CommandesDeLaVeille().Sum(dto => dto.servis);
}

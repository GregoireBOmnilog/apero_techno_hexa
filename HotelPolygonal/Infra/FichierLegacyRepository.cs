using Infra.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public interface IFichierLegacyRepository
    {
        public PetitsDejsChambreDto[] CommandesDeLaVeille();
        public PetitsDejsChambreDto[] CommandesDuJour();
    }
    public class FichierLegacyRepository
    {
    }
}

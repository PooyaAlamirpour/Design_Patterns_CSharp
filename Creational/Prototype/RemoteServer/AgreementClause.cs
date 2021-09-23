using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.RemoteServer
{
    public class AgreementClause
    {
        public AgreementDto GetAgreementClause()
        {
            AgreementDto agreementDto = new AgreementDto();

            agreementDto.DeveloperClasuse = "Developer activity should be completed as per miteston.";
            agreementDto.PostDeliveryClause = "Post delivery support of one year should be given.";
            agreementDto.ProjectTerminaationClause = "Client may terminate the agreement at any point of time.";

            return agreementDto;
        }
    }
}

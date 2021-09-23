using Prototype.RemoteServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prototype
{
    public class SoftwareAgreement : IAgreement
    {
        private string _vendorName;
        private AgreementDto _agreementDto;
        public NonDisclosureAgreement NonDisclosureAgreement;

        public SoftwareAgreement(string vendorName, NonDisclosureAgreement nonDisclosureAgreement)
        {
            this._vendorName = vendorName;
            this.NonDisclosureAgreement = nonDisclosureAgreement;

            Console.WriteLine("The agreement is downloading from the server...");
            Thread.Sleep(4000);
            Console.Clear();

            AgreementClause clause = new AgreementClause();
            _agreementDto = clause.GetAgreementClause();
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{new string('-', 20)} Agreement Prototype {new string('-', 20)}");
            Console.ResetColor();

            Console.WriteLine($"Vendor name:                    {_vendorName}");
            Console.WriteLine($"NDA ID:                         {NonDisclosureAgreement.Id}");
            Console.WriteLine($"Developer Clasuse:              {_agreementDto.DeveloperClasuse}");
            Console.WriteLine($"Post Delivery Clause:           {_agreementDto.PostDeliveryClause}");
            Console.WriteLine($"Project Terminaation Clause:    {_agreementDto.ProjectTerminaationClause}");
        }

        public IAgreement ShallowCopy()
        {
            return (IAgreement)this.MemberwiseClone();
        }

        public IAgreement DeepCopy()
        {
            var agreementCopy = (SoftwareAgreement)this.MemberwiseClone();
            agreementCopy.NonDisclosureAgreement = new NonDisclosureAgreement
            {
                Id = this.NonDisclosureAgreement.Id,
                NDAAgreementName = this.NonDisclosureAgreement.NDAAgreementName
            };

            return agreementCopy;
        }
    }
}

using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftwareAgreement agreement = new SoftwareAgreement("ABC", new NonDisclosureAgreement() {
                Id = 123,
                NDAAgreementName = "Source Code"
            });
            agreement.Print();

            //var cloneAgreement = (SoftwareAgreement)agreement.ShallowCopy();
            var cloneAgreement = (SoftwareAgreement)agreement.DeepCopy();
            cloneAgreement.Print();

            cloneAgreement.NonDisclosureAgreement.Id = 555;
            cloneAgreement.Print();

            agreement.Print();
        }
    }
}

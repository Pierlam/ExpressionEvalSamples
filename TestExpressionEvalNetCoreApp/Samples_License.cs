using Pierlam.ExpressionEval;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExpressionEvalNetCoreApp
{
    /// <summary>
    /// Code Samples concerning license: get info, manage errors,...
    /// </summary>
    public class Samples_License
    {
        public static void CheckDefaultTrialLicense()
        {
            Console.WriteLine("\n====Check the default trial license: " );

            ExpressionEval evaluator = new ExpressionEval();

            // get the licence type: trial or commercial
            LicenseInfoType licType = evaluator.License.GetLicenseType();
            Console.WriteLine("license type: " + licType.ToString());

            // last day validity of the licence
            DateTime lastDayValidLicence = evaluator.License.GetLastDayLicenseValid();
            Console.WriteLine("lastDayValidLicence: " + lastDayValidLicence.ToShortDateString());

            // is the current licence valid?
            bool isLicenceValid = evaluator.License.IsValid();
            Console.WriteLine("Is licence valid? " + isLicenceValid.ToString());

            ParseResult parseResult = evaluator.Parse("a=b");
            Console.WriteLine("error occurs (due to a license problem)? " + parseResult.HasError);
        }

        public static void SetCommercialLicence_IsNOTValid_OutOfDate()
        {
            Console.WriteLine("\n====Set an Out of date license: ");
            ExpressionEval evaluator = new ExpressionEval();

            // the generated encrypted licence info
            string encryptedLicence = "P2OAd87qJOBDKit09Z5EM89kul1WmlGNXAkTseJdV8le+h9bmZHB6MC5fisGqFXoqmRlqvYxJeF3bDHhmm/4cMV11/xqqgWeGcBLnozWyEoxsbJRaWdTOkxldifspwEyyhYeLw75zgc=";

            LicenseInfoStatus res = evaluator.License.SetLicenseInfo(encryptedLicence);
            Console.WriteLine("LicenseInfoStatus (should be ErrorOutOfDate): " + res.ToString());

            // is the current licence valid?  
            bool isLicenceValid = evaluator.License.IsValid();
            Console.WriteLine("Is licence valid (should be false)? " + isLicenceValid.ToString());


            // parse an expression, should finish with success
            ParseResult parseResult = evaluator.Parse("a=b");

            // should finish with ERROR
            Console.WriteLine("error occurs (due to a license problem) (should be true)? " + parseResult.HasError);

            Console.WriteLine("error code (should be LicenceInvalid): " + parseResult.ListError[0].Code.ToString());
        }

    }
}

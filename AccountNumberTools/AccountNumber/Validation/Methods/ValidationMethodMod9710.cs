﻿//
//   Project:           AccountNumberTools - Tools for the work with account numbers
//   Project:           $URL$
//   Id:                $Id$
//
//   Copyright © 2011 Michael Jahn
//
//   This Software is weak copyleft open source. Please read the License.txt for details.
//

using AccountNumberTools.AccountNumber.Validation.Contracts;
using AccountNumberTools.Common.Internals;

namespace AccountNumberTools.AccountNumber.Validation.Methods
{
   /// <summary>
   /// class which calculates check digits with a mod 97 algorithm (ISO 7064)
   /// </summary>
   public class ValidationMethodMod9710 : IValidationMethod
   {
#if SILVERLIGHT
      private static readonly DanielVaughan.Logging.ILog Log = DanielVaughan.Logging.LogManager.GetLog(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
#else
      private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
#endif

      /// <summary>
      /// Determines whether the specified account number is valid.
      /// </summary>
      /// <param name="accountNumber">The account number.</param>
      /// <returns>
      ///   <c>true</c> if the specified account number is valid; otherwise, <c>false</c>.
      /// </returns>
      virtual public bool IsValid(string accountNumber)
      {
         string number;
         string checkdigit;

         ValidationMethodsTools.SplitNumber(accountNumber, 2, out number, out checkdigit);

         var calculatedCheckDigit = (98 - ValidationMethodsTools.CalculateModulo(number + "00", 97)).ToString("00");

         Log.InfoFormat("Validate {0} against check digits {1}, calculated check digits {2}", number, checkdigit, calculatedCheckDigit);

         return calculatedCheckDigit.Equals(checkdigit);
      }

      /// <summary>
      /// Calculates the check digit for a given account number.
      /// </summary>
      /// <param name="accountNumber">The account number.</param>
      /// <returns></returns>
      virtual public string CalculateCheckDigit(string accountNumber)
      {
         var calculatedCheckDigit = (98 - ValidationMethodsTools.CalculateModulo(accountNumber + "00", 97)).ToString();

         Log.InfoFormat("Check digits for number {0} are {1}", accountNumber, calculatedCheckDigit);

         return calculatedCheckDigit;
      }
   }
}

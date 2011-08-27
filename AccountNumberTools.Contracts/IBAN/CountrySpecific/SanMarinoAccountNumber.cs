﻿//
//   Project:           AccountNumberTools - Tools for the work with account numbers
//   Project:           $URL$
//   Id:                $Id$
//
//   Copyright © 2011 Michael Jahn
//
//   This Software is weak copyleft open source. Please read the License.txt for details.
//

namespace AccountNumberTools.IBAN.Contracts.CountrySpecific
{
   /// <summary>
   /// represents a national account number of SanMarino
   /// </summary>
   public class SanMarinoAccountNumber : AccountBankCodeAndBranchNumber
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="SanMarinoAccountNumber"/> class.
      /// </summary>
      public SanMarinoAccountNumber()
         : base(Country.SanMarino)
      {
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="SanMarinoAccountNumber"/> class.
      /// </summary>
      /// <param name="other">The other.</param>
      public SanMarinoAccountNumber(NationalAccountNumber other)
         : base(other, Country.SanMarino)
      {
      }
   }
}

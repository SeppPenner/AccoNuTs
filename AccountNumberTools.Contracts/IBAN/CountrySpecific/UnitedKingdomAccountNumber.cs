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
   /// represents a national account number of United Kingdom
   /// </summary>
   public class UnitedKingdomAccountNumber : AccountBICAndBranchNumber
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="UnitedKingdomAccountNumber"/> class.
      /// </summary>
      public UnitedKingdomAccountNumber()
         : base(Country.UnitedKingdom)
      {
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="UnitedKingdomAccountNumber"/> class.
      /// </summary>
      /// <param name="other">The other.</param>
      public UnitedKingdomAccountNumber(NationalAccountNumber other)
         : base(other, Country.UnitedKingdom)
      {
      }
   }
}

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
   /// represents a national account number of Kuwait
   /// </summary>
   public class KuwaitAccountNumber : AccountAndBankCodeNumber
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="KuwaitAccountNumber"/> class.
      /// </summary>
      public KuwaitAccountNumber()
         : base(Country.Kuwait)
      {
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="KuwaitAccountNumber"/> class.
      /// </summary>
      /// <param name="other">The other.</param>
      public KuwaitAccountNumber(NationalAccountNumber other)
         : base(other, Country.Kuwait)
      {
      }
   }
}

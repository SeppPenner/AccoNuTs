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
   /// represents a national account number of Monaco
   /// </summary>
   public class MonacoAccountNumber : AccountBankCodeAndBranchNumber
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="MonacoAccountNumber"/> class.
      /// </summary>
      public MonacoAccountNumber()
         : base(Country.Monaco)
      {
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="MonacoAccountNumber"/> class.
      /// </summary>
      /// <param name="other">The other.</param>
      public MonacoAccountNumber(NationalAccountNumber other)
         : base(other, Country.Monaco)
      {
      }
   }
}

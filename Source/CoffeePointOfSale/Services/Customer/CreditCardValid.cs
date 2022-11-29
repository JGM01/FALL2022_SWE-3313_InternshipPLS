using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CoffeePointOfSale.Services.Customer;

internal class CreditCardValid
{

    // Returns true if given
    // card number is valid
    static bool checkLuhn(String cardNo)
    {
        int nDigits = cardNo.Length;

        int nSum = 0;
        bool isSecond = false;
        for (int i = nDigits - 1; i >= 0; i--)
        {

            int d = cardNo[i] - '0';

            if (isSecond == true)
                d = d * 2;

            // We add two digits to handle
            // cases that make two digits
            // after doubling
            nSum += d / 10;
            nSum += d % 10;

            isSecond = !isSecond;
        }
        return (nSum % 10 == 0);
    }

    // Driver code
}

// This Code is contributed by vt_m.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACES__Solution_With_Interface.Services
{
    internal class BrazilTaxService : ITaxService
    {

        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }

    }
}

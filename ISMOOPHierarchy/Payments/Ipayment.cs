using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    interface Ipayment
    {
        bool PaySucceful(double orderSum);
        bool ListingMoney(double listingSum);
        bool LockPayment(bool Lock);
        bool CancellPayment(bool Cancell);
        double Score { get; set; }
        
    }
}

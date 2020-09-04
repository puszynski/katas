

using System.Collections.Generic;
using System.Linq;

namespace Katas.Linq
{
    public class SkipTake
    {
        IQueryable<Installment> _installments;

        public SkipTake()
        {            
            var installments = new List<Installment>()
            {
                new Installment(){ ID = 1, ClubID = 45, AgreementID = 11, SaleCategory = 214, NetPrice = 1000 },
                new Installment(){ ID = 2, ClubID = 45, AgreementID = 11, SaleCategory = 214, NetPrice = 100 },
                new Installment(){ ID = 3, ClubID = 45, AgreementID = 22, SaleCategory = 214, NetPrice = 10 },
                new Installment(){ ID = 4, ClubID = 45, AgreementID = 22, SaleCategory = 214, NetPrice = 1 },

                new Installment(){ ID = 5, ClubID = 45, AgreementID = 33, SaleCategory = 214, NetPrice = 2000 },
                new Installment(){ ID = 6, ClubID = 45, AgreementID = 33, SaleCategory = 214, NetPrice = 200 },
                new Installment(){ ID = 7, ClubID = 45, AgreementID = 44, SaleCategory = 214, NetPrice = 20 },
                new Installment(){ ID = 8, ClubID = 45, AgreementID = 44, SaleCategory = 214, NetPrice = 2 },

                new Installment(){ ID = 11, ClubID = 46, AgreementID = 11, SaleCategory = 214, NetPrice = 5000 },
                new Installment(){ ID = 12, ClubID = 46, AgreementID = 11, SaleCategory = 214, NetPrice = 500 },
                new Installment(){ ID = 13, ClubID = 46, AgreementID = 22, SaleCategory = 214, NetPrice = 50 },
                new Installment(){ ID = 14, ClubID = 46, AgreementID = 22, SaleCategory = 214, NetPrice = 5 },

                new Installment(){ ID = 15, ClubID = 46, AgreementID = 33, SaleCategory = 214, NetPrice = 5000 },
                new Installment(){ ID = 16, ClubID = 46, AgreementID = 33, SaleCategory = 214, NetPrice = 500 },
                new Installment(){ ID = 17, ClubID = 46, AgreementID = 44, SaleCategory = 214, NetPrice = 50 },
                new Installment(){ ID = 18, ClubID = 46, AgreementID = 44, SaleCategory = 214, NetPrice = 5 },

                new Installment(){ ID = 25, ClubID = 46, AgreementID = 77, SaleCategory = 214, NetPrice = 5000 },
                new Installment(){ ID = 26, ClubID = 46, AgreementID = 77, SaleCategory = 214, NetPrice = 500 },
                new Installment(){ ID = 27, ClubID = 46, AgreementID = 88, SaleCategory = 214, NetPrice = 50 },
                new Installment(){ ID = 28, ClubID = 46, AgreementID = 99, SaleCategory = 214, NetPrice = 5 }
            };
            
            _installments = installments.AsQueryable();
        }

        // public void Test()
        // {
        //     var result = _installments.Take(x => x.AgreementID > 2).Skip(x => x.NetPrice > 100);
        // }
    }
}
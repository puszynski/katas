using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.Linq
{
    public class GroupAndCount
    {
        List<Installment> _installments;

        public GroupAndCount()
        {
            _installments = new List<Installment>()
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
        }

        public void GetData()
        {
            var dataAll = _installments;

            var group = dataAll
                .GroupBy(x => new { x.ClubID, x.SaleCategory, x.AgreementID })
                .Select(x => new ModelDTO()
                {
                    ClubID = x.Key.ClubID,
                    SaleCategoryID = x.Key.SaleCategory,
                    Count = x.Count(),
                    NetPrice = x.Sum(x => x.NetPrice),
                    AgreementID = x.Key.AgreementID //++
                });

            var result = new List<ExcelModel>();

            foreach (var club in new List<int>{ 45 })
            {
                foreach (var category in new List<int> { 214 })
                {
                    //wiersz per kategoria
                    result.Add(new ExcelModel()
                    {
                        AgreementCount = group
                            .Where(x => x.ClubID == club)
                            .Where(x => x.SaleCategoryID == category)
                            .GroupBy(x => x.AgreementID).Count(),

                        NetPrice = group
                            .Where(x => x.ClubID == club)
                            .Where(x => x.SaleCategoryID == category)
                            .Sum(x => x.NetPrice)
                    });
                }

                //suma
                result.Add(new ExcelModel()
                {
                    AgreementCount = dataAll.GroupBy(x => x.AgreementID).Count(),
                    NetPrice = dataAll.Sum(x => x.NetPrice)
                }) ;
            }
                
        }
    }

    internal class Installment
    {
        public int ID { get; set; }
        public int ClubID { get; set; }
        public int AgreementID { get; set; }
        public DateTime ReportFrom { get; set; }
        public DateTime ReportTo { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public decimal NetPrice { get; set; }
        public int SaleCategory { get; set; }
    }

    internal class ModelDTO
    {
        public int ClubID { get; set; }
        public int SaleCategoryID { get; set; }
        public int Count { get; set; }
        public decimal NetPrice { get; set; }
        public int AgreementID { get; set; } //++
    }

    internal class ExcelModel
    {
        public int AgreementCount { get; set; }
        public decimal NetPrice { get; set; }
    }
}

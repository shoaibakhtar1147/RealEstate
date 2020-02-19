using RealStateManagment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateManagment.BL
{
    class SaleBL
    {
        public int  SaleId	{get;set;}
        public string ContractNo{get;set;}
         public int  ColonyId{get;set;}
        public int  PlotId{get;set;}
        public string SaleStatus{get;set;}
        public DateTime SaleDate{get;set;}
         public int  NoOfMonth{get;set;}
          public decimal MonthlyPayment{get;set;}
          public int DateOfPay { get; set; }
          public int ClientId { get; set; }
          public string Cnic { get; set; }
          public decimal DownPayment { get; set; }
          public decimal Balance { get; set; }
          public decimal CashPayment { get; set; }
          public decimal Remaining { get; set; }


        public void Save()
          {
            using(var context=new RealEstateEntities())
            {
                Tbl_SaleCash obj = new Tbl_SaleCash() 
              {
               ContractNo=ContractNo,
               ColonyId=ColonyId, 
               PlotId=PlotId,
               SaleStatus=SaleStatus,
               SaleDate=SaleDate,
                ClientId=ClientId,
               CashPayment=CashPayment,
                Remaining=Remaining
              };
                context.Tbl_SaleCash.Add(obj);
                context.SaveChanges();
            }
              
          }

       
        public List<View_SaleCash> Search()
        {
            using(var context=new RealEstateEntities())
            {
                return context.View_SaleCash.Where(a => a.Cnic == Cnic || ContractNo == ContractNo).ToList();
            }
        }

        public List<View_SaleCash> Select()
        {
            using(var context=new RealEstateEntities())
            {
                return context.View_SaleCash.ToList();
            }
        }
    }
}

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
        public string ContractId{get;set;}
         public int  ColonyId{get;set;}
        public int  PlotId{get;set;}
        public int SaleStatus{get;set;}
        public DateTime SaleDate{get;set;}
         public int  NoOfMonth{get;set;}
          public decimal MonthlyPayment{get;set;}
          public int DateOfPay { get; set; }
          public int ClientId { get; set; }


        public void Save()
          {
            using(var context=new RealEstateEntities())
            {
                Tbl_Sale obj = new Tbl_Sale() 
              {
               ContractId=ContractId,
               ColonyId=ColonyId,
               PlotId=PlotId,
               SaleStatus=SaleStatus,
               SaleDate=SaleDate,
               NoOfMonth=NoOfMonth,
               MonthlyPayment=MonthlyPayment,
               DateOfPay=DateOfPay,
               ClientId=ClientId
              };
                context.Tbl_Sale.Add(obj);
                context.SaveChanges();
            }
              
          }
    }
}

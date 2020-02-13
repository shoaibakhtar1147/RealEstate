using RealStateManagment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateManagment.BL
{
    class SaleInstallmentBL
    {
     public int ISaleId {get;set;}
      public string ContractNo{get;set;}
      public int  ClienId{get;set;}
      public int ColonyId{get;set;}
      public int PlotId{get;set;}
      public string SaleStatus{get;set;}
      public DateTime  SaleDate{get;set;}
       public int TotalInstall{get;set;}
       public decimal  MonthlyPayment{get;set;}
       public decimal DownPayment{get;set;}
        public int  DatOfPay{get;set;}
        public decimal Balance { get; set; }
        public string Cnic { get; set; } 
            
        

        public void Save()
       {
            using(var context=new RealEstateEntities())
            {
                TBL_SaleInstall obj = new  TBL_SaleInstall() 
                {
                   ColonyId=ColonyId,
                    TotalInstall = TotalInstall,
                    MonthlyPayment = MonthlyPayment,
                    Balance = Balance,
                     SaleDate=SaleDate,
                     DatOfPay = DatOfPay,
                    DownPayment = DownPayment,
                     ClienId=ClienId,
                      ContractNo=ContractNo,
                       PlotId=PlotId,
                        SaleStatus=SaleStatus
                };
                context.TBL_SaleInstall.Add(obj);
                context.SaveChanges();
            }
       }

        public List<View_SaleInstall> Search()
        {
            using (var context = new RealEstateEntities())
            {
                return context.View_SaleInstall.Where(a => a.Cnic == Cnic || ContractNo == ContractNo).ToList();
            }
        }

        public List<View_SaleInstall> Select()
        {
            using (var context = new RealEstateEntities())
            {
                return context.View_SaleInstall.ToList();
            }
        }



    }
}
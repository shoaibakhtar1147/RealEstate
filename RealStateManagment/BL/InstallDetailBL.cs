using RealStateManagment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateManagment.BL
{
    class InstallDetailBL
    {
      public int  IDetailId {get;set;}
      public int  ISaleId{get;set;}
       public DateTime InstallmentDate{get;set;}
       public int  PaidInstall{get;set;}
       public int RemainingInstall { get; set; }
       public decimal Balance { get; set; }
       public decimal InstallmentAmount { get; set; }
       public decimal MonthlyInstallment { get; set; }
       public string Cnic { get; set; }
       public string ContractNo { get; set; }

        public void Save()
       {
            using(var context=new RealEstateEntities())
            {
                Tbl_InstallDetail objIns = new Tbl_InstallDetail() 
                {
                 ISaleId=ISaleId,
                  Balance=Balance,
                   InstallmentDate=InstallmentDate,
                     PaidInstall=PaidInstall,
                      RemainingInstall=RemainingInstall,
                     InstallmentAmount=InstallmentAmount,
                      MonthlyInstallment=MonthlyInstallment
                       
                };
                context.Tbl_InstallDetail.Add(objIns);
                context.SaveChanges();
            }
       }

        public List<View_InstallDetail> Search()
        {
            using(var context=new RealEstateEntities())
            {
                return context.View_InstallDetail.Where(a => a.Cnic == Cnic && a.ContractNo == ContractNo).ToList();
            }
        }
       

    }
}

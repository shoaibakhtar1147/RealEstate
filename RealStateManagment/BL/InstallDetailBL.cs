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
       public int  RemainingInstall{get;set;}
       public decimal Balance { get; set; }
       public decimal InstallmentAmount { get; set; }


        public void Save()
       {
            using(var context=new RealEstateEntities())
            {
                Tbl_InstallDetail objIns = new Tbl_InstallDetail() 
                {
                 ISaleId=ISaleId,
                  Balance=Balance,
                   InstallmentDate=InstallmentDate,
                    RemainingInstall=RemainingInstall,
                     InstallmentAmount=InstallmentAmount
                };
                context.Tbl_InstallDetail.Add(objIns);
                context.SaveChanges();
            }
       }

    }
}

using RealStateManagment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealStateManagment.BL
{
    class TransactionBL
    {

      public int TransactionId {get;set;}
      public int    PartnerId{get;set;}
      public decimal Debit {get;set;}
      public decimal  Credit{get;set;}
      public decimal Amount { get; set; }

        public void Save()
      {
            using(var context=new RealEstateEntities())
            {
                Tbl_Partner_Transaction objTrans = new Tbl_Partner_Transaction() 
                {
                     PartnerId=PartnerId,
                      Credit=Credit,
                       Debit=Debit,
                       Amount=Amount
                };
                context.Tbl_Partner_Transaction.Add(objTrans);
                context.SaveChanges();
            }
      }
    }
}

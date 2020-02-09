using RealStateManagment.DAL;
using RealStateManagment.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RealStateManagment.BL
{
    class TransactionBL
    {

      public int TransactionId {get;set;}
      public int    PartnerId{get;set;}
      public string Description {get;set;}
      public decimal Credit { get; set; }
      public decimal Debit { get; set; }
      public decimal Amount { get; set; }
      public DateTime TransactionDate { get; set; }
      public string PartnerName { get; set; }
      public string Cnic { get; set; }

        public void Save()
      {
            using(var context=new RealEstateEntities())
            {
                Tbl_Partner_Transaction objTrans = new Tbl_Partner_Transaction() 
                {
                     PartnerId=PartnerId,
                        Description= Description,
                        Credit=Credit,
                        Debit=Debit,
                       Amount=Amount,
                        TransactionDate=TransactionDate
                };
                context.Tbl_Partner_Transaction.Add(objTrans);
                context.SaveChanges();
            }
      }
        public List<View_PartnerTransaction> Select()
        {
            using(var context=new RealEstateEntities())
            {
                return context.View_PartnerTransaction.ToList();
            }
        }

        public List<View_PartnerTransaction> Search()
        {
            using(var context=new RealEstateEntities())
            {
                return context.View_PartnerTransaction.Where(a => a.PartnerName.Contains(PartnerName.ToLower())||a.Cnic==Cnic).ToList();
            }
        }
        
        

        public DataTable AddNew()
        {
            string spName = "Transaction_AddNew";
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@TransactionId", TransactionId);
            return DB.SelectTableWithSP(spName, prm);
        }

        //public int CreditAmount()
        //{
        //    string spName = "SP_TotalAmount_Update";
        //    SqlParameter[] prm = new SqlParameter[3];
        //    prm[0]=new SqlParameter("@PartnerId",PartnerId);
        //    prm[1]=new SqlParameter("@Amount",Amount);
        //    prm[2]=new SqlParameter("@Action",1);
        //    return DB.ExecuteNonQueryWithSP(spName,prm);

        //}

        //public int DebitAmount()
        //{
        //    string spName = "SP_TotalAmount_Update";
        //    SqlParameter[] prm = new SqlParameter[3];
        //    prm[0] = new SqlParameter("@PartnerId", PartnerId);
        //    prm[1] = new SqlParameter("@Amount", Amount);
        //    prm[2] = new SqlParameter("@Action", 2);
        //    return DB.ExecuteNonQueryWithSP(spName, prm);

        //}
    }
}

using RealStateManagment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealStateManagment.BL
{
    class PartnerBL
    {

      public int  PartnerId {get;set;}
      public string PartnerName{get;set;}
      public string  FName {get;set;}
      public string   Email{get;set;}
       public string Cnic{get;set;}
      public string MobileNo{get;set;}
      public string PhoneNo{get;set;}
      public string Address { get; set; }


        public void Save()
      {
            using(var context=new RealEstateEntities())
            {
                Tbl_Partner objPartner = new Tbl_Partner() 
                {
                 PartnerName=PartnerName,
                  FName=FName,
                  Email=Email,
                  Cnic=Cnic,
                  MobileNo=MobileNo,
                  PhoneNo=PhoneNo,
                  Address=Address
                };
                context.Tbl_Partner.Add(objPartner);
                context.SaveChanges();
            }
      }

        public List<Tbl_Partner> Select()
        {
            using(var context=new RealEstateEntities())
            {
                return context.Tbl_Partner.ToList();
            }
        }

        public List<Tbl_Partner> Search()
        {
            using(var context=new RealEstateEntities())
            {
                return context.Tbl_Partner.Where(a => a.PartnerName.Contains(PartnerName.ToLower())).ToList();
            }
        }
    }
}

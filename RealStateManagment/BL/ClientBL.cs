using RealStateManagment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealStateManagment.BL
{
    class ClientBL
    {
        public int ClientId {get;set;}
        public string ClientName{get;set;}
       public string FatherName {get;set;}
       public string Cnic {get;set;}
       public string MobNo{get;set;}
       public string PhoneNo{get;set;}
       public string  Email {get;set;}
       public string Address { get; set; }

        public void Save()
       {
            using(var context=new RealEstateEntities())
            {
                Tbl_Client objCLient = new Tbl_Client() 
                {
                 ClientName=ClientName,
                  FatherName=FatherName,
                   Cnic=Cnic,
                    Email=Email,
                     MobNo=MobNo,
                      PhoneNo=PhoneNo,
                       Address=Address
                };
                context.Tbl_Client.Add(objCLient);
                context.SaveChanges();
            }
        }

            public List<Tbl_Client> Select()
            {
                using(var context=new RealEstateEntities())
                {
                    return context.Tbl_Client.ToList();
                }
            }
       }
    }


using RealStateManagment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealStateManagment.BL
{
    class ColonyBL
    {
       public int ColonyId {get;set;}
       public string ColonyName{get;set;}
       public string Location{get;set;}
       public string  Area{get;set;}
       public string OwnerName{get;set;}
       public string FName{get;set;}
       public string Cnic{get;set;}
       public string Address { get; set; }

        public void Save()
       {
            using(var context=new RealEstateEntities())
            {
                Tbl_Colony objColony = new Tbl_Colony() 
                {
                 ColonyName=ColonyName,
                 Location=Location,
                 Area=Area,
                 OwnerName=OwnerName,
                 FName=FName,
                 Cnic=Cnic,
                  Address=Address
                };
                context.Tbl_Colony.Add(objColony);
                context.SaveChanges();
            }
       }

        public List<Tbl_Colony> Select()
        {
            using(var context=new RealEstateEntities())
            {
                return context.Tbl_Colony.ToList();
            }
        }

        public List<Tbl_Colony> Search()
        {
            using(var context=new RealEstateEntities())
            {
                return context.Tbl_Colony.Where(a => a.ColonyName.Contains(ColonyName.ToLower())).ToList();
            }
        }
    }
}

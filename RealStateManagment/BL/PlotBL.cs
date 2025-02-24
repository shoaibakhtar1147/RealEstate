﻿using RealStateManagment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealStateManagment.BL
{
    class PlotBL
    {
       public int PlotId {get;set;}
      public int PlotNo{get;set;}
      public string PlotArea {get;set;}
      public decimal PlotAmount{get;set;}
     public string Status{get;set;}
     public int ColonyId { get; set; }
     public string ColonyName { get; set; }
     public decimal AmountOnInstall { get; set; }
     public string Size { get; set; }

    public void Save()
     {
        using(var context=new RealEstateEntities())
        {
            Tbl_Plot objPlot = new Tbl_Plot() 
            {
             PlotNo=PlotNo,
              Area=PlotArea,
              PlotAmount=PlotAmount,
              Status=Status,
              ColonyId=ColonyId,
              AmountOnInstall=AmountOnInstall,
              Size=Size
            };
            context.Tbl_Plot.Add(objPlot);
            context.SaveChanges();

        }
     }
        public void Update()
    {
            using(var context=new RealEstateEntities())
            {
                var res = context.Tbl_Plot.Where(a => a.ColonyId==ColonyId && a.PlotId == PlotId).SingleOrDefault();
                if(res != null)
                {
                    res.Status = Status;
                    context.SaveChanges();

                }

            }
    }

        public List<View_Plot> Select()
    {
            using(var context=new RealEstateEntities())
            {
                return context.View_Plot.ToList();
            }
    }

        public List<View_Plot> Search()
        {
            using(var context=new RealEstateEntities())
            {
                return context.View_Plot.Where(a => a.ColonyName == ColonyName|| a.PlotId==PlotId && ColonyId==ColonyId).ToList();
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealStateManagment.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_InstallDetail
    {
        public int IDetailId { get; set; }
        public Nullable<int> ISaleId { get; set; }
        public Nullable<System.DateTime> InstallmentDate { get; set; }
        public Nullable<int> PaidInstall { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<decimal> InstallmentAmount { get; set; }
        public Nullable<decimal> MonthlyInstallment { get; set; }
        public Nullable<int> RemainingInstall { get; set; }
    }
}

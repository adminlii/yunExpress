//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Entity
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using LighTake.Infrastructure.Seedwork;
    
    public partial class WayBillPrintLog : Entity
    {
        public virtual int logID { get; set; }
        public virtual string waybillnumber { get; set; }
        public virtual string sendGoodsVender { get; set; }
        public virtual string sendGoodsChannel { get; set; }
        public virtual string newTrackNumber { get; set; }
        public virtual string printPerson { get; set; }
        public virtual Nullable<System.DateTime> printDate { get; set; }
    }
}
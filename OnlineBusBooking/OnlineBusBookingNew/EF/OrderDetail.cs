//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineBusBookingNew.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public long OrderDetailID { get; set; }
        public Nullable<long> OrderID { get; set; }
        public Nullable<int> RoutingID { get; set; }
        public Nullable<int> SeatNumber { get; set; }
        public Nullable<decimal> PriceCalculated { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Routing Routing { get; set; }
    }
}

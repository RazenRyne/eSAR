//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eSARDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentDetail
    {
        public int DetailNumber { get; set; }
        public Nullable<int> ORNo { get; set; }
        public int FeeID { get; set; }
        public Nullable<double> Amount { get; set; }
    
        public virtual Fee Fee { get; set; }
        public virtual Payment Payment { get; set; }
    }
}

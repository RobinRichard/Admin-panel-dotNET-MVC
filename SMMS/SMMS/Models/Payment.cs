//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int PaymentID { get; set; }
        public decimal PayableAmount { get; set; }
        public decimal PaidAMount { get; set; }
        public string Comments { get; set; }
        public int EnrolmentID { get; set; }
        public int PaymentStatus { get; set; }
    
        public virtual Enrolment Enrolment { get; set; }
        public virtual PaymentStatu PaymentStatu { get; set; }
    }
}

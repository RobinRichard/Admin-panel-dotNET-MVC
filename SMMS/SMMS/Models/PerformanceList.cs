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
    
    public partial class PerformanceList
    {
        public int PerformanceListID { get; set; }
        public System.TimeSpan PerformanceTime { get; set; }
        public int MusicSheetID { get; set; }
        public int PerformanceID { get; set; }
    
        public virtual MusicSheet MusicSheet { get; set; }
        public virtual Performance Performance { get; set; }
    }
}
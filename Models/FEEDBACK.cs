//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projectsem3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FEEDBACK
    {
        public int StudentId { get; set; }
        public Nullable<int> FacilitiesId { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public Nullable<bool> Status { get; set; }
        public int Id { get; set; }
    
        public virtual STUDENT STUDENT { get; set; }
    }
}
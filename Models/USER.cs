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
    
    public partial class USER
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<short> Gender { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> Role { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual ROLE ROLE1 { get; set; }
    }
}

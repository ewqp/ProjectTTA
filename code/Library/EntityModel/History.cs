//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class History
    {
        public int IdHistory { get; set; }
        public int IdBooks { get; set; }
        public int IdUser { get; set; }
        public short Returned { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual User User { get; set; }
    }
}
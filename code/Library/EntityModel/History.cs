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
        public short Returned { get; set; }
        public int IdBook { get; set; }
        public System.DateTime ActionDate { get; set; }
        public int IdAuthor { get; set; }
        public int IdAccount { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Helios.Models
{
    using System;
    using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
    
    public partial class WYKUP_BILET
    {
        [Display(Name="Id")]
        public int IdRezerwacji { get; set; }
        public int FK_IdSeansu { get; set; }
        public int FK_IdMiejsca { get; set; }
        public int FK_IdBiletu { get; set; }
    
        public virtual BILET BILET { get; set; }
        public virtual MIEJSCE MIEJSCE { get; set; }
        public virtual SEANS SEANS { get; set; }
    }
}
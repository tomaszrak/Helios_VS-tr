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
    
    public partial class OBSLUGA
    {
        public int IdObslugi { get; set; }
        public int FK_IdFilmu { get; set; }
        public int FK_IdPracownika { get; set; }
    
        public virtual FILM FILM { get; set; }
        public virtual PRACOWNIK PRACOWNIK { get; set; }
    }
}
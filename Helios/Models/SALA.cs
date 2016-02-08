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
    
    public partial class SALA
    {
        public SALA()
        {
            this.MIEJSCE = new HashSet<MIEJSCE>();
            this.SEANS = new HashSet<SEANS>();
        }

        [Display(Name="id sali")]
        public int IdSali { get; set; }

        [Required(ErrorMessage="Nazwa sali nie mo�e by� pusta")]
        [Display(Name = "nazwa sali")]
        public string NazwaSali { get; set; }

        [Display(Name = "klimatyzacja")]
        public Nullable<bool> Klimatyzacja { get; set; }

        [Display(Name = "FK_IdKina")]
        public int FK_IdKina { get; set; }
    
        public virtual KINO KINO { get; set; }
        public virtual ICollection<MIEJSCE> MIEJSCE { get; set; }
        public virtual ICollection<SEANS> SEANS { get; set; }
    }
}
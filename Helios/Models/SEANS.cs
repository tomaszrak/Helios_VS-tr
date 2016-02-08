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
    
    public partial class SEANS
    {
        public SEANS()
        {
            this.WYKUP_BILET = new HashSet<WYKUP_BILET>();
        }
    
        [Display(Name="Id")]
        public int IdSeansu { get; set; }

        [Display(Name="Data seansu")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime SeansData { get; set; }

        [Display(Name="Godzina seansu")]
        public System.TimeSpan SeansGodzina { get; set; }

        [Display(Name="Status")]
        public Nullable<bool> Status_S { get; set; }
        public int FK_IdSali { get; set; }
        public int FK_IdFilmu { get; set; }
    
        public virtual FILM FILM { get; set; }
        public virtual SALA SALA { get; set; }
        public virtual ICollection<WYKUP_BILET> WYKUP_BILET { get; set; }
    }
}

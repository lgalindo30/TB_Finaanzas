//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BonoCorpAleman.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inflacion
    {
        public int ID { get; set; }
        public long Bono_ID { get; set; }
        public double Valor { get; set; }
        public int Periodo { get; set; }
    
        public virtual Bono Bono { get; set; }
    }
}

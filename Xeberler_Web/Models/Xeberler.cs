//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xeberler_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Xeberler
    {
        public int id { get; set; }
        public string xeber_basliq { get; set; }
        public string xeber_qisa { get; set; }
        public string xeber_tam { get; set; }
        public string xeber_sekil { get; set; }
        public Nullable<int> xeber_kat { get; set; }
    
        public virtual Kateqoriya Kateqoriya { get; set; }
    }
}

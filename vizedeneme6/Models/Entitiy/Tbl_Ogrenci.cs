//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vizedeneme6.Models.Entitiy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Ogrenci
    {
        public int ogrid { get; set; }
        public string ograd { get; set; }
        public string ogrsoyad { get; set; }
        public string mezuniyet { get; set; }
        public Nullable<double> kredi { get; set; }
        public Nullable<int> bolumid { get; set; }
    
        public virtual Tbl_Bolumler Tbl_Bolumler { get; set; }
    }
}

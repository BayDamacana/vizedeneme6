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
    
    public partial class Tbl_Ogretmen
    {
        public int ogretid { get; set; }
        public string ogretmenad { get; set; }
        public string ogretmensoyad { get; set; }
        public Nullable<int> bolumid { get; set; }
        public string emekli { get; set; }
    
        public virtual Tbl_Bolumler Tbl_Bolumler { get; set; }
    }
}
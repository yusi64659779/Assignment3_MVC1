//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment3_F19.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fruit
    {
        public int Fruit_ID { get; set; }
        public int Product_ID { get; set; }
        public string Fruit_Name { get; set; }
    
        public virtual AgriProduct AgriProduct { get; set; }
    }
}

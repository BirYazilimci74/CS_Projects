//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CurrencyAppWithXML.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operation
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public string OperationType { get; set; }
        public Nullable<decimal> CurrentCurrencyValue { get; set; }
        public Nullable<decimal> Amout { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Currency Currency { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XafLegacyNightmare.Module.BusinessObjects.NWind
{

    [NonPersistent]
    public partial class OrderSubtotals : XPLiteObject
    {
        int fOrderID;
        public int OrderID
        {
            get { return fOrderID; }
            set { SetPropertyValue<int>(nameof(OrderID), ref fOrderID, value); }
        }
        decimal fSubtotal;
        public decimal Subtotal
        {
            get { return fSubtotal; }
            set { SetPropertyValue<decimal>(nameof(Subtotal), ref fSubtotal, value); }
        }
        public OrderSubtotals(Session session) : base(session) { }
    }

}

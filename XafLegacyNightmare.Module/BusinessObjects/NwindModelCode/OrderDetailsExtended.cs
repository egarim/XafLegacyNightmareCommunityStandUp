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
    public partial class OrderDetailsExtended : XPLiteObject
    {
        int fOrderID;
        public int OrderID
        {
            get { return fOrderID; }
            set { SetPropertyValue<int>(nameof(OrderID), ref fOrderID, value); }
        }
        int fProductID;
        public int ProductID
        {
            get { return fProductID; }
            set { SetPropertyValue<int>(nameof(ProductID), ref fProductID, value); }
        }
        string fProductName;
        [Size(40)]
        public string ProductName
        {
            get { return fProductName; }
            set { SetPropertyValue<string>(nameof(ProductName), ref fProductName, value); }
        }
        decimal fUnitPrice;
        public decimal UnitPrice
        {
            get { return fUnitPrice; }
            set { SetPropertyValue<decimal>(nameof(UnitPrice), ref fUnitPrice, value); }
        }
        short fQuantity;
        public short Quantity
        {
            get { return fQuantity; }
            set { SetPropertyValue<short>(nameof(Quantity), ref fQuantity, value); }
        }
        float fDiscount;
        public float Discount
        {
            get { return fDiscount; }
            set { SetPropertyValue<float>(nameof(Discount), ref fDiscount, value); }
        }
        decimal fExtendedPrice;
        public decimal ExtendedPrice
        {
            get { return fExtendedPrice; }
            set { SetPropertyValue<decimal>(nameof(ExtendedPrice), ref fExtendedPrice, value); }
        }
        public OrderDetailsExtended(Session session) : base(session) { }
    }

}

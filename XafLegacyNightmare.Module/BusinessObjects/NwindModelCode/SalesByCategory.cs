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
    public partial class SalesByCategory : XPLiteObject
    {
        int fCategoryID;
        public int CategoryID
        {
            get { return fCategoryID; }
            set { SetPropertyValue<int>(nameof(CategoryID), ref fCategoryID, value); }
        }
        string fCategoryName;
        [Size(15)]
        public string CategoryName
        {
            get { return fCategoryName; }
            set { SetPropertyValue<string>(nameof(CategoryName), ref fCategoryName, value); }
        }
        string fProductName;
        [Size(40)]
        public string ProductName
        {
            get { return fProductName; }
            set { SetPropertyValue<string>(nameof(ProductName), ref fProductName, value); }
        }
        decimal fProductSales;
        public decimal ProductSales
        {
            get { return fProductSales; }
            set { SetPropertyValue<decimal>(nameof(ProductSales), ref fProductSales, value); }
        }
        public SalesByCategory(Session session) : base(session) { }
    }

}

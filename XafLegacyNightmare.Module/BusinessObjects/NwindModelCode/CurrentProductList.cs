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
    public partial class CurrentProductList : XPLiteObject
    {
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
        public CurrentProductList(Session session) : base(session) { }
    }

}

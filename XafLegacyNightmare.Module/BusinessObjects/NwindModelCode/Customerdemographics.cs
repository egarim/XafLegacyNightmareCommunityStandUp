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

    [Persistent(@"CustomerDemographics")]
    public partial class Customerdemographics : XPLiteObject
    {
        string fCustomerTypeID;
        [Key]
        [Size(10)]
        public string CustomerTypeID
        {
            get { return fCustomerTypeID; }
            set { SetPropertyValue<string>(nameof(CustomerTypeID), ref fCustomerTypeID, value); }
        }
        string fCustomerDesc;
        [Size(SizeAttribute.Unlimited)]
        public string CustomerDesc
        {
            get { return fCustomerDesc; }
            set { SetPropertyValue<string>(nameof(CustomerDesc), ref fCustomerDesc, value); }
        }
        public Customerdemographics(Session session) : base(session) { }
    }

}

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
    public partial class CustomerAndSuppliersByCity : XPLiteObject
    {
        string fCity;
        [Size(15)]
        public string City
        {
            get { return fCity; }
            set { SetPropertyValue<string>(nameof(City), ref fCity, value); }
        }
        string fCompanyName;
        [Size(40)]
        public string CompanyName
        {
            get { return fCompanyName; }
            set { SetPropertyValue<string>(nameof(CompanyName), ref fCompanyName, value); }
        }
        string fContactName;
        [Size(30)]
        public string ContactName
        {
            get { return fContactName; }
            set { SetPropertyValue<string>(nameof(ContactName), ref fContactName, value); }
        }
        string fRelationship;
        [Size(9)]
        public string Relationship
        {
            get { return fRelationship; }
            set { SetPropertyValue<string>(nameof(Relationship), ref fRelationship, value); }
        }
        public CustomerAndSuppliersByCity(Session session) : base(session) { }
    }

}

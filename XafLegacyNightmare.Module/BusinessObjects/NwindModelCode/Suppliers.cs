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

    public partial class Suppliers : XPLiteObject
    {
        int fSupplierID;
        [Key(true)]
        public int SupplierID
        {
            get { return fSupplierID; }
            set { SetPropertyValue<int>(nameof(SupplierID), ref fSupplierID, value); }
        }
        string fCompanyName;
        [Indexed(Name = @"CompanyName")]
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
        string fContactTitle;
        [Size(30)]
        public string ContactTitle
        {
            get { return fContactTitle; }
            set { SetPropertyValue<string>(nameof(ContactTitle), ref fContactTitle, value); }
        }
        string fAddress;
        [Size(60)]
        public string Address
        {
            get { return fAddress; }
            set { SetPropertyValue<string>(nameof(Address), ref fAddress, value); }
        }
        string fCity;
        [Size(15)]
        public string City
        {
            get { return fCity; }
            set { SetPropertyValue<string>(nameof(City), ref fCity, value); }
        }
        string fRegion;
        [Size(15)]
        public string Region
        {
            get { return fRegion; }
            set { SetPropertyValue<string>(nameof(Region), ref fRegion, value); }
        }
        string fPostalCode;
        [Indexed(Name = @"PostalCode")]
        [Size(10)]
        public string PostalCode
        {
            get { return fPostalCode; }
            set { SetPropertyValue<string>(nameof(PostalCode), ref fPostalCode, value); }
        }
        string fCountry;
        [Size(15)]
        public string Country
        {
            get { return fCountry; }
            set { SetPropertyValue<string>(nameof(Country), ref fCountry, value); }
        }
        string fPhone;
        [Size(24)]
        public string Phone
        {
            get { return fPhone; }
            set { SetPropertyValue<string>(nameof(Phone), ref fPhone, value); }
        }
        string fFax;
        [Size(24)]
        public string Fax
        {
            get { return fFax; }
            set { SetPropertyValue<string>(nameof(Fax), ref fFax, value); }
        }
        string fHomePage;
        [Size(SizeAttribute.Unlimited)]
        public string HomePage
        {
            get { return fHomePage; }
            set { SetPropertyValue<string>(nameof(HomePage), ref fHomePage, value); }
        }
        [Association(@"ProductsReferencesSuppliers")]
        public XPCollection<Products> ProductsCollection { get { return GetCollection<Products>(nameof(ProductsCollection)); } }
        public Suppliers(Session session) : base(session) { }
    }

}
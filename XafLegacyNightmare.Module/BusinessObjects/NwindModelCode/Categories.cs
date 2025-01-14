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

    public partial class Categories : XPLiteObject
    {
        int fCategoryID;
        [Key(true)]
        public int CategoryID
        {
            get { return fCategoryID; }
            set { SetPropertyValue<int>(nameof(CategoryID), ref fCategoryID, value); }
        }
        string fCategoryName;
        [Indexed(Name = @"CategoryName")]
        [Size(15)]
        public string CategoryName
        {
            get { return fCategoryName; }
            set { SetPropertyValue<string>(nameof(CategoryName), ref fCategoryName, value); }
        }
        string fDescription;
        [Size(SizeAttribute.Unlimited)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>(nameof(Description), ref fDescription, value); }
        }
        byte[] fPicture;
        [Size(SizeAttribute.Unlimited)]
        [MemberDesignTimeVisibility(true)]
        public byte[] Picture
        {
            get { return fPicture; }
            set { SetPropertyValue<byte[]>(nameof(Picture), ref fPicture, value); }
        }
        [Association(@"ProductsReferencesCategories")]
        public XPCollection<Products> ProductsCollection { get { return GetCollection<Products>(nameof(ProductsCollection)); } }
        public Categories(Session session) : base(session) { }
    }

}

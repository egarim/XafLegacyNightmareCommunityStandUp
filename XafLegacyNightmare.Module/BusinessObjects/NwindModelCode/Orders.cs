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
using DevExpress.Persistent.Base;
namespace XafLegacyNightmare.Module.BusinessObjects.NWind
{
    [DefaultClassOptions()]
    public partial class Orders : XPLiteObject
    {
        DateTime orderDateLegacy;
        int fOrderID;
        [Key(true)]
        public int OrderID
        {
            get { return fOrderID; }
            set { SetPropertyValue<int>(nameof(OrderID), ref fOrderID, value); }
        }
        Customers fCustomerID;
        [Size(5)]
        [Association(@"OrdersReferencesCustomers")]
        public Customers CustomerID
        {
            get { return fCustomerID; }
            set { SetPropertyValue<Customers>(nameof(CustomerID), ref fCustomerID, value); }
        }
        Employees fEmployeeID;
        [Association(@"OrdersReferencesEmployees")]
        public Employees EmployeeID
        {
            get { return fEmployeeID; }
            set { SetPropertyValue<Employees>(nameof(EmployeeID), ref fEmployeeID, value); }
        }
        DateTime fOrderDate;
        [Indexed(Name = @"OrderDate")]
        public DateTime OrderDate
        {
            get { return fOrderDate; }
            set { SetPropertyValue<DateTime>(nameof(OrderDate), ref fOrderDate, value); }
        }
        DateTime fRequiredDate;
        public DateTime RequiredDate
        {
            get { return fRequiredDate; }
            set { SetPropertyValue<DateTime>(nameof(RequiredDate), ref fRequiredDate, value); }
        }
        DateTime fShippedDate;
        [Indexed(Name = @"ShippedDate")]
        public DateTime ShippedDate
        {
            get { return fShippedDate; }
            set { SetPropertyValue<DateTime>(nameof(ShippedDate), ref fShippedDate, value); }
        }
        Shippers fShipVia;
        [Association(@"OrdersReferencesShippers")]
        public Shippers ShipVia
        {
            get { return fShipVia; }
            set { SetPropertyValue<Shippers>(nameof(ShipVia), ref fShipVia, value); }
        }
        decimal fFreight;
        [ColumnDbDefaultValue("((0))")]
        public decimal Freight
        {
            get { return fFreight; }
            set { SetPropertyValue<decimal>(nameof(Freight), ref fFreight, value); }
        }
        string fShipName;
        [Size(40)]
        public string ShipName
        {
            get { return fShipName; }
            set { SetPropertyValue<string>(nameof(ShipName), ref fShipName, value); }
        }
        string fShipAddress;
        [Size(60)]
        public string ShipAddress
        {
            get { return fShipAddress; }
            set { SetPropertyValue<string>(nameof(ShipAddress), ref fShipAddress, value); }
        }
        string fShipCity;
        [Size(15)]
        public string ShipCity
        {
            get { return fShipCity; }
            set { SetPropertyValue<string>(nameof(ShipCity), ref fShipCity, value); }
        }
        string fShipRegion;
        [Size(15)]
        public string ShipRegion
        {
            get { return fShipRegion; }
            set { SetPropertyValue<string>(nameof(ShipRegion), ref fShipRegion, value); }
        }
        string fShipPostalCode;
        [Indexed(Name = @"ShipPostalCode")]
        [Size(10)]
        public string ShipPostalCode
        {
            get { return fShipPostalCode; }
            set { SetPropertyValue<string>(nameof(ShipPostalCode), ref fShipPostalCode, value); }
        }
        string fShipCountry;
        [Size(15)]
        public string ShipCountry
        {
            get { return fShipCountry; }
            set { SetPropertyValue<string>(nameof(ShipCountry), ref fShipCountry, value); }
        }

        [ValueConverter(typeof(IntToDateValueConverter))]
        public DateTime OrderDateLegacy
        {
            get => orderDateLegacy;
            set => SetPropertyValue(nameof(OrderDateLegacy), ref orderDateLegacy, value);
        }
        public Orders(Session session) : base(session) { }
    }

}
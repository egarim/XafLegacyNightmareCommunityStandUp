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
    public static class ConnectionHelper
    {
        static Type[] persistentTypes = new Type[] {
            typeof(Categories),
            typeof(Customercustomerdemo),
            typeof(Customerdemographics),
            typeof(Customers),
            typeof(Employees),
            typeof(Employeeterritories),
            typeof(OrderDetails),
            typeof(Orders),
            typeof(Products),
            typeof(Region),
            typeof(Shippers),
            typeof(Suppliers),
            typeof(Territories),
            typeof(Testclass)
        };
        public static Type[] GetPersistentTypes()
        {
            Type[] copy = new Type[persistentTypes.Length];
            Array.Copy(persistentTypes, copy, persistentTypes.Length);
            return copy;
        }
        static Type[] nonPersistentTypes = new Type[] {
            typeof(CustOrderHistResult),
            typeof(CustOrdersDetailResult),
            typeof(CustOrdersOrdersResult),
            typeof(EmployeeSalesbyCountryResult),
            typeof(SalesbyYearResult),
            typeof(SalesByCategoryResult),
            typeof(TenMostExpensiveProductsResult),
            typeof(AlphabeticalListOfProducts),
            typeof(CategorySalesFor1997),
            typeof(CurrentProductList),
            typeof(CustomerAndSuppliersByCity),
            typeof(Invoices),
            typeof(OrderDetailsExtended),
            typeof(OrderSubtotals),
            typeof(OrdersQry),
            typeof(ProductSalesFor1997),
            typeof(ProductsAboveAveragePrice),
            typeof(ProductsByCategory),
            typeof(QuarterlyOrders),
            typeof(SalesByCategory),
            typeof(SalesTotalsByAmount),
            typeof(SummaryOfSalesByQuarter),
            typeof(SummaryOfSalesByYear)
        };
        public static Type[] GetNonPersistentTypes()
        {
            Type[] copy = new Type[nonPersistentTypes.Length];
            Array.Copy(nonPersistentTypes, copy, nonPersistentTypes.Length);
            return copy;
        }
#warning We recommend moving the connection string out of your source code (for instance, to a configuration file) to improve your application's maintainability and security.
        public const string ConnectionString = "XpoProvider=MSSqlServer;data source=(localdb)\\MSSQLLocalDB;integrated security=SSPI;initial catalog=NWind";
        public static void Connect(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, bool threadSafe = false)
        {
            if (threadSafe)
            {
                var provider = XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption);
                var dictionary = new DevExpress.Xpo.Metadata.ReflectionDictionary();
                dictionary.GetDataStoreSchema(persistentTypes);
                dictionary.CollectClassInfos(nonPersistentTypes);
                XpoDefault.DataLayer = new ThreadSafeDataLayer(dictionary, provider);
            }
            else
            {
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
            }
            XpoDefault.Session = null;
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption);
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, out IDisposable[] objectsToDisposeOnDisconnect)
        {
            return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption, out objectsToDisposeOnDisconnect);
        }
        public static IDataLayer GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
        }
    }

}

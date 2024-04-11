using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Kpi;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XafLegacyNightmare.Module.BusinessObjects
{


    //HACK https://docs.devexpress.com/XPO/DevExpress.Xpo.NoForeignKeyAttribute
    //Foreign keys preserve referential integrity in a relational database.
    //A lack of referential integrity in a database can lead to errors or returning incomplete data without indication of an error.
    //To enforce the data integrity at the database level, do not disable automatic creation of the FOREIGN KEY constraints(or always add them manually).
    [DefaultClassOptions]
    [NavigationItem("Person Foreign Key example")]
    public class PersonFK : BaseObject
    {

        string name;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }
        protected PersonFK()
        {

        }

        /// <doc>
        /// <assembly>
        /// <name>DevExpress.Xpo.v23.1</name>
        /// </assembly>
        /// <members>
        /// <member name="N:DevExpress.Xpo">
        /// <summary>
        /// <para>Contains classes that support the infrastructure of the eXpress Persistent Objects.</para>
        /// </summary>
        /// </member>
        /// <member name="T:DevExpress.Xpo.AggregatedAttribute">
        /// <summary>
        public PersonFK(Session session) : base(session)
        {

        }

      
        // ...
        [Association("Person-Orders")]
        public XPCollection<OrderFK> Orders
        {
            get { return GetCollection<OrderFK>(nameof(Orders)); }
        }
    }

    public class OrderFK : BaseObject
    {
        
        public DateTime OrderDate
        {
            get => orderDate;
            set => SetPropertyValue(nameof(OrderDate), ref orderDate, value);
        }
        // ...
        [Association("Person-Orders"), NoForeignKey]
        public PersonFK PersonID
        {
            get { return fPersonID; }
            set { SetPropertyValue(nameof(PersonID), ref fPersonID, value); }
        }
        DateTime orderDate;
        PersonFK fPersonID;

        protected OrderFK()
        {

        }

        /// <doc>
        /// <assembly>
        /// <name>DevExpress.Xpo.v23.1</name>
        /// </assembly>
        /// <members>
        /// <member name="N:DevExpress.Xpo">
        /// <summary>
        /// <para>Contains classes that support the infrastructure of the eXpress Persistent Objects.</para>
        /// </summary>
        /// </member>
        /// <member name="T:DevExpress.Xpo.AggregatedAttribute">
        /// <summary>
        public OrderFK(Session session) : base(session)
        {

        }

       
    }
}
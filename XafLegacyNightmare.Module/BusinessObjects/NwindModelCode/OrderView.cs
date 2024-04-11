using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XafLegacyNightmare.Module.BusinessObjects.NwindModelCode
{
    [DefaultClassOptions]
    
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class OrderView : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public OrderView(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string shipCity;
        string shipName;
        DateTime orderDate;
        Guid uniqueIdentifier;
        [Key(false)]
        public Guid UniqueIdentifier
        {
            get => uniqueIdentifier;
            set => SetPropertyValue(nameof(UniqueIdentifier), ref uniqueIdentifier, value);
        }

        public DateTime OrderDate
        {
            get => orderDate;
            set => SetPropertyValue(nameof(OrderDate), ref orderDate, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ShipName
        {
            get => shipName;
            set => SetPropertyValue(nameof(ShipName), ref shipName, value);
        }
        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ShipCity
        {
            get => shipCity;
            set => SetPropertyValue(nameof(ShipCity), ref shipCity, value);
        }
        protected override void OnDeleting()
        {
            throw new InvalidOperationException("this operation is not implemented");
        }
        protected override void OnSaving()
        {
            throw new InvalidOperationException("this operation is not implemented");
        }
    }
}
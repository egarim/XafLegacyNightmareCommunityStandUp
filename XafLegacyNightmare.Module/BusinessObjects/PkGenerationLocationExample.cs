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

namespace XafLegacyNightmare.Module.BusinessObjects
{
    [DefaultClassOptions]
    [Persistent("ExampleTable")]
    public class PkGenerationLocationExample : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public PkGenerationLocationExample(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            this.MyColumn = StringGenerator.GenerateValidString();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string myColumn;
        [Key(false)]

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string MyColumn
        {
            get => myColumn;
            set => SetPropertyValue(nameof(MyColumn), ref myColumn, value);
        }
    }


    public static class StringGenerator
    {
        /// <summary>
        /// Generates a string based on the current DateTime that conforms to the pattern [A-Za-z][0-9]+
        /// </summary>
        /// <returns>A valid string that starts with a letter followed by numbers.</returns>
        public static string GenerateValidString()
        {
            // Get the current UTC DateTime
            DateTime now = DateTime.UtcNow;

            // Convert DateTime to a numeric string format
            string numericPart = now.ToString("yyyyMMddHHmmssfff");

            // Prepend a letter to ensure the string starts with a letter (I use 'A' here, but it can be any letter)
            string validString = "A" + numericPart;

            return validString;
        }
    }
}
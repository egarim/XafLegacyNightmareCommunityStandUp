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
    public struct SalesKey
    {
        [Persistent("stor_id")]
        public string StorId { get; set; }
        [Persistent("ord_num")]
        public string OrdNum { get; set; }
        [Persistent("title_id")]
        public string TitleId { get; set; }


        /// <summary>
        /// Generates a random string of a given length using alphanumeric characters.
        /// </summary>
        /// <param name="length">The length of the string to generate.</param>
        /// <returns>A random alphanumeric string.</returns>
        private static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var stringBuilder = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append(chars[random.Next(chars.Length)]);
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Generates a SalesKey instance with random values.
        /// </summary>
        /// <returns>A SalesKey instance filled with random alphanumeric strings.</returns>
        public static SalesKey GenerateRandomSalesKey()
        {
            return new SalesKey
            {
                StorId = GenerateRandomString(8),  // Assuming a length of 8 characters for StorId
                OrdNum = GenerateRandomString(10), // Assuming a length of 10 characters for OrdNum
                TitleId = GenerateRandomString(6)  // Assuming a length of 6 characters for TitleId
            };
        }

    }


    //HACK https://supportcenter.devexpress.com/ticket/details/a2615/xpo-how-to-map-persistent-objects-to-database-tables-with-compound-or-composite-multi
    [DefaultClassOptions]
   
    public class ClusteredPrimaryKey : XPLiteObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public ClusteredPrimaryKey(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Key = SalesKey.GenerateRandomSalesKey();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        [Key, Persistent, Browsable(true)]
        public SalesKey Key { get; set; }


        string contact_Name;
        string phone_Number;

        [Size(15)]
        public string phone_number
        {
            get => phone_Number;
            set => SetPropertyValue(nameof(phone_number), ref phone_Number, value);
        }
        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string contact_name
        {
            get => contact_Name;
            set => SetPropertyValue(nameof(contact_name), ref contact_Name, value);
        }
    


    }
}
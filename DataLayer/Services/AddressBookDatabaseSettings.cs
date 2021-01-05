using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Services
{
    public class AddressBookDatabaseSettings : IAddressBookDatabaseSettings
    {
        public string AddressBookCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}

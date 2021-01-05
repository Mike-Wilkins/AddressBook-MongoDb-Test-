using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Services
{
    public interface IAddressBookDatabaseSettings
    {
        public string AddressBookCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}

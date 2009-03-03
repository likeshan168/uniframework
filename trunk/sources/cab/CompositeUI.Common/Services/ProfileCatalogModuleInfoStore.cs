//----------------------------------------------------------------------------------------
// patterns & practices - Smart Client Software Factory - Guidance Package
//
// This file was generated by this guidance package as part of the solution template
//
// The ProfileCatalogModuleInfoStore class provides the default implementation
// for IModuleInfoStore. It retrieves the profile catalog from a local file.
// 
// For more information see: 
// ms-help://MS.VSCC.v80/MS.VSIPCC.v80/ms.scsf.2006jun/SCSF/html/03-210-Creating%20a%20Smart%20Client%20Solution.htm
//
// Latest version of this Guidance Package: http://go.microsoft.com/fwlink/?LinkId=62182
//----------------------------------------------------------------------------------------

using System.IO;
using Microsoft.Practices.CompositeUI.Utility;

namespace Microsoft.Practices.CompositeUI.Common
{
    public class ProfileCatalogModuleInfoStore : IModuleInfoStore
    {
        private string _catalogFilePath;

        public ProfileCatalogModuleInfoStore()
        {
            _catalogFilePath = "ProfileCatalog.xml";
        }

        public string CatalogFilePath
        {
            get { return _catalogFilePath; }
            set
            {
                Guard.ArgumentNotNullOrEmptyString(value, "Catalog File Path");

                _catalogFilePath = value;
            }
        }

        public string GetModuleListXml()
        {
            string result;

            try
            {
                result = File.ReadAllText(_catalogFilePath);
            }
            catch
            {
                result = null;
            }

            return result;
        }
    }
}

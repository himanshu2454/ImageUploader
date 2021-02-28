using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUploader.Repository
{
    public class InMemoryDataSource : IDataSource
    {
        public byte[] content;
        public string config { get; set; }

        #region Fetch Data

        public byte[] GetData(string ImageName)
        {

            // Implentation to fetch Image.
            return content;
        }

        #endregion
    }
}

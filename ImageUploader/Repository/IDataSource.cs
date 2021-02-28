using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUploader.Repository
{
    public interface IDataSource
    {
        public string config { get; set; }
        public byte[] GetData(string config);

    }
}

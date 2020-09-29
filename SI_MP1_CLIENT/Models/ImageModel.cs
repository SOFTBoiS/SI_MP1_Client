using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SI_MP1_SOAP_CLIENT.Models
{
    public class ImageModel
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string url { get; set; }

        public ImageModel(int id, string userName, string url)
        {
            this.id = id;
            this.userName = userName;
            this.url = url;
        }
    }
}

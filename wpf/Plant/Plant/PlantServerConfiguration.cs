using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Plant;
using System.Runtime.Serialization;

namespace Plant
{
    [DataContract(Namespace = Namespaces.Plant)]
    public class PlantServerConfiguration
    {
        public PlantServerConfiguration() 
        {
            Initialize();
        }

        [OnDeserializing()]
        private void Initialize(StreamingContext context) 
        {
            Initialize();
        }

        private void Initialize()
        {
           
        }
    }
}

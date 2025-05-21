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

        private void Initialize(){}
    }
}

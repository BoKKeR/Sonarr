using System.Collections.Generic;
using NzbDrone.Core.Datastore;

namespace NzbDrone.Core.Profiles.Releases
{
    public class ReleaseProfile : ModelBase
    {
        public string Required { get; set; }
        public List<KeyValuePair<string, int>> Preferred { get; set; }
        public string Ignored { get; set; }
        public HashSet<int> Tags { get; set; }

        public ReleaseProfile()
        {
            Tags = new HashSet<int>();
        }
    }
}

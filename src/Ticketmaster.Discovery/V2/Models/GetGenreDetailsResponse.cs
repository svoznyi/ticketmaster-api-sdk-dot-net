﻿using System.Collections.Generic;
using Ticketmaster.Core;

namespace Ticketmaster.Discovery.V2.Models
{
    public class GetGenreDetailsResponse : IdNamePair, IApiResponse
    {
        public Links Links { get; set; }

        public EmbeddedData _embedded { get; set; }

        public class EmbeddedData
        {
            public EmbeddedData()
            {
                SubGenres = new List<SubGenresData>();
            }

            public IEnumerable<SubGenresData> SubGenres { get; set; }

            public class SubGenresData : IdNamePair
            {
                public Links Links { get; set; }
            }
        }
    }
}

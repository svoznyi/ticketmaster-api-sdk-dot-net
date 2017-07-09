﻿namespace Ticketmaster.Discovery.V2.Models
{
    using System.Collections.Generic;

    public class GetEventImagesResponse : IDiscoveryApiRespond
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public List<Image> Images { get; set; }
        public Links Links { get; set; }
    }
}
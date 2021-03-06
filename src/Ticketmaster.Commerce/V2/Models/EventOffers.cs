﻿namespace Ticketmaster.Commerce.V2.Models
{
    using System.Collections.Generic;
    using Core;

    /// <summary>
    /// The Event Offers Api Respond class.
    /// </summary>
    /// <seealso cref="Ticketmaster.Core.IApiResponse" />
    public class EventOffers : IApiResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventOffers"/> class.
        /// </summary>
        public EventOffers()
        {
            Offers = new List<Offer>();
        }

        /// <summary>
        /// Gets or sets the <see cref="Limits"/> limits.
        /// </summary>
        /// <value>
        /// The <see cref="Limits"/> limits.
        /// </value>
        public Limits Limits { get; set; }

        /// <summary>
        /// Gets or sets  <see cref="Prices"/> prices.
        /// </summary>
        /// <value>
        /// The <see cref="Prices"/> prices.
        /// </value>
        public Prices Prices { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="MetaDataClass"/> meta data.
        /// </summary>
        /// <value>
        /// The meta data.
        /// </value>
        public MetaDataClass MetaData { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="List{Offer}"/> offers.
        /// </summary>
        /// <value>
        /// The <see cref="List{Offer}"/> offers.
        /// </value>
        public List<Offer> Offers { get; set; }

        /// <summary>
        /// Gets or sets the embedded <see cref="EmbeddedDataClass"/> object.
        /// </summary>
        /// <value>
        /// The embedded <see cref="EmbeddedDataClass"/> object.
        /// </value>
        public EmbeddedDataClass _embedded { get; set; }

        /// <summary>
        /// The Class for MetaData for <see cref="EventOffers"/>
        /// </summary>
        public class MetaDataClass
        {
            /// <summary>
            /// Gets or sets the <see cref="EventMapping"/> event mapping.
            /// </summary>
            /// <value>
            /// The <see cref="EventMapping"/> event mapping.
            /// </value>
            public EventMapping EventMapping { get; set; }
        }

        /// <summary>
        /// The class for Embedded field.
        /// </summary>
        public class EmbeddedDataClass
        {
            public DataCollection<Price> PriceZones { get; set; }
            public DataCollection<EmbeddedData> Areas { get; set; }
            public DataCollection<AttributesClass> AttributesRefs { get; set; }
            public DataCollection<EmbeddedData> Passwords { get; set; }
        }
    }
}

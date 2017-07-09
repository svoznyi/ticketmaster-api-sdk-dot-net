﻿namespace Ticketmaster.Discovery.V2.Models
{
    using System.Collections.Generic;

    public class SearchVenuesRequest : BaseQuery<SearchVenuesQueryParameters>
    {
        public override void AddQueryParameter(KeyValuePair<SearchVenuesQueryParameters, string> parameter)
        {
            ParametersDictionary.Add(parameter.Key.ToString(), parameter.Value);
        }
    }
}
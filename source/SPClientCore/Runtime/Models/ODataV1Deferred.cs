//
// Copyright (c) 2020 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/SPClientCore/blob/master/LICENSE
//

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Runtime.Models
{

    [JsonObject()]
    public class ODataV1Deferred
    {

        public ODataV1Deferred()
        {
        }

        public ODataV1Deferred(Uri uri)
        {
            this.Uri = uri;
        }

        [JsonProperty("uri")]
        public Uri Uri { get; private set; }

    }

}

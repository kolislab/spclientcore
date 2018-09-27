﻿//
// Copyright (c) 2018 karamem0
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

namespace Karamem0.SharePoint.PowerShell.Models.Core
{

    [JsonObject(Id = "SP.SPDataLeakagePreventionStatusInfo")]
    public class DataLeakagePreventionStatusInfo : ClientObject
    {

        public DataLeakagePreventionStatusInfo()
        {
        }

        [JsonProperty()]
        public bool? ContainsConfidentialInfo { get; private set; }

        [JsonProperty()]
        public string ContainsConfidentialInfoLearnMoreUrl { get; private set; }

        [JsonProperty()]
        public bool? ExternalSharingTipsEnabled { get; private set; }

        [JsonProperty()]
        public bool? ExternalSharingTipsLearnMoreUrl { get; private set; }

    }

}
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

namespace Karamem0.SharePoint.PowerShell.Models
{

    [JsonObject(Id = "SP.FieldUrlValue")]
    public class FieldUrlValue : ClientValueObject
    {

        public FieldUrlValue()
        {
        }

        public FieldUrlValue(string url, string description)
        {
            this.Url = url;
            this.Description = description;
        }

        [JsonProperty()]
        public string Description { get; private set; }

        [JsonProperty()]
        public string Url { get; private set; }

    }

}

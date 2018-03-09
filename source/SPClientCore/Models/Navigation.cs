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

    [JsonObject(Id = "SP.Navigation")]
    public class Navigation : ClientObject
    {

        public Navigation()
        {
        }

        [JsonProperty()]
        public ClientObjectCollection<NavigationNode> QuickLaunch { get; private set; }

        [JsonProperty()]
        public ClientObjectCollection<NavigationNode> TopNavigationBar { get; private set; }

        [JsonProperty()]
        public bool? UseShared { get; private set; }

    }

}

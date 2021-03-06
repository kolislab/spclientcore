//
// Copyright (c) 2020 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/SPClientCore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Runtime.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Models
{

    [JsonObject()]
    public class Drive : ODataV2Object
    {

        public Drive()
        {
        }

        [JsonProperty("createdDateTime")]
        public virtual DateTime Created { get; protected set; }

        [JsonProperty("createdBy")]
        public virtual IdentitySet CreatedBy { get; protected set; }

        [JsonProperty("description")]
        public virtual string Description { get; protected set; }

        [JsonProperty("driveType")]
        public virtual DriveType DriveType { get; protected set; }

        [JsonProperty("id")]
        public virtual string Id { get; protected set; }

        [JsonProperty("lastModifiedDateTime")]
        public virtual DateTime LastModified { get; protected set; }

        [JsonProperty("lastModifiedBy")]
        public virtual IdentitySet LastModifiedBy { get; protected set; }

        [JsonProperty("name")]
        public virtual string Name { get; protected set; }

        [JsonProperty("owner")]
        public virtual IdentitySet Owner { get; protected set; }

        [JsonProperty("quota")]
        public virtual Quota Quota { get; protected set; }

        [JsonProperty("webUrl")]
        public virtual string WebUrl { get; protected set; }

    }

}

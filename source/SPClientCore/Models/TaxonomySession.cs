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

    [ClientObject(Name = "SP.Taxonomy.TaxonomySession", Id = "{981cbc68-9edc-4f8d-872f-71146fcbb84f}")]
    [JsonObject()]
    public class TaxonomySession : ClientObject
    {

        public TaxonomySession()
        {
        }

    }

}

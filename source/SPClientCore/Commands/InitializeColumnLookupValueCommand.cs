//
// Copyright (c) 2020 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/SPClientCore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("Initialize", "KshColumnLookupValue")]
    [OutputType(typeof(ColumnLookupValue))]
    public class InitializeColumnLookupValueCommand : ClientObjectCmdlet
    {

        public InitializeColumnLookupValueCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0)]
        public int LookupId { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(new ColumnLookupValue(this.LookupId, null));
        }

    }

}

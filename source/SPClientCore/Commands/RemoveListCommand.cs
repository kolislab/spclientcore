//
// Copyright (c) 2019 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/SPClientCore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Resources;
using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using Karamem0.SharePoint.PowerShell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("Remove", "KshList")]
    [OutputType(typeof(void))]
    public class RemoveListCommand : ClientObjectCmdlet<IListService>
    {

        public RemoveListCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true, ParameterSetName = "ParamSet1")]
        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true, ParameterSetName = "ParamSet2")]
        public List Identity { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ParamSet2")]
        public SwitchParameter Force { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.ParameterSetName == "ParamSet1")
            {
                this.WriteObject(this.Service.RecycleObject(this.Identity));
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                if (this.Force)
                {
                    this.Service.RemoveObject(this.Identity);
                }
                else
                {
                    throw new ArgumentException(
                        string.Format(StringResources.ErrorValueCannotBeValue, false),
                        nameof(this.Force));
                }
            }
        }

    }

}
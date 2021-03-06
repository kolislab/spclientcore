//
// Copyright (c) 2020 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/SPClientCore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Runtime.Commands;
using Karamem0.SharePoint.PowerShell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("Get", "KshAppInstance")]
    [OutputType(typeof(AppInstance))]
    public class GetAppInstanceCommand : ClientObjectCmdlet<IAppInstanceService>
    {

        public GetAppInstanceCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true, ParameterSetName = "ParamSet1")]
        public AppInstance Identity { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet2")]
        public Guid AppInstanceId { get; private set; }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ParamSet3")]
        public Guid AppProductId { get; private set; }

        [Parameter(Mandatory = false, ParameterSetName = "ParamSet3")]
        [Parameter(Mandatory = false, ParameterSetName = "ParamSet4")]
        public SwitchParameter NoEnumerate { get; private set; }

        protected override void ProcessRecordCore()
        {
            if (this.ParameterSetName == "ParamSet1")
            {
                this.WriteObject(this.Service.GetObject(this.Identity.Id));
            }
            if (this.ParameterSetName == "ParamSet2")
            {
                this.WriteObject(this.Service.GetObject(this.AppInstanceId));
            }
            if (this.ParameterSetName == "ParamSet3")
            {
                this.WriteObject(this.Service.GetObjectEnumerable(this.AppProductId), this.NoEnumerate ? false : true);
            }
            if (this.ParameterSetName == "ParamSet4")
            {
                this.WriteObject(this.Service.GetObjectEnumerable(), this.NoEnumerate ? false : true);
            }
        }

    }

}

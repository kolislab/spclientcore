﻿//
// Copyright (c) 2018 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/SPClientCore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models.Core;
using Karamem0.SharePoint.PowerShell.Models.OData;
using Karamem0.SharePoint.PowerShell.PipeBinds.Core;
using Karamem0.SharePoint.PowerShell.Resources;
using Karamem0.SharePoint.PowerShell.Services;
using Karamem0.SharePoint.PowerShell.Services.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands.Core
{

    [Cmdlet("Get", "SPWeb")]
    [OutputType(typeof(Web))]
    public class GetWebCommand : PSCmdlet
    {

        public GetWebCommand()
        {
        }

        [Parameter(Mandatory = false, Position = 0, ValueFromPipeline = true)]
        public WebPipeBind Web { get; private set; }

        [Parameter(Mandatory = false)]
        public string[] Includes { get; private set; }

        protected override void ProcessRecord()
        {
            if (ClientObjectService.ServiceProvider == null)
            {
                throw new InvalidOperationException(StringResources.ErrorNotConnected);
            }
            var webService = ClientObjectService.ServiceProvider.GetService<IWebService>();
            var webQuery = ODataQuery.Create<Web>(this.MyInvocation.BoundParameters);
            if (this.Web == null)
            {
                this.WriteObject(webService.GetWeb(null, webQuery));
            }
            else
            {
                this.WriteObject(webService.GetWeb(this.Web, webQuery));
            }
        }

    }

}

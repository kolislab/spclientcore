﻿//
// Copyright (c) 2018 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/SPClientCore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Models.OData;
using Karamem0.SharePoint.PowerShell.Resources;
using Karamem0.SharePoint.PowerShell.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Commands
{

    [Cmdlet("Get", "SPWebTemplate")]
    [OutputType(typeof(WebTemplate))]
    public class GetWebTemplateCommand : PSCmdlet
    {

        public GetWebTemplateCommand()
        {
        }

        [Parameter(Mandatory = true)]
        public string Name { get; private set; }

        [Parameter(Mandatory = true)]
        public uint? LCID { get; private set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter DoIncludeCrossLanguage { get; private set; }

        [Parameter(Mandatory = false)]
        public string[] Includes { get; private set; }

        protected override void ProcessRecord()
        {
            if (ClientObjectService.ServiceProvider == null)
            {
                throw new InvalidOperationException(StringResources.ErrorNotConnected);
            }
            var webService = ClientObjectService.ServiceProvider.GetService<IWebService>();
            var webTemplateQuery = ODataQuery.Create<WebTemplate>(this.MyInvocation.BoundParameters);
            this.WriteObject(webService.GetWebTemplate(this.Name, this.LCID, this.DoIncludeCrossLanguage, webTemplateQuery));
        }

    }

}

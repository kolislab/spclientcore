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

    [Cmdlet("Find", "SPContentType", DefaultParameterSetName = "Web")]
    [OutputType(typeof(ContentType[]))]
    public class FindContentTypeCommand : ClientObjectCmdlet
    {

        public FindContentTypeCommand()
        {
        }

        [Parameter(Mandatory = true, ParameterSetName = "List", Position = 0)]
        public ListPipeBind List { get; private set; }

        [Parameter(Mandatory = false)]
        public string[] Includes { get; private set; }

        [Parameter(Mandatory = false)]
        public string[] OrderBy { get; private set; }

        [Parameter(Mandatory = false)]
        public int? Top { get; private set; }

        [Parameter(Mandatory = false)]
        public int? Skip { get; private set; }

        [Parameter(Mandatory = false)]
        public string Filter { get; private set; }

        protected override void ProcessRecord()
        {
            if (ClientObjectService.ServiceProvider == null)
            {
                throw new InvalidOperationException(StringResources.ErrorNotConnected);
            }
            var contentTypeService = ClientObjectService.ServiceProvider.GetService<IContentTypeService>();
            var contentTypeQuery = ODataQuery.Create<ContentType>(this.MyInvocation.BoundParameters);
            if (this.List == null)
            {
                this.WriteObject(contentTypeService.FindContentTypes(contentTypeQuery), true);
            }
            else
            {
                var listService = ClientObjectService.ServiceProvider.GetService<IListService>();
                var list = listService.GetList(this.List);
                this.WriteObject(contentTypeService.FindContentTypes(list.Id, contentTypeQuery), true);
            }
        }

    }

}

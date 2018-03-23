﻿//
// Copyright (c) 2018 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/SPClientCore/blob/master/LICENSE
//

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

    [Cmdlet("Stop", "SPRoleInheritance", DefaultParameterSetName = "ByWeb")]
    [OutputType(typeof(void))]
    public class StopRoleInheritanceCommand : PSCmdlet
    {

        public StopRoleInheritanceCommand()
        {
        }

        [Parameter(Mandatory = true, ParameterSetName = "ByList")]
        [Parameter(Mandatory = true, ParameterSetName = "ByListItem")]
        public ListPipeBind List { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ByListItem")]
        public ListItemPipeBind ListItem { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ByWeb")]
        [Parameter(Mandatory = true, ParameterSetName = "ByList")]
        [Parameter(Mandatory = true, ParameterSetName = "ByListItem")]
        public SwitchParameter CopyRoleAssignments { get; private set; }

        [Parameter(Mandatory = true, ParameterSetName = "ByWeb")]
        [Parameter(Mandatory = true, ParameterSetName = "ByList")]
        [Parameter(Mandatory = true, ParameterSetName = "ByListItem")]
        public SwitchParameter ClearSubscopes { get; private set; }

        protected override void ProcessRecord()
        {
            if (ClientObjectService.ServiceProvider == null)
            {
                throw new InvalidOperationException(StringResources.ErrorNotConnected);
            }
            if (this.ParameterSetName == "ByWeb")
            {
                var webService = ClientObjectService.ServiceProvider.GetService<IWebService>();
                webService.BreakWebRoleInheritance(this.CopyRoleAssignments, this.ClearSubscopes);
            }
            if (this.ParameterSetName == "ByList")
            {
                var listService = ClientObjectService.ServiceProvider.GetService<IListService>();
                var list = listService.GetList(this.List);
                listService.BreakListRoleInheritance(list.Id, this.CopyRoleAssignments, this.ClearSubscopes);
            }
            if (this.ParameterSetName == "ByListItem")
            {
                var listItemService = ClientObjectService.ServiceProvider.GetService<IListItemService>();
                var listService = ClientObjectService.ServiceProvider.GetService<IListService>();
                var list = listService.GetList(this.List);
                var listItem = listItemService.GetListItem(list.Id, this.ListItem);
                listItemService.BreakListItemRoleInheritance(list.Id, listItem.Id, this.CopyRoleAssignments, this.ClearSubscopes);
            }
        }

    }

}
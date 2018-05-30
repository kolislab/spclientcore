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

    [Cmdlet("New", "SPFolder")]
    [OutputType(typeof(Folder))]
    public class NewFolderCommand : PSCmdlet
    {

        public NewFolderCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0)]
        public FolderPipeBind Folder { get; private set; }

        [Parameter(Mandatory = true)]
        public string Name { get; private set; }

        [Parameter(Mandatory = false)]
        public string[] Includes { get; private set; }

        protected override void ProcessRecord()
        {
            if (ClientObjectService.ServiceProvider == null)
            {
                throw new InvalidOperationException(StringResources.ErrorNotConnected);
            }
            var folderService = ClientObjectService.ServiceProvider.GetService<IFolderService>();
            var folderQuery = ODataQuery.Create<Folder>(this.MyInvocation.BoundParameters);
            var folder = folderService.GetFolder(this.Folder);
            this.WriteObject(folderService.CreateFolder(folder.ServerRelativeUrl, this.Name, folderQuery));
        }

    }

}

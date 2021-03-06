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

    [Cmdlet("New", "KshFolder")]
    [OutputType(typeof(Folder))]
    public class NewFolderCommand : ClientObjectCmdlet<IFolderService>
    {

        public NewFolderCommand()
        {
        }

        [Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
        public Folder Folder { get; private set; }

        [Parameter(Mandatory = true)]
        public string FolderName { get; private set; }

        protected override void ProcessRecordCore()
        {
            this.WriteObject(this.Service.CreateObject(this.Folder, this.FolderName));
        }

    }

}

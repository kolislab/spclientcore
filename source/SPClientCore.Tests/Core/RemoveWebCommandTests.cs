﻿//
// Copyright (c) 2018 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/SPClientCore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models.Core;
using Karamem0.SharePoint.PowerShell.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Core.Tests
{


    [TestClass()]
    [TestCategory("Web")]
    public class RemoveWebCommandTests
    {

        [TestMethod()]
        public void RemoveWeb()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand<Web>(
                    "New-SPWeb",
                    new Dictionary<string, object>()
                    {
                        { "Url", "TestWeb0" }
                    }
                );
                var result2 = context.Runspace.InvokeCommand<Web>(
                    "Select-SPWeb",
                    new Dictionary<string, object>()
                    {
                        { "Web", result1.ElementAt(0).Id }
                    }
                );
                var result3 = context.Runspace.InvokeCommand(
                    "Remove-SPWeb",
                    new Dictionary<string, object>()
                    {
                    }
                );
            }
        }

    }

}
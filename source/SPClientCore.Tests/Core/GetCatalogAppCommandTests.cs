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
    [TestCategory("CatalogApp")]
    public class GetCatalogAppCommandTests
    {

        [TestMethod()]
        public void GetSiteCatalogApp()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand<CatalogApp>(
                    "Get-SPCatalogApp",
                    new Dictionary<string, object>()
                    {
                        { "CatalogApp", context.AppSettings["App1Id"] },
                        { "Scope", "Site" }
                    }
                );
                var actual = result1.ElementAt(0);
            }
        }

    }

}

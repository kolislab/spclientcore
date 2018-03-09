﻿//
// Copyright (c) 2018 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/SPClientCore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Tests
{

    [TestClass()]
    [TestCategory("View")]
    public class FindViewCommandTests
    {

        [TestMethod()]
        public void FindViews()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand<View>(
                    "Find-SPView",
                    new Dictionary<string, object>()
                    {
                        { "List", context.AppSettings["List1Id"] },
                        { "OrderBy", "Title desc" },
                        { "Top", 1 },
                        { "Skip", 1 }
                    }
                );
                var actual = result1.ToArray();
            }
        }

    }

}

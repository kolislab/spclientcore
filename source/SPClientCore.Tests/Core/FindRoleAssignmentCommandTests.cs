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
    public class FindRoleAssignmentCommandTests
    {

        [TestMethod()]
        [TestCategory("Web")]
        public void SkipAndTakeWebRoleAssignments()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand<RoleAssignment>(
                    "Find-SPRoleAssignment",
                    new Dictionary<string, object>()
                    {
                        { "OrderBy", "PrincipalId desc" },
                        { "Top", 1 },
                        { "Skip", 1 }
                    }
                );
                var actual = result1.ToArray();
            }
        }

        [TestMethod()]
        [TestCategory("List")]
        public void SkipAndTakeListRoleAssignments()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand<RoleAssignment>(
                    "Find-SPRoleAssignment",
                    new Dictionary<string, object>()
                    {
                        { "List", context.AppSettings["List1Id"] },
                        { "OrderBy", "PrincipalId desc" },
                        { "Top", 1 },
                        { "Skip", 1 }
                    }
                );
                var actual = result1.ToArray();
            }
        }

        [TestMethod()]
        [TestCategory("ListItem")]
        public void SkipAndTakeListItemRoleAssignments()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand<RoleAssignment>(
                    "Find-SPRoleAssignment",
                    new Dictionary<string, object>()
                    {
                        { "List", context.AppSettings["List1Id"] },
                        { "ListItem", context.AppSettings["ListItem1Id"] },
                        { "OrderBy", "PrincipalId desc" },
                        { "Top", 1 },
                        { "Skip", 1 }
                    }
                );
                var actual = result1.ToArray();
            }
        }

        [TestMethod()]
        [TestCategory("Web")]
        public void FilterWebRoleAssignments()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand<RoleAssignment>(
                    "Find-SPRoleAssignment",
                    new Dictionary<string, object>()
                    {
                        { "Filter", "PrincipalId eq " + context.AppSettings["Group2Id"] }
                    }
                );
                var actual = result1.ToArray();
            }
        }

        [TestMethod()]
        [TestCategory("List")]
        public void FilterListRoleAssignments()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand<RoleAssignment>(
                    "Find-SPRoleAssignment",
                    new Dictionary<string, object>()
                    {
                        { "List", context.AppSettings["List1Id"] },
                        { "Filter", "PrincipalId eq " + context.AppSettings["Group2Id"] }
                    }
                );
                var actual = result1.ToArray();
            }
        }

        [TestMethod()]
        [TestCategory("ListItem")]
        public void FilterListItemRoleAssignments()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand<RoleAssignment>(
                    "Find-SPRoleAssignment",
                    new Dictionary<string, object>()
                    {
                        { "List", context.AppSettings["List1Id"] },
                        { "ListItem", context.AppSettings["ListItem1Id"] },
                        { "Filter", "PrincipalId eq " + context.AppSettings["Group2Id"] }
                    }
                );
                var actual = result1.ToArray();
            }
        }

    }

}

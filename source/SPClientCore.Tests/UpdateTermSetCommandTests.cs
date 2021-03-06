//
// Copyright (c) 2020 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/SPClientCore/blob/master/LICENSE
//

using Karamem0.SharePoint.PowerShell.Models;
using Karamem0.SharePoint.PowerShell.Tests.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Tests
{

    [TestClass()]
    [TestCategory("Update-KshTermSet")]
    public class UpdateTermSetCommandTests
    {

        [TestMethod()]
        public void UpdateTermSet()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["AuthorityUrl"] + context.AppSettings["Site1Url"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result2 = context.Runspace.InvokeCommand<TermGroup>(
                    "Get-KshTermGroup",
                    new Dictionary<string, object>()
                    {
                        { "TermGroupId", context.AppSettings["TermGroup1Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<TermSet>(
                    "New-KshTermSet",
                    new Dictionary<string, object>()
                    {
                        { "TermGroup", result2.ElementAt(0) },
                        { "Lcid", 1033 },
                        { "Name", "Test Term Set 0" }
                    }
                );
                var result4 = context.Runspace.InvokeCommand<TermSet>(
                    "Update-KshTermSet",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result3.ElementAt(0) },
                        { "Contact", "admin@example.com" },
                        { "Description", "Test Term Set 9" },
                        { "IsAvailableForTagging", true },
                        { "IsOpenForTermCreation", true },
                        { "Name", "Test Term Set 9" },
                        { "Owner", context.AppSettings["User1LoginName"] },
                        { "PassThru", true }
                    }
                );
                var result5 = context.Runspace.InvokeCommand(
                    "Remove-KshTermSet",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result4.ElementAt(0) }
                    }
                );
                var actual = result4.ElementAt(0);
            }
        }

    }

}

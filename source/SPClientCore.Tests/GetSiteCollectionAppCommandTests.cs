//
// Copyright (c) 2019 karamem0
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
    [TestCategory("Get-KshSiteCollectionApp")]
    public class GetSiteCollectionAppCommandTests
    {

        [TestMethod()]
        public void GetSiteCollectionApps()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["BaseUrl"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result2 = context.Runspace.InvokeCommand<App>(
                    "Get-KshSiteCollectionApp",
                    new Dictionary<string, object>()
                    {
                    }
                );
                var actual = result2.ToArray();
            }
        }

        [TestMethod()]
        public void GetSiteCollectionAppByApp()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["BaseUrl"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result2 = context.Runspace.InvokeCommand<App>(
                    "Get-KshSiteCollectionApp",
                    new Dictionary<string, object>()
                    {
                        { "AppId", context.AppSettings["App1Id"] }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<App>(
                    "Get-KshSiteCollectionApp",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetSiteCollectionAppByAppId()
        {
            using (var context = new PSCmdletContext())
            {
                var result1 = context.Runspace.InvokeCommand(
                    "Connect-KshSite",
                    new Dictionary<string, object>()
                    {
                        { "Url", context.AppSettings["BaseUrl"] },
                        { "Credential", PSCredentialFactory.CreateCredential(
                            context.AppSettings["LoginUserName"],
                            context.AppSettings["LoginPassword"])
                        }
                    }
                );
                var result2 = context.Runspace.InvokeCommand<App>(
                    "Get-KshSiteCollectionApp",
                    new Dictionary<string, object>()
                    {
                        { "AppId", context.AppSettings["App1Id"] }
                    }
                );
                var actual = result2.ElementAt(0);
            }
        }

    }

}
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
    [TestCategory("Get-KshSiteCollectionFeature")]
    public class GetSiteCollectionFeatureCommandTests
    {

        [TestMethod()]
        public void GetSiteCollectionFeatures()
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
                var result2 = context.Runspace.InvokeCommand<Feature>(
                    "Get-KshSiteCollectionFeature",
                    new Dictionary<string, object>()
                    {
                    }
                );
                var actual = result2.ToArray();
            }
        }

        [TestMethod()]
        public void GetSiteCollectionFeatureByIdentity()
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
                var result2 = context.Runspace.InvokeCommand<Feature>(
                    "Get-KshSiteCollectionFeature",
                    new Dictionary<string, object>()
                    {
                        { "FeatureId", "00bfea71-1c5e-4a24-b310-ba51c3eb7a57" }
                    }
                );
                var result3 = context.Runspace.InvokeCommand<Feature>(
                    "Get-KshSiteCollectionFeature",
                    new Dictionary<string, object>()
                    {
                        { "Identity", result2.ElementAt(0) }
                    }
                );
                var actual = result3.ElementAt(0);
            }
        }

        [TestMethod()]
        public void GetSiteCollectionFeatureByFeatureId()
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
                var result2 = context.Runspace.InvokeCommand<Feature>(
                    "Get-KshSiteCollectionFeature",
                    new Dictionary<string, object>()
                    {
                        { "FeatureId", "00bfea71-1c5e-4a24-b310-ba51c3eb7a57" }
                    }
                );
                var actual = result2.ElementAt(0);
            }
        }

    }

}

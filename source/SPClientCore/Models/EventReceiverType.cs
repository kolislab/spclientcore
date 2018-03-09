﻿//
// Copyright (c) 2018 karamem0
//
// This software is released under the MIT License.
//
// https://github.com/karamem0/SPClientCore/blob/master/LICENSE
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karamem0.SharePoint.PowerShell.Models
{

    public enum EventReceiverType
    {

        InvalidReceiver = -1,

        ItemAdding = 1,

        ItemUpdating = 2,

        ItemDeleting = 3,

        ItemCheckingIn = 4,

        ItemCheckingOut = 5,

        ItemUncheckingOut = 6,

        ItemAttachmentAdding = 7,

        ItemAttachmentDeleting = 8,

        ItemFileMoving = 9,

        ItemVersionDeleting = 11,

        FieldAdding = 101,

        FieldUpdating = 102,

        FieldDeleting = 103,

        ListAdding = 104,

        ListDeleting = 105,

        SiteDeleting = 201,

        WebDeleting = 202,

        WebMoving = 203,

        WebAdding = 204,

        GroupAdding = 301,

        GroupUpdating = 302,

        GroupDeleting = 303,

        GroupUserAdding = 304,

        GroupUserDeleting = 305,

        RoleDefinitionAdding = 306,

        RoleDefinitionUpdating = 307,

        RoleDefinitionDeleting = 308,

        RoleAssignmentAdding = 309,

        RoleAssignmentDeleting = 310,

        InheritanceBreaking = 311,

        InheritanceResetting = 312,

        WorkflowStarting = 501,

        ItemAdded = 10001,

        ItemUpdated = 10002,

        ItemDeleted = 10003,

        ItemCheckedIn = 10004,

        ItemCheckedOut = 10005,

        ItemUncheckedOut = 10006,

        ItemAttachmentAdded = 10007,

        ItemAttachmentDeleted = 10008,

        ItemFileMoved = 10009,

        ItemFileConverted = 10010,

        ItemVersionDeleted = 10011,

        FieldAdded = 10101,

        FieldUpdated = 10102,

        FieldDeleted = 10103,

        ListAdded = 10104,

        ListDeleted = 10105,

        SiteDeleted = 10201,

        WebDeleted = 10202,

        WebRestored = 10205,

        WebMoved = 10203,

        WebProvisioned = 10204,

        GroupAdded = 10301,

        GroupUpdated = 10302,

        GroupDeleted = 10303,

        GroupUserAdded = 10304,

        GroupUserDeleted = 10305,

        RoleDefinitionAdded = 10306,

        RoleDefinitionUpdated = 10307,

        RoleDefinitionDeleted = 10308,

        RoleAssignmentAdded = 10309,

        RoleAssignmentDeleted = 10310,

        InheritanceBroken = 10311,

        InheritanceReset = 10312,

        WorkflowStarted = 10501,

        WorkflowPostponed = 10502,

        WorkflowCompleted = 10503,

        EntityInstanceAdded = 10601,

        EntityInstanceUpdated = 10602,

        EntityInstanceDeleted = 10603,

        AppInstalled = 10701,

        AppUpgraded = 10702,

        AppUninstalling = 10703,

        EmailReceived = 20000,

        ContextEvent = 32766,

    }

}

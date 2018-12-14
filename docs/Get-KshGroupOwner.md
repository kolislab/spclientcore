---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshGroupOwner

## SYNOPSIS
Retrieves a group owner.

## SYNTAX

```
Get-KshGroupOwner [-Group] <Group> [<CommonParameters>]
```

## DESCRIPTION
Get-KshGroupOwner cmdlet retrives the user or group that is the owner of the group.

## EXAMPLES

### Example 1
```powershell
PS C:\> $owner = Get-KshGroupOwner -Group 'Blog Owners'
```

Retrieves a group owner.

## PARAMETERS

### -Group
Specifies the group.

```yaml
Type: Group
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.Group

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.Principal

## NOTES

## RELATED LINKS
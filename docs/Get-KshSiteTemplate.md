---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshSiteTemplate

## SYNOPSIS
Retrieves a site template.

## SYNTAX

### ParamSet1
```
Get-KshSiteTemplate [-SiteTemplateName] <String> [-IncludeCrossLanguage] [[-Lcid] <UInt32>]
 [<CommonParameters>]
```

### ParamSet2
```
Get-KshSiteTemplate [-IncludeCrossLanguage] [[-Lcid] <UInt32>] [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshListTemplate cmdlet retrives site templates of the current site.

## EXAMPLES

### Example 1
```powershell
PS C:\> Find-KshSiteTemplate -DoIncludeCrossLanguage -Lcid 1033
```

Retrieves all site templates.

## PARAMETERS

### -IncludeCrossLanguage
If specified, includes cross language site templates.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Lcid
Specifies the locale ID.
For more information, see [reference](https://msdn.microsoft.com/en-us/library/cc233965.aspx).

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: False
Position: 2
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteTemplateName
{{ Fill SiteTemplateName Description }}

```yaml
Type: String
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.SiteTemplate

## NOTES

## RELATED LINKS
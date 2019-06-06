---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshSiteCollectionAppCatalog

## SYNOPSIS
Retrieves one or more site collection app catalogs.

## SYNTAX

### ParamSet1
```
Get-KshSiteCollectionAppCatalog [-SiteCollection] <SiteCollection> [<CommonParameters>]
```

### ParamSet2
```
Get-KshSiteCollectionAppCatalog [-SiteCollectionUrl] <Uri> [<CommonParameters>]
```

### ParamSet3
```
Get-KshSiteCollectionAppCatalog [-NoEnumerate] [<CommonParameters>]
```

## DESCRIPTION
The Get-KshSiteCollectionFeature cmdlet retrieves site collection app catalogs in the tenant.

## EXAMPLES

### Example 1
```powershell
PS C:\> $siteCollection = Get-KshCurrentSiteCollection
PS C:\> $siteCollectionAppCatalog = Get-KshSiteCollectionAppCatalog -SiteCollection $siteCollection
```

Retrieves a site collection app catalog.

### Example 2
```powershell
PS C:\> $siteCollectionAppCatalogs = Get-KshSiteCollectionAppCatalog
```

Retrieves all site collection app catalogs.

## PARAMETERS

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteCollection
Specifies the site collection.

```yaml
Type: SiteCollection
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SiteCollectionUrl
Specifies the site collection URL.

```yaml
Type: Uri
Parameter Sets: ParamSet2
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

### Karamem0.SharePoint.PowerShell.Models.SiteCollection

### System.Uri

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.SiteCollectionAppCatalog

## NOTES

## RELATED LINKS
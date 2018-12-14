---
external help file: SPClientCore.dll-Help.xml
Module Name: SPClientCore
online version:
schema: 2.0.0
---

# Get-KshListItem

## SYNOPSIS
Retrieves one or more list items.

## SYNTAX

### ParamSet1
```
Get-KshListItem [-Identity] <ListItem> [<CommonParameters>]
```

### ParamSet2
```
Get-KshListItem [-Folder] <Folder> [<CommonParameters>]
```

### ParamSet3
```
Get-KshListItem [-File] <File> [<CommonParameters>]
```

### ParamSet4
```
Get-KshListItem [-List] <List> [-ItemId] <Int32> [<CommonParameters>]
```

### ParamSet5
```
Get-KshListItem [-List] <List> [-FolderServerRelativeUrl <String>]
 [-ListItemCollectionPosition <ListItemCollectionPosition>] [-ViewXml <String>] [-NoEnumerate]
 [<CommonParameters>]
```

## DESCRIPTION
The Get-KshListItem cmdlet retrives list items of the list.

## EXAMPLES

### Example 1
```powershell
PS C:\> $folder = Get-KshFolder -FolderUrl '/sites/japan/hr/Shared%20Documents/Templates'
PS C:\> $listItem = Get-KshListItem -Folder $folder
```

Retrieves a list item from the folder.

### Example 2
```powershell
PS C:\> $file = Get-KshFile -FileUrl '/sites/japan/hr/Shared%20Documents/Readme.txt'
PS C:\> $listItem = Get-KshListItem -File $file
```

Retrieves a list item from the file.

### Example 3
```powershell
PS C:\> $list = Get-KshList -ListTitle 'Announcements'
PS C:\> $listItem = Get-KshListItem -List $list -ItemId 1
```

Retrieves a list item by list item ID.

### Example 4
```powershell
PS C:\> $list = Get-KshList -ListTitle 'Announcements'
PS C:\> $listItems = Get-KshListItem -List $list
```

Retrieves all list items. (This case, list items must be less than 5000.)

### Example 5
```powershell
PS C:\> $list = Get-KshList -ListTitle 'Announcements'
PS C:\> $listItems = Get-KshListItem -List $list -ViewXml '<View><RowLimit>10</RowLimit><View>'
```

Retrieves list items by CAML query.

## PARAMETERS

### -File
Specifies the file.

```yaml
Type: File
Parameter Sets: ParamSet3
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Folder
Specifies the folder.

```yaml
Type: Folder
Parameter Sets: ParamSet2
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -FolderServerRelativeUrl
Specifies the site relative URL of folder.

```yaml
Type: String
Parameter Sets: ParamSet5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Identity
Specifies the list item.

```yaml
Type: ListItem
Parameter Sets: ParamSet1
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ItemId
Specifies the list item ID.

```yaml
Type: Int32
Parameter Sets: ParamSet4
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -List
Specifies the list.

```yaml
Type: List
Parameter Sets: ParamSet4, ParamSet5
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListItemCollectionPosition
Specifies the starting position.

```yaml
Type: ListItemCollectionPosition
Parameter Sets: ParamSet5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoEnumerate
If specified, suppresses to enumerate objects.

```yaml
Type: SwitchParameter
Parameter Sets: ParamSet5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ViewXml
Specifies the CAML query XML representation.
For more information, see [reference](https://docs.microsoft.com/en-us/sharepoint/dev/schema/query-schema).

```yaml
Type: String
Parameter Sets: ParamSet5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Karamem0.SharePoint.PowerShell.Models.List

### System.Int32

## OUTPUTS

### Karamem0.SharePoint.PowerShell.Models.List

## NOTES

## RELATED LINKS
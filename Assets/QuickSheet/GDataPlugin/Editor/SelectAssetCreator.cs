using UnityEngine;
using UnityEditor;
using System.IO;
using UnityQuickSheet;

///
/// !!! Machine generated code !!!
/// 
public partial class GoogleDataAssetUtility
{
    [MenuItem("Assets/Create/Google/Select")]
    public static void CreateSelectAssetFile()
    {
        Select asset = CustomAssetUtility.CreateAsset<Select>();
        asset.SheetName = "겨울 저택";
        asset.WorksheetName = "Select";
        EditorUtility.SetDirty(asset);        
    }
    
}
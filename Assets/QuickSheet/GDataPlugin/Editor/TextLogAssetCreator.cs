using UnityEngine;
using UnityEditor;
using System.IO;
using UnityQuickSheet;

///
/// !!! Machine generated code !!!
/// 
public partial class GoogleDataAssetUtility
{
    [MenuItem("Assets/Create/Google/TextLog")]
    public static void CreateTextLogAssetFile()
    {
        TextLog asset = CustomAssetUtility.CreateAsset<TextLog>();
        asset.SheetName = "겨울 저택";
        asset.WorksheetName = "TextLog";
        EditorUtility.SetDirty(asset);        
    }
    
}
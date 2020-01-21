using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using GDataDB;
using GDataDB.Linq;

using UnityQuickSheet;

///
/// !!! Machine generated code !!!
///
[CustomEditor(typeof(TextLog))]
public class TextLogEditor : BaseGoogleEditor<TextLog>
{	    
    public override bool Load()
    {        
        TextLog targetData = target as TextLog;
        
        var client = new DatabaseClient("", "");
        string error = string.Empty;
        var db = client.GetDatabase(targetData.SheetName, ref error);	
        var table = db.GetTable<TextLogData>(targetData.WorksheetName) ?? db.CreateTable<TextLogData>(targetData.WorksheetName);
        
        List<TextLogData> myDataList = new List<TextLogData>();
        
        var all = table.FindAll();
        foreach(var elem in all)
        {
            TextLogData data = new TextLogData();
            
            data = Cloner.DeepCopy<TextLogData>(elem.Element);
            myDataList.Add(data);
        }
                
        targetData.dataArray = myDataList.ToArray();
        
        EditorUtility.SetDirty(targetData);
        AssetDatabase.SaveAssets();
        
        return true;
    }
}

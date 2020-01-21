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
[CustomEditor(typeof(Select))]
public class SelectEditor : BaseGoogleEditor<Select>
{	    
    public override bool Load()
    {        
        Select targetData = target as Select;
        
        var client = new DatabaseClient("", "");
        string error = string.Empty;
        var db = client.GetDatabase(targetData.SheetName, ref error);	
        var table = db.GetTable<SelectData>(targetData.WorksheetName) ?? db.CreateTable<SelectData>(targetData.WorksheetName);
        
        List<SelectData> myDataList = new List<SelectData>();
        
        var all = table.FindAll();
        foreach(var elem in all)
        {
            SelectData data = new SelectData();
            
            data = Cloner.DeepCopy<SelectData>(elem.Element);
            myDataList.Add(data);
        }
                
        targetData.dataArray = myDataList.ToArray();
        
        EditorUtility.SetDirty(targetData);
        AssetDatabase.SaveAssets();
        
        return true;
    }
}

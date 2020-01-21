using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Texts : MonoBehaviour
{
    public TextLog TextLogDB;
    
    public static Texts instance;
    private void Awake()
    {
        if (Texts.instance == null)
        {
            Texts.instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public string Set(int index)
    {
       
        return TextLogDB.dataArray[index].Textlog;

    }
    public string Up(int index)
    {
      
        return TextLogDB.dataArray[index].Textlog;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selects : MonoBehaviour
{
    // Start is called before the first frame update
    public Select SelectLog;

    public static Selects instance;
    private void Awake()
    {
        if (Selects.instance == null)
        {
            Selects.instance = this;
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

       return SelectLog.dataArray[index].Selectlog;

    }
    public string Move(int index)
    {

        return SelectLog.dataArray[index].Movescene;

    }



}

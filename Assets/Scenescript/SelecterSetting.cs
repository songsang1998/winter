using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelecterSetting : MonoBehaviour
{
    public Text maintext;
    public int textnumber;
    public string movename;
    // Start is called before the first frame update
    void Start()
    {
       
        maintext.text = SelectsCode.instance.Set(textnumber);

       

    }
    // Update is called once per frame
    public void Move()
    {
        movename = SelectsCode.instance.Move(textnumber);
        SceneManager.LoadScene(movename);
    }
}

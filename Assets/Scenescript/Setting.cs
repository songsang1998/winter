using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Setting : MonoBehaviour
{
    public Text maintext;
    string otext;
    string stext;
    public bool skip = false;
    // Start is called before the first frame update
    void Start()
    {
     int textnumber= GameObject.Find("Manager").GetComponent<Scenemove>().scenenumber;
       otext=Texts.instance.Set(textnumber);

        StartCoroutine("TypingAction");

    }

    // Update is called once per frame
    IEnumerator TypingAction()
    {
        for (int i = 0; i < otext.Length; i++)
        {

            yield return new WaitForSeconds(0.035f);

            stext += otext.Substring(0, i);
            maintext.text = stext;
           stext = "";
            if (skip == true)
            {
                break;
            }
        }
        maintext.text=otext;
        yield return new WaitForSeconds(0.2f);
        Imageon();
    }

    void Imageon()
    {
        GameObject.Find("maintext").transform.Find("See").gameObject.SetActive(true);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Setting : MonoBehaviour
{
    public Text maintext;
    string otext;
    string stext;
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
            if (Input.GetKeyDown(KeyCode.F))
            {
                maintext.text = otext;
                break;
                
            }
        }
        yield return new WaitForSeconds(0.2f);
        Imageon();
    }

    void Imageon()
    {
        GameObject.Find("maintext").transform.Find("Select and Image").gameObject.SetActive(true);
    }
}


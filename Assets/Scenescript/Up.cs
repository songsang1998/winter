using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Up : MonoBehaviour
{
    int textnumber;
    // Start is called before the first frame update
    public void Ups()
    {
        int j =GameObject.Find("Manager").GetComponent<Scenemove>().scenenumber += 1;
        SceneManager.LoadScene(j);

    }

    // Update is called once per frame
 
}

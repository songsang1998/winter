using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemove : MonoBehaviour
{



    public int scenenumber;
  
    // Start is called before the first frame update
    void Start()
    {

      
        scenenumber = SceneManager.GetActiveScene().buildIndex;

    }

    // Update is called once per frame
    private void Update()
    {
   
    }
 
    
}

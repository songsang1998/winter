using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class ImageCode : MonoBehaviour
{
    public Sprite[] sprites;
    private Image s;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        s = GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        s.sprite = sprites[1];
    }
}

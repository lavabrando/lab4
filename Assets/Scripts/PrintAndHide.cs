using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 3;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i++;
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log(gameObject.name+":"+i);
        i++; 
    }
}

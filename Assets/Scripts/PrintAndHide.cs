using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 3;
    public Renderer rend;
    int RandomNumber;
    // Start is called before the first frame update
    void Start()
    {
        i++;
        RandomNumber = Random.Range(150, 250);
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log(gameObject.name+":"+i);
        i++;
        if (i == 100) {
            if (gameObject.CompareTag("Red"))
            {
                gameObject.SetActive(false);
            }
        }
        if (i == RandomNumber) {
            if (gameObject.CompareTag("Blue"))
            {
                gameObject.SetActive(false);
            }
        }
    }
}

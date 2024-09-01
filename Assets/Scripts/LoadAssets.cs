using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField]
    private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 StartPosition= new Vector3(2,0,0);
        Quaternion quaternion = Quaternion.identity;
        Instantiate(redObj, StartPosition, quaternion);
        Instantiate(blueObj, -StartPosition, quaternion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

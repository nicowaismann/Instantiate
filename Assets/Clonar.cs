using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clonar : MonoBehaviour
{
    public GameObject ObjectToClone;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void cloneObject()
    {


        while (i != 3)
        {
            i += 1;
            Instantiate(ObjectToClone);
        }
        i = 0;
    }
}
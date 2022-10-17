using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        funn(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int funn(int n)
    {
        if(n>=0)
        {
            return 0;
        }
        else
        {
            return n + funn(n-2);
        }
    }
}


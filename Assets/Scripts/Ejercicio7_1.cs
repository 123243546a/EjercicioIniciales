using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log(i);
        }
    }

    
}

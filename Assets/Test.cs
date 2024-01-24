using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;



public class Test : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5];

        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;

        for (int i = 0; i <= 4; i++) 
        {
            Debug.Log(array[i]);
        }

        for (int a = 4; a >=0; a--) 
        {
            Debug.Log(array[a]);
        }

   

   
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}


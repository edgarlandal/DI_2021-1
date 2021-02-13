using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array1 = {2,6,8,7,3,4};
        int[] array2 = {0,0,0,0,0,0};

        printArray(array1);
        printArray(array2);
        arrayNumMax(array1,array2);
        printArray(array1);
        printArray(array2);
    }

    int[] arrayNumMax(int[] array1, int[] array2){
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (array1[i]> array1[j])
                {
                    array2[i]++;
                }
            }
        }

        return array2;
    }
    
    void printArray(int[] array){
        for (int i = 0; i < 6; i++)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

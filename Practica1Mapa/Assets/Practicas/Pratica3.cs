using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Pratica3 : MonoBehaviour
{
    public int[] nums = {2,3,6,7,8,9,2,3,4}; 
    public int target = 6;
    // Start is called before the first frame update
    void Start()
    {
        Stopwatch timeMeasure = new Stopwatch();
        timeMeasure.Start();  
        int[] arrayB = buscar(nums);
        for (int i = 0; i < arrayB.Length; i++)
        {
            UnityEngine.Debug.Log(arrayB[i]);
        }

        UnityEngine.Debug.Log("Tiempo es :"+timeMeasure.Elapsed.TotalMilliseconds + " ms");
        timeMeasure.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int[] buscar(int[] array){
        int[] array2 = new int[2];
        for (int i = 0; i < array.Length; i++)
            for (int j = 0; j < array.Length; j++)
                if (i != j)
                    if((array[i] + array[j]) == target){
                        array2[0] = i;
                        array2[1] = j;
                        return array2;
                    }
        return array2;
    }
}

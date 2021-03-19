using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica5 : MonoBehaviour
{
    public static int[] array2 = {4, 1, 2, 1, 2};
    public static int[] array = {12, 345, 2, 6, 7896};
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(buscar_numeros_par(array));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int buscar_numeros_par(int[] array){
        int contD = 0, cont = 0;
        for (int i = 0; i < array.Length; i++)
        {
            while (array[i] > 0)
            {
                array[i] = array[i] % 10;
                contD++;
            }
            
            if(contD%2 == 0){
                cont++;
            }
        }
        return cont;
    }

    public void buscar_repetidos(int[] array){

    }
}

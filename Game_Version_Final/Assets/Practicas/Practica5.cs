using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica5 : MonoBehaviour
{
    public static int[] array2 = {1, 2, 1, 2, 3};
    public static int[] array = {12, 345, 2, 6, 7896};
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(buscar_numeros_par(array));
        Debug.Log(buscar_repetidos(array2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int buscar_numeros_par(int[] array){
        int contD = 0, cont = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int aux = array[i];
            while (aux > 0)
            {
                aux = aux / 10;
                contD++;
            }
            
            if(contD%2 == 0){
                cont++;
            }
        }
        return cont;
    }

    public int buscar_repetidos(int[] array){

        for (int i = 0; i < array.Length; i++)
        {
            int aux = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    aux++;
                }
            }
            if (!(aux > 1))
            {
                return array[i];
            }
        }

        return 0;
    }
}

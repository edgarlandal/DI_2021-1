using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string[] alumnos = {"Edgar","Erick","Mario","Paul","Valeria","Paola","Areli","Victor","Andres"};
    
    // Start is called before the first frame update
    void Start()
    {
        string respuesta = "Edgar";

        Debug.Log(estaAlumno(alumnos,respuesta));
    }

    public bool estaAlumno(string [] alumnos, string name){

        for (int i = 0; i < alumnos.Length; i++)
        {
            if (alumnos[i] == name)
            {
                return true;
            }
        }

        return false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

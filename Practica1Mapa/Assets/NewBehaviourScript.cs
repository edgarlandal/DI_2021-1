using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string[] alumnos = {"Edgar","Erick","Mario","Paul","Valeria","Paola","Areli","Victor","Andres"};
    
    // Start is called before the first frame update
    void Start()
    {
        Stopwatch timeMeasure = new Stopwatch();
        timeMeasure.Start();      
        string respuesta = "Juan";
        UnityEngine.Debug.Log(estaAlumno(alumnos,respuesta));
        respuesta = "Valeria";
        UnityEngine.Debug.Log(estaAlumno(alumnos,respuesta));
        respuesta = "Edgar";
        UnityEngine.Debug.Log(estaAlumno(alumnos,respuesta));

        UnityEngine.Debug.Log("Tiempo es :"+timeMeasure.Elapsed.TotalMilliseconds + " ms");
        timeMeasure.Stop();
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

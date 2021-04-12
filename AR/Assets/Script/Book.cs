using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "First Book", menuName="Inventory/Books")]
public class Book : Item
{
    
    public override void Use()
    {
        base.Use();
        // subirme la vida
        Debug.Log($"Hola bienvenido a Dilhevia");
    }
}

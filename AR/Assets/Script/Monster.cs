using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "Monster", menuName="Inventory/Monster")]

public class Monster : Item
{
    public override void Use()
    {
        base.Use();
        // subirme la vida
        Debug.Log($"Hola bienvenido a Dilhevia");
    }
}

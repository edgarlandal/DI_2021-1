using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int space = 10;

    public List<GameObject> items =  new List<GameObject>();


    public void Awake() {
        s_InventoryInstance = this;
    }
    
    public void Add(GameObject newItem){
        
        if (items.Count < space)
        {
            items.Add(newItem);            
        }else
        {
            Debug.Log("no hay item");
        }
    }

    public void Remove(GameObject itemToRemove){
        if (items.Contains(itemToRemove))
        {
            items.Remove(itemToRemove);
        }else
        {
            Debug.Log("No hay item");
        }
    }
}

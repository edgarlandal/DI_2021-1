using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private Inventory s_Inventory;

    private GameObject gb;
    // Start is called before the first frame update
    void Start()
    {
        s_Inventory = Inventory.InventoryInstance;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            panel.SetActive(!panel.activeSelf);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private Inventory _inventory;
    public GameObject panel;
    void Start()
    {
        _inventory = Inventory.InventoryInstance;
        _inventory.onChange += UpdateUI;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            panel.SetActive(!panel.activeSelf);
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        Slot[] slots = GetComponentsInChildren<Slot>();
        // Item[] equipItems = _inventory.GetAllItemsByType(ItemType.Equip);
        // Item[] medicineItems = _inventory.GetAllItemsByType(ItemType.Medicine);
        // Item[] booksItem = _inventory.GetAllItemsByType(ItemType.Books);

        // if (equipItems.Length > 0)
        //     slots[0].SetItem(booksItem[0], booksItem.Length);
        // if (medicineItems.Length > 0)
        //     slots[1].SetItem(medicineItems[0], medicineItems.Length);
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < _inventory.items.Count)
            {
                slots[i].SetItem(_inventory.items[i]);
            }
            else
            {
                slots[i].Clear();
            }
        }
    }
}
using UnityEngine;

public enum ItemType
{
    Equip, Weapon, Medicine, Books, Yugioh
}

[CreateAssetMenu(fileName= "New Item", menuName="Inventory/Generic")]
public class Item : ScriptableObject
{
    public ItemType itemType = ItemType.Books;
    public Sprite icon = null;

    public virtual void Use()
    {
        Debug.Log($"Usando item {name}");
    }
}

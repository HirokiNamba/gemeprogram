using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
public class ItemPickUp : MonoBehaviour
{
    [SerializeField] private ItemSerch itemSerch;
    [SerializeField] ItemType item;
    public ItemType.Type type;
    /// <summary>
    /// ItemPickUpにバインドされているボタンが押されたら呼ばれる
    /// </summary>
    public void OnItemPickUp()
    {
        var item = itemSerch.GetNearItem();
        if (item == null) return;
        item.GetComponent<Item>().PickUp();

        //ItemBox.instance.SetItem(item);
    }

    
}
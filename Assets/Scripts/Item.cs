using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Item After getting Populated 
/// </summary>
public class Item : MonoBehaviour
{
    public ItemData data;
    public List<Material> materials;
    
    private void OnEnable()
    {
        ConfigureItem();
    }
    void ConfigureItem()
    {
        gameObject.transform.localPosition= Vector3.zero;
        gameObject.transform.rotation= Quaternion.identity;
        data.state = (ItemType)UnityEngine.Random.Range(0, 3);
        Material mat = GetComponent<MeshRenderer>().material;
        switch (data.state)
        {
            case ItemType.Bad:
            {
                GetComponent<MeshRenderer>().material = materials[0];
                break;
            }
            case ItemType.Good:
            {
                GetComponent<MeshRenderer>().material = materials[1];
                break;  
            }
            case ItemType.Damaged:
            {
                GetComponent<MeshRenderer>().material = materials[2];
                break;
            }
        }
    }
}
[Serializable]
public class ItemData
{
    public string Name;
    public string Description;
    public ItemType state;
}

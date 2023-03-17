using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is responible for Routing of packets towards different sides based on the value;
/// </summary>
public class Merger : MonoBehaviour
{
    [SerializeField]
    GameObject InGate;
    [SerializeField]
    GameObject Badgate;
    [SerializeField]
    GameObject GoodGate;
    [SerializeField]
    GameObject DamagedGate;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Started");
        Item _item = collision.gameObject.GetComponent<Item>();
        if (_item != null)
        {
            switch (_item.data.state)
            {
                case ItemType.Good:
                    {
                        collision.gameObject.transform.position = GoodGate.gameObject.transform.position;
                        break;
                    }
                case ItemType.Damaged:
                    {
                        collision.gameObject.transform.position = DamagedGate.gameObject.transform.position;
                        break;
                    }
                case ItemType.Bad:
                    {
                        collision.gameObject.transform.position = Badgate.gameObject.transform.position;
                        break;
                    }
            }
        }
    }
    private void OnTriggerStay(Collider collision)
    {
        Debug.Log("Trigger Stay");
        
    }
}

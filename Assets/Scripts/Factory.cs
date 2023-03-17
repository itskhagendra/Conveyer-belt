using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is responsible for creating the items on the conveyer belt
/// </summary>
public class Factory : MonoBehaviour
{
    public List<GameObject> Poolobjects;
    [SerializeField]
    GameObject ObjectToPool;
    [SerializeField]
    int poolSize;
    [SerializeField]
    [Range(.5f, 3f)]
    float PoolSpeed=.5f;
    void Start()
    {
        Poolobjects= new List<GameObject>();
        GameObject temp;
        for(int i = 0; i < poolSize; i++)
        {
            temp = Instantiate(ObjectToPool,transform.transform);
            temp.SetActive(false);
            Poolobjects.Add(temp);
        }
        StartCoroutine(DropObject());
    }

    // Update is called once per frame
    
    IEnumerator DropObject()
    {
        foreach(GameObject obj in Poolobjects)
        {
            if (!obj.activeInHierarchy)
                obj.SetActive(true);
            obj.SetActive(true);
            yield return new WaitForSeconds(PoolSpeed);
        }
        StartCoroutine(DropObject());


    }
}

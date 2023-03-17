using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Logic for Conveyer belt and Movement of Objects;
/// </summary>
public class ConveyerBelt : MonoBehaviour
{   
    [SerializeField]
    float speed;
    Rigidbody body;
    [SerializeField]
    ConveyerDirection direction;
    
    Vector3 _directionVector ;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
        switch(direction)
        {
            case ConveyerDirection.Forward:
                {
                    _directionVector = Vector3.back;
                    break;
                }
            case ConveyerDirection.Backward:
                {
                    _directionVector = Vector3.forward;
                    break;
                }
            case ConveyerDirection.Right:
                {
                    _directionVector = Vector3.left;
                    break;
                }
            case ConveyerDirection.Left:
                {
                    _directionVector = Vector3.right;
                    break;
                }

        }
    }
    private void FixedUpdate()
    {
        Vector3 pos = body.position;
        body.position += _directionVector * speed * Time.fixedDeltaTime;
        body.MovePosition(pos); 
    }


}

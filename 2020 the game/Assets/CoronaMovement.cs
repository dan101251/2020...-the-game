using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaMovement : MonoBehaviour
{
    private Vector3 posA;

    private Vector3 posB;

    private Vector3 nexPos; 

    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform childTransform;

    [SerializeField]
    private Transform transformB; 
    // Start is called before the first frame update
    void Start()
    {
        posA = childTransform.localPosition; 
        posB = transformB.localPosition;
        nexPos = posB;
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        // moves the Coronavirus up and down.   
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nexPos, speed * Time.deltaTime); 
        if (Vector3.Distance(childTransform.localPosition, nexPos ) <= 0.1)
        {
            ChangeDestination(); 
        }
    }

    private void ChangeDestination()
    {
        // if condition that if NexPos is not equal to posA, it will use posA,
        // if it is equal to posA it will use posB. 
        nexPos = nexPos != posA ? posA : posB; 

    }
}

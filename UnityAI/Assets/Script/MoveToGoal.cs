using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoal : MonoBehaviour
{
    public float speed = 1.0f;
    public float accuracy = 0.01f;
    public Transform goal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 direction = goal.position - this.transform.position;

        Debug.Log("<color=orange> direction: " + direction + " </color>");
        Debug.DrawRay(this.transform.position,direction,Color.green);
            
        if(direction.magnitude > accuracy)
        {
            this.transform.Translate(direction.normalized * speed * Time.deltaTime,Space.World);
        }

        this.transform.LookAt(goal.position);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnningTableBehavior : MonoBehaviour
{
    public float turningSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, turningSpeed, 0));
    }


    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.SetParent(transform);
    }

    private void OnCollisionExit(Collision collision)
    {
        collision.gameObject.transform.SetParent(null);
    }
}

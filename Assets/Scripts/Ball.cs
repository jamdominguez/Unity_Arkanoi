using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float initialSpeed;
    public Transform bar;

    private Rigidbody rg;
    private bool gameStarted = false;
    private Vector3 initialPosition;

    private void Awake()
    {
        rg = GetComponent<Rigidbody>();        
    }

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted && Input.GetButtonDown("Fire1"))
        {
            gameStarted = true;
            transform.SetParent(null); // unbound from parent
            rg.isKinematic = false; // for use force sytem, previously are linked to parent with isKinematic true
            rg.AddForce(new Vector3(initialSpeed, initialSpeed, 0f)); // add force in Y
        }
    }

    public void Reset()
    {
        transform.position = initialPosition;
        transform.SetParent(bar);
        gameStarted = false;
        StopMovement();
    }

    public void StopMovement() {
        rg.isKinematic = true;
        rg.velocity = Vector3.zero;
    }
}

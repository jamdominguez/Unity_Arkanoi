using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalKey = Input.GetAxisRaw("Horizontal");
        float xPos = transform.position.x + (horizontalKey * speed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(xPos, -8, 8), transform.position.y, transform.position.z);

    }

    public void Reset()
    {
        transform.position = initialPosition;
    }
}

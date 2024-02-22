using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public Lifes lifes;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball")) lifes.DecreaseLifes();        
    }

}

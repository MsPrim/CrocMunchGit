using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollisionDetect : MonoBehaviour
{
//make the fish only collide with the player and add a point to the score
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();
        }
    }
}



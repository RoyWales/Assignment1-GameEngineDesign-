using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
       // Destroy(collision.collider.gameObject);
       // Destroy(gameObject);
        if (collision.gameObject.tag == "Player")
        {
           // Destroy(gameObject);

            DestroyAll("Lock");
        }

        
    }

    void DestroyAll(string tag)
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(tag);
        for (int i = 0; i < enemies.Length; i++)
        {
            GameObject.Destroy(enemies[i]);
        }
    }

}

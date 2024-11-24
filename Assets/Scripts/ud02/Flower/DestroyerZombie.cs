using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerZombie : MonoBehaviour
{
    private void OnCollisionEnter(Collision infoCollision)
    {

        Debug.Log(infoCollision.gameObject.tag);

        if (infoCollision.gameObject.tag == "CactusAttack")
        {

            Destroy(gameObject);

        }

    }
}


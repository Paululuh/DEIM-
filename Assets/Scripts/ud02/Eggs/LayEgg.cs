using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayEgg : MonoBehaviour
{
    [SerializeField] private GameObject egg;
    [SerializeField] private Transform butt;

    // Update is called once per frame
    void Update()
    {
        EggGenerator();

    }
    void EggGenerator()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newEgg = Instantiate(egg, butt.position, butt.rotation);
        }
    }
}

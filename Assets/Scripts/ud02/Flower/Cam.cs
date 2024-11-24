using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform Target;

    private float _smoothing;

    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        //Offset es igual a posición de la cámara menos la del
        //"player". Es el vector que los une
        _offset = transform.position - Target.position;
        _smoothing = 2f;

    }

    // Update is called once per frame
    void Update()
    {
        // Posición que quiero que se mueva la cámara
        Vector3 camPosition = Target.position + _offset;
        transform.position = Vector3.Lerp(transform.position, camPosition, _smoothing * Time.deltaTime);

    }
}

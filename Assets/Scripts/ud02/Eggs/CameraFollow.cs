using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;

    private float _smoothing;

    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        //Offset es igual a posici�n de la c�mara menos la del
        //"chicken". Es el vector que los une
        _offset = transform.position - Target.position;
        _smoothing = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {
        // Posici�n que quiero que se mueva la c�mara
        Vector3 camPosition = Target.position + _offset;
        transform.position = Vector3.Lerp(transform.position, camPosition, _smoothing * Time.deltaTime);
        
    }
}

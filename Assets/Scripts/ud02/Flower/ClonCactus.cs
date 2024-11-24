using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonCactus : MonoBehaviour
{
    public GameObject Cactus;
    public Transform PosRotCactus;

    private float thrustY = 90f,
                  thrustZ = 299f;
    private Animator _anim;
   

    private float _timeCactus = 3f;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        CreateCactus();

        AnimationAttack();

    }
    private void CreateCactus()
    {
        if (Input.GetMouseButtonDown(0))
        {

            //Crear clones del prefab del cactus
            //Al no indicar dónde quiero que se genere el clon, crear en posición 0.0f, 0.0f, 0.0f)
            GameObject ClonCactus = Instantiate(Cactus, PosRotCactus.position, PosRotCactus.rotation);

            //Obtener el componente "rigidbody" de cada cactus
            Rigidbody rbCactus = ClonCactus.GetComponent<Rigidbody>();

            //"Vector3.up" referencia eje global de la escena
            rbCactus.AddForce(Vector3.up * thrustY);

            //"transform.forward" referencia eje Z local de "PosRotCactus"
            rbCactus.AddForce(transform.forward * thrustZ);

            Destroy(ClonCactus, _timeCactus);
        }
    }
    private void AnimationAttack()
    {

        if (Input.GetMouseButtonDown(0))
        {

            //Ejecución de la animación
            _anim.SetTrigger("IsAttacking");

        }

    }

}

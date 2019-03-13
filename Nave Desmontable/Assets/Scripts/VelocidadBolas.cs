using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadBolas : MonoBehaviour
{
    ConstantForce constantForce;
    [HideInInspector]
    public int fuerza;

    private void OnEnable()
    {
        fuerza = Random.Range(90, 200);
        constantForce = GetComponent<ConstantForce>();

        if (gameObject.name == "HaciaAbajo")
            constantForce.force = new Vector3(-fuerza,0,0);
        else if(gameObject.name == "HaciaArriba")
            constantForce.force = new Vector3(fuerza, 0, 0);
        else if(gameObject.name == "HaciaDerecha")
            constantForce.force = new Vector3(0, 0, fuerza);
        else if (gameObject.name == "HaciaIzquierda")
            constantForce.force = new Vector3(0, 0, -fuerza);

        
    }
}

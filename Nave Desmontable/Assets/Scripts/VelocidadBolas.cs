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
        constantForce = GetComponent<ConstantForce>();
        fuerza = Random.Range(90, 200);
        /*
        if (gameObject.name == "HaciaAbajo")
            constantForce.force = new Vector3(-fuerza,0,0);
        else if(gameObject.name == "HaciaArriba")
            constantForce.force = new Vector3(fuerza, 0, 0);
        else if(gameObject.name == "HaciaDerecha")
            constantForce.force = new Vector3(0, 0, fuerza);
        else if (gameObject.name == "HaciaIzquierda")
            constantForce.force = new Vector3(0, 0, -fuerza);*/

        if (gameObject.name == "HaciaAbajo")
            constantForce.force = new Vector3(-160, 0, 0);
        else if (gameObject.name == "HaciaArriba")
            constantForce.force = new Vector3(125, 0, 0);
        else if (gameObject.name == "HaciaDerecha")
            constantForce.force = new Vector3(0, 0, 105);
        else if (gameObject.name == "HaciaIzquierda")
            constantForce.force = new Vector3(0, 0, -95);
    }
}

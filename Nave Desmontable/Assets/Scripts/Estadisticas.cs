using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Estadisticas : MonoBehaviour
{
    public float Vida;
    public Text textoVida;
    
    private void Update()
    {
        textoVida.text = Vida.ToString();

        if (Vida <= 0 && gameObject.name == "Nucleo")
        {
            GameObject[] partes = GameObject.FindGameObjectsWithTag("Nave");

            for(int i = 0;i < partes.Length; i++)
            {
                partes[i].GetComponent<Estadisticas>().Vida = 0;
            }
            Vida = 0;
            textoVida.text = "0";
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            Destroy(this.gameObject, 1);
        }
        else if(Vida <= 0)
        {
            textoVida.text = "0";
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            Destroy(this.gameObject, 1);
        }
        
    }

    public void BajarVida(float velocidad)
    {

        if (velocidad >= 150)
            Vida -= 5;
        else if (velocidad >= 120)
            Vida -= 2;
        else if (velocidad >= 100)
            Vida--;
        else
            return;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        BajarVida(collision.gameObject.GetComponent<VelocidadBolas>().fuerza);
    }
}

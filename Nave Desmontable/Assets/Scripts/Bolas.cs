using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolas : MonoBehaviour
{
    public GameObject[] bolas;
    
    public void CrearBola1()
    {
        Instantiate(bolas[0]);
    }
    public void CrearBola2()
    {
        Instantiate(bolas[1]);
    }
    public void CrearBola3()
    {
        Instantiate(bolas[2]);
    }
    public void CrearBola4()
    {
        Instantiate(bolas[3]);
    }
}

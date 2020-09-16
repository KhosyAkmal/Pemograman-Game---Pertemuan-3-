using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbahWarna1 : MonoBehaviour
{
    public void Hijau()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    public void Magenta()
    {
        GetComponent<Renderer>().material.color = Color.magenta;
    }

    public void Grey()
    {
        GetComponent<Renderer>().material.color = Color.grey;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hola : MonoBehaviour
{
    public GameObject escondermesh;

    void OnMouseDown()
    {
        escondermesh.SetActive(false); // Hides the mesh when collider is clicked
    }
}

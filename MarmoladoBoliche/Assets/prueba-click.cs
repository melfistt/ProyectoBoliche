using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hola : MonoBehaviour
{
    public inventario inventario;
    public string nombreitem;
    public int itemID;
    void OnMouseDown()
    {
        // agregar un item al inventario
        inventario.AddItem(gameObject);

        // ocultar el objeto
        gameObject.SetActive(false);

        Debug.Log(nombreitem+"guardado en el inventario");

    }
}

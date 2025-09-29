using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventario : MonoBehaviour
{
    // Lo que contiene a los objetos que se agregan
    public List<GameObject> Inventario_items = new List<GameObject>();

    // se llama a esta funcion para agregar un item
    public void AddItem(GameObject item)
    {
    Inventario_items.Add(item); // guardar la referencia al objeto
        Debug.Log(item.name + " Guardado en el inventario, en total hay: " + Inventario_items.Count);
    }

}

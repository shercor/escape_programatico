using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f; // Velocidad de movimiento del personaje
    public bool isMenuOpen = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Lo primero es verificar si hay algún menú abierto, para prohibir el movimiento del jugador en ese caso
        GameObject[] popupElements = GameObject.FindGameObjectsWithTag("PopUp"); //Se busca a todos los elementos que puedan hacer emerger un menú
        List<bool> booleanList = new List<bool>(); //Se crea una lista con los booleanos de todos estos elementos que indican true si su menú está activo
        int L = popupElements.Length; // Establecemos el largo de la lista de booleanos como igual al de la lista de elementos popup encontrados
        for (int i = 0; i < L; i++) // Se agregan los booleanos asociados a la lista creada
        {
            booleanList.Add(popupElements[i].GetComponent<PopUpMenu>().isMenuOpen); // Agrega booleanos false a la lista
        }
        if (booleanList.Contains(true)) //Se verifica si hay algún booleano true en la lista
        {
            isMenuOpen = true;
            Debug.Log("Al menos un booleano es true.");
        }
        else
        {
            isMenuOpen = false;
            Debug.Log("Todos los booleanos son false.");
        }

        if (isMenuOpen == false){ //Solo permite el movimiento si no hay ningún menú abierto
            if (Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())
            {
                Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                target.z = 0f;
                Vector2 direction = (target - transform.position).normalized;
                rb.velocity = direction * speed;
            }
            else
            {
                rb.velocity = Vector2.zero;
            }
        }
    }
}
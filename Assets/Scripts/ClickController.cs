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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Photon.Pun;

public class ClickController : MonoBehaviourPun, IPunObservable
{
    public Rigidbody2D rb;
    public float speed = 5f; // Velocidad de movimiento del personaje
    public bool isMenuOpen = false;
    private bool facingRight = true;

    Color[] coloresPrincipales = new Color[] {
        Color.red,         // Rojo
        Color.green,       // Verde
        Color.blue,        // Azul
        Color.yellow,      // Amarillo
        Color.cyan,        // Cian
        Color.magenta,     // Magenta
        Color.white,       // Blanco
        Color.black,       // Negro
        Color.gray,        // Gris
        new Color(1.0f, 0.5f, 0.0f),  // Naranja
        new Color(0.5f, 0.0f, 0.5f),  // Púrpura
        new Color(0.0f, 0.5f, 0.5f)   // Turquesa
    };

    private PhotonView photonView;

    [Header("Animacion")]
    private Animator animator;
    private PhotonAnimatorView photonAnimatorView;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        photonView = GetComponent<PhotonView>();
        animator = GetComponent<Animator>();
        photonAnimatorView = GetComponent<PhotonAnimatorView>();

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            Color colorAleatorio = coloresPrincipales[Random.Range(0, coloresPrincipales.Length)];
            spriteRenderer.color = colorAleatorio;
        }
    }

    private void Update()
    {
        if (photonView.IsMine)
        {
            if (Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())
            {
                Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                target.z = 0f;
                Vector2 direction = (target - transform.position).normalized;
                rb.velocity = direction * speed;

                if (rb.velocity.x > 0 && !facingRight)
                {
                    Flip();
                }
                else if (rb.velocity.x < 0 && facingRight)
                {
                    Flip();
                }
            }
            else
            {
                rb.velocity = Vector2.zero;
            }
            animator.SetFloat("Horizontal", Mathf.Abs(rb.velocity.x));
        }
        else
        {
            photonAnimatorView.enabled = true;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            // Enviar datos
            stream.SendNext(transform.position);
            stream.SendNext(transform.localScale.x);
        }
        else
        {
            // Recibir datos
            transform.position = (Vector3)stream.ReceiveNext();
            float scaleX = (float)stream.ReceiveNext();
            
            // Asegurarse de que la dirección sea correcta
            if (transform.localScale.x != scaleX)
            {
                Vector3 scaler = transform.localScale;
                scaler.x = scaleX;
                transform.localScale = scaler;
            }
        }
    }
}

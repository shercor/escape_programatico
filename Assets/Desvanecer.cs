/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desvanecer : MonoBehaviour
{
    public float fadeDuration = 4f; // Duración en segundos para desvanecer el objeto
    private float currentAlpha = 1f; // Nivel actual de transparencia
    private Material material; // Referencia al material del objeto

    private void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        // Gradualmente disminuir el valor del canal alfa
        currentAlpha -= Time.deltaTime / fadeDuration;
        currentAlpha = Mathf.Clamp01(currentAlpha); // Asegurarse de que el valor esté entre 0 y 1

        // Aplicar el nuevo valor de transparencia al material
        Color color = material.color;
        color.a = currentAlpha;
        material.color = color;

        // Si el objeto se ha vuelto completamente transparente, destruirlo
        if (currentAlpha <= 0f)
        {
            Destroy(gameObject);
        }
    }
}

*/

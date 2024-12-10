using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Alerta : MonoBehaviour
{
    public GameObject imagenUI; // Asigna la imagen UI en el Inspector
    public TextMeshProUGUI textoUI; // Asigna el TextMeshPro UI en el Inspector

    void Start()
    {
        // Asegúrate de que la imagen y el texto estén desactivados al inicio
        //imagenUI.SetActive(false);
        //textoUI.gameObject.SetActive(false);
        textoUI.text = "¡Busca pistas e intenta escapar!";
        Invoke("DesactivarAlerta", 5f);
    }

    public void MostrarAlerta(string mensaje)
    {
        // Activa la imagen y el texto con el mensaje proporcionado
        imagenUI.SetActive(true);
        textoUI.gameObject.SetActive(true);
        textoUI.text = mensaje;

        // Después de 5 segundos, desactiva la imagen y el texto
        Invoke("DesactivarAlerta", 5f);
    }

    void DesactivarAlerta()
    {
        imagenUI.SetActive(false);
        textoUI.gameObject.SetActive(false);
    }
}

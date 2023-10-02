using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ScreenTransition : MonoBehaviour
{
    public Image transitionImage;
    public float transitionTime = 3.0f;

    private Color targetColor = Color.black;
    private Color originalColor;
    private float startTime;
    public TextMeshProUGUI mensaje;

    public bool finish;

    private bool esc = false;

    private void Start()
    {
        originalColor = transitionImage.color;
        Finish();
    }

    private void Update()
    {
        if (finish == true){
            float elapsedTime = Time.time - startTime;
            float normalizedTime = Mathf.Clamp01(elapsedTime / transitionTime);
            transitionImage.color = Color.Lerp(originalColor, targetColor, normalizedTime);

            if (normalizedTime >= 1.0f)
            {
                mensaje.text = "Gracias por jugar. Pulsa cualquier tecla para salir del juego";
                // Accede al objeto padre del objeto actual
                Transform parentTransform = transform.parent;
                parentTransform.GetComponent<GraphicRaycaster>().enabled = true;
                esc = true;

                //SceneManager.LoadScene("Ending");
            } 
        }
        //if (Input.GetKeyDown(KeyCode.Escape) && esc)
        if (Input.anyKeyDown && esc)
        
        {
            // Cierra la aplicación
            Application.Quit();
        }
    }

    public void Finish(){
        finish = true;
        startTime = Time.time;
    }
}

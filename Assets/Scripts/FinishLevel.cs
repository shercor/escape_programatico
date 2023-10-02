using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    private void Update(){
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        float distanceToFinish = Vector3.Distance(transform.position, playerObject.transform.position);
        if ( distanceToFinish < 1.0f)
        {
            Debug.Log("FINAAAL");
            GameObject mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
            if (mainCamera != null)
            {
                // Activa todos los hijos del objeto con el tag "MainCamera"
                foreach (Transform child in mainCamera.transform)
                {
                    child.gameObject.SetActive(true);
                }
            }
            //Invoke("CambiarEscena", 3f);
        }
    }

    void CambiarEscena()
    {
        SceneManager.LoadScene("Ending");
    }
}

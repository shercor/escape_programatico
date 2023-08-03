using UnityEngine;

public class Indestructible : MonoBehaviour
{
    private void Start()
    {
        // Make the object indestructible when the scene starts
        DontDestroyOnLoad(gameObject);
    }
}
using UnityEngine;
using TMPro;

public class RayCastDisabled : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    private void Start()
    {
        // Get the TextMeshProUGUI component
        textMeshPro = GetComponent<TextMeshProUGUI>();

        // Disable the Raycast Target
        //textMeshPro.raycastTarget = false;
    }
}
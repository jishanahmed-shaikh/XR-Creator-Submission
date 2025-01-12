// using UnityEngine;

// public class CarColorChanger : MonoBehaviour
// {
//     public Material[] carMaterials;
//     private Renderer chassisRenderer;

//     void Start()
//     {
//         // Get the renderer directly from this object
//         chassisRenderer = GetComponent<Renderer>();
//         if (chassisRenderer == null)
//         {
//             Debug.LogError("No Renderer component found on this object.");
//         }
//     }

//     public void ChangeCarColor(int colorIndex)
//     {
//         if (carMaterials != null && chassisRenderer != null && colorIndex < carMaterials.Length)
//         {
//             chassisRenderer.material = carMaterials[colorIndex];
//         }
//         else
//         {
//             Debug.LogError("Invalid color index or missing Renderer/Materials.");
//         }
//     }
// }
using UnityEngine;

public class CarColorChanger : MonoBehaviour
{
    public Material[] carMaterials;
    private Renderer chassisRenderer;
    private Material originalMaterial;
    private int currentColorIndex = -1;  // -1 means original color

    void Start()
    {
        // Get the renderer directly from this object
        chassisRenderer = GetComponent<Renderer>();
        if (chassisRenderer == null)
        {
            Debug.LogError("No Renderer component found on this object.");
            return;
        }
        
        // Store the original material
        originalMaterial = chassisRenderer.material;
    }

    public void ChangeCarColor(int colorIndex)
    {
        if (carMaterials == null || chassisRenderer == null || colorIndex >= carMaterials.Length)
        {
            Debug.LogError("Invalid color index or missing Renderer/Materials.");
            return;
        }

        // If clicking the same color button
        if (currentColorIndex == colorIndex)
        {
            // Reset to original color
            chassisRenderer.material = originalMaterial;
            currentColorIndex = -1;
        }
        else
        {
            // Change to new color
            chassisRenderer.material = carMaterials[colorIndex];
            currentColorIndex = colorIndex;
        }
    }
}
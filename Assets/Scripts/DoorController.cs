using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator[] doorAnimators; // Array to hold all door animators
    private bool isOpen = false;

    public void ToggleDoors()
    {
        isOpen = !isOpen;
        foreach (Animator animator in doorAnimators)
        {
            // Assuming your animation parameter is called "isOpen"
            animator.SetBool("isOpen", isOpen);
        }
    }
}
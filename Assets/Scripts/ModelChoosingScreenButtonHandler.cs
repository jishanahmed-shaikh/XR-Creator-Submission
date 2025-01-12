using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModelChoosingScreenButtonHandler : MonoBehaviour
{
    public void VolkswagonVirtus()
    {
        Debug.Log("Entering Volkswagon Virtus Scene");
        SceneManager.LoadScene("6Virtus");
    }
    public void TataSafari()
    {
        Debug.Log("Entering TataSafari Scene");
        SceneManager.LoadScene("7TataSafari");
    }
    public void VitaraBrezza()
    {
        Debug.Log("Entering VitaraBrezza Scene");
        SceneManager.LoadScene("8VitaraBrezza");
    }
    public void TataTiago()
    {
        Debug.Log("Entering TataTiago Scene");
        SceneManager.LoadScene("9TataTiago");
    }
    public void SuzukiCiaz()
    {
        Debug.Log("Entering SuzukiCiaz Scene");
        SceneManager.LoadScene("10SuzukiCiaz");
    }
    public void BacktoHomeScreen()
    {
        Debug.Log("Entering HomeScreen from ModelSelection Scene");
        SceneManager.LoadScene("2HomeScreen");
    }
}

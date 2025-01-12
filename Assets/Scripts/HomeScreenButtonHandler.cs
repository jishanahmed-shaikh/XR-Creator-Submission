using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreenButtonHandler : MonoBehaviour
{
    public void GotoPocketShowroom()
    {
        Debug.Log("Entering PocketShowroom/ModelChoosing Screen from HomeScreen");
        SceneManager.LoadScene("5ModelSelection");
    }
    public void GotoAbout()
    {   
        Debug.Log("Entering AboutScreen from HomeScreen");
        SceneManager.LoadScene("3About");
    }
    public void GotoARNavigation()
    {
        Debug.Log("Entering ARNavigation from HomeScreen");
        SceneManager.LoadScene("Mapbox Route");
    }
    public void GotoGuide()
    {
        Debug.Log("Entering Info/Guide-ARNavigation from HomeScreen");
        SceneManager.LoadScene("4Guide");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CarModelButtonManager : MonoBehaviour
{
    public void BacktoHomeScreen()
    {
        Debug.Log("Entering Model Selection Scene");
        SceneManager.LoadScene("5ModelSelection");
    }
}

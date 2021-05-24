using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public float delayTime = 5f;

    void Start()
    {
        Invoke("delayScene", 5f);
        StartCoroutine("waitForScene");
    }

    void delayScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public IEnumerator waitForScene()
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene("MainMenu");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

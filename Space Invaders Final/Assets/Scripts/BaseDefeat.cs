using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDefeat : MonoBehaviour
{
    private Transform playerBarricade;
    
    // Start is called before the first frame update
    void Start()
    {
        playerBarricade = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerBarricade.childCount == 0)
        {
            GameOver.isPlayerDead = true;
        }
    }
}

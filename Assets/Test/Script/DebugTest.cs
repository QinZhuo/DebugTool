using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("warningTets");
        Debug.Log("warningTets1");
        Debug.LogError("warningTets2");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("logtest");
        Debug.LogError("logtest" + (int)(Time.time) % 1000000);
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.LogError("errorTest A"+Time.time);
        }
    }
}

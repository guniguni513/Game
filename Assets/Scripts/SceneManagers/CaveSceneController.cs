using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangeScene",2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("ClearScene");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneController : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClick()
    {
        ChangeScene();
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("City");
    }
}

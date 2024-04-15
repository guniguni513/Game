using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MountainSceneController : MonoBehaviour
{
    public Transform parent;
    public PlayerHpBar playerHpBar;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("ChangeScene",2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        List<Transform> children = new List<Transform>();
        for (int i = 0; i < parent.childCount; i++)
        {
            children.Add(parent.GetChild(i));
        }

        if (children.Count <= 0)
        {
            ChangeScene();
        }
        else if (playerHpBar.currentHp <= 0)
        {
            LoseScene();
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadSceneAsync("Cave");
    }
    
    void LoseScene()
    {
        SceneManager.LoadSceneAsync("LoseScene");
    }

}

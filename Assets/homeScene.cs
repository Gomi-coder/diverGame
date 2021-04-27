using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homeScene : MonoBehaviour
{
    void Start()
    {
        
    }
    public void ButtonDown()
    {
        SceneManager.LoadScene("GameScene");
    }
    void Update()
    {

    }
}

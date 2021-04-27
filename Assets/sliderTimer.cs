using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sliderTimer : MonoBehaviour
{
    Slider slTimer;
    float fSliderBarTime;

    void Start()
    {
        slTimer = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slTimer.value > 0.0f)
        {
            slTimer.value -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Time Out");
            SceneManager.LoadScene("OverScene");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    GameObject player;
    GameObject chest;
    GameObject hook;
    GameObject distance;

    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
        this.player = GameObject.Find("diver");
        this.chest = GameObject.Find("chest");
        this.hook = GameObject.Find("hook");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        if (this.hpGauge.GetComponent<Image>().fillAmount == 0.0f)
        {
            SceneManager.LoadScene("ClearScene");
        }

        float length1 = this.chest.transform.position.x - this.player.transform.position.x;
        float length2 = this.hook.transform.position.x - this.player.transform.position.x;
        
        this.distance.GetComponent<Text>().text = "보물까지 " + length1.ToString("F2") + "m"
            + System.Environment.NewLine + "밧줄까지 " + length2.ToString("F2") + "m";
        
    }

    public void DecreaseHP()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    public void FishDecreasHP()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.002f;
    }

}

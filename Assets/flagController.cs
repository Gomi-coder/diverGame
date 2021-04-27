using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flagController : MonoBehaviour
{
    public bool isRot = false;
    GameObject player;
    [SerializeField]
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("diver");
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.isRot == false)
        {
            transform.Rotate(0, 0, 90);
            this.isRot = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

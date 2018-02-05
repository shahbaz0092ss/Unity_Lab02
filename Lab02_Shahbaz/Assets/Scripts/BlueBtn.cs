using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBtn : MonoBehaviour {


    public GameObject GreenPlayer;


    public Sprite firstImage;

    private SpriteRenderer sRend;
    private Rigidbody2D rBody;

    // initiaisation

    void Start()
    {

        rBody = GreenPlayer.GetComponent<Rigidbody2D>();
        sRend = GreenPlayer.GetComponent<SpriteRenderer>();

        rBody.velocity = new Vector2(0, 0);



    }


    void Update()
    {
    }
    void OnMouseDown()
    {

        sRend.sprite = firstImage;


    }
}

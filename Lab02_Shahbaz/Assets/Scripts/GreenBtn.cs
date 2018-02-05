using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBtn : MonoBehaviour {

    // Use this for initialization


    public GameObject GreenPlayer;
  


    public Sprite secondImage;


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

        sRend.sprite = secondImage;
      


    }
}

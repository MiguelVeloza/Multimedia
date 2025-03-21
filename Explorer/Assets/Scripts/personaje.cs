using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour{

    Rigidbody2D caballeroRB;
    public float maxVelocidad;

    //Voltear caballero
    bool voltearCaballero = true;
    SpriteRenderer caballeroRender;

    void Start(){
        caballeroRB = GetComponent<Rigidbody2D> ();
        caballeroRender = GetComponent<SpriteRenderer> ();
    }

    void Update(){
        float mover = Input.GetAxis("Horizontal");

        if(mover > 0 && !voltearCaballero){
            voltear();
        }else if(mover < 0 && voltearCaballero){
            voltear();
        }

        caballeroRB.velocity = new Vector2(mover * maxVelocidad, caballeroRB.velocity.y);
    }

    void voltear(){
        voltearCaballero = !voltearCaballero;
        caballeroRender.flipX = !caballeroRender.flipX;
    }
}

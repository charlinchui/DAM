using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour{

    [Range(1, 10)] public float velocidad; //Velocidad del jugador

    bool isJumping = false; //Para comprobar si ya está saltando
    [Range(1, 500)] public float potenciaSalto; //Potencia de salto del jugador

    Rigidbody2D rb2d;
    SpriteRenderer spRd;

    void Start () {

        //Rigidbody2D & Sprite Renderer 
        rb2d = GetComponent<Rigidbody2D>();
        spRd = GetComponent<SpriteRenderer>();

    }
	
	void FixedUpdate () {

        //Movimiento horizontal
        float movimientoH = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(movimientoH * velocidad, rb2d.velocity.y );

        //Sentido horizontal
        if (movimientoH > 0){
            spRd.flipX = false;
        }
        else if (movimientoH < 0){
            spRd.flipX = true;
        }
        if (Input.GetButton("Jump") && !isJumping){
            //Le aplico la fuerza de salto
            rb2d.AddForce(Vector2.up * potenciaSalto);
            //Digo que está saltando (para que no pueda volver a saltar)
            isJumping = true;
        }

    }
    private void OnCollisionEnter2D(Collision2D other){
        //Si el jugador colisiona con un objeto con la etiqueta suelo
        if (other.gameObject.CompareTag("Suelo"))
        {
            //Digo que no está saltando (para que pueda volver a saltar)
            isJumping = false;
            //Le quito la fuerza de salto remanente que tuviera
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
        }
    }
}


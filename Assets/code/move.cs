using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public SpriteRenderer fogo_L, fogo_R;
    public Rigidbody2D rdb;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,-5,0);
        //define a posi��o no come�o do jogo
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //FixedUpdate � chamado a cada frame, mas � chamado com um tempo fixo
    private void FixedUpdate()
    {
        movimento();
    }

    void movimento()
    {
        if (Input.GetKey (KeyCode.W))
        {
            rdb.AddRelativeForce(Vector2.up * 7.5f);
            //"AddForce" adiciona movimento, e precisa de "Vector2." e a dire��o
            //"AddRelativeForce" faz o movimento ser relativo ao objeto

            fogo_L.enabled = true;
            fogo_R.enabled = true;
        }
        
        else
        {
            fogo_L.enabled = false;
            fogo_R.enabled = false;
        }


        if (Input.GetKey(KeyCode.A))
        {
            rdb.AddTorque(2.5f);
        }
        
        if (Input.GetKey (KeyCode.D))
        {
            rdb.AddTorque(-2.5f);
            //"AddTorque" adiciona rota��o


            //if (transform.position.x < 8.8f)
                //transform.position = transform.position + new Vector3(5, 0, 0) * Time.deltaTime;
            
            //"transform.position += new Vector3(1f, 0, 0);" � a mesma coisa
            //O "f" depois do numero serve para numeros quebrados
            //"* Time.deltatime" sincroniza a velocidade
            //"if (transform.position.y > 8.8)" limita a distancia que o objeto percorre, se a posi��o foir menor que 8.8 o codigo para
        }

    }
}

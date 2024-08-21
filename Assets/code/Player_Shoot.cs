using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    public GameObject PreFab_beam;

    public Transform Player_Fire_Location;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            fire();
    }

    void fire()
    {
        //instanciar o tiro na posi��o do player e com a rota��o padr�o
        GameObject beams = Instantiate(PreFab_beam, Player_Fire_Location.position, Player_Fire_Location.rotation);

        //adicionar forca para cima no tiro para ele subir
        beams.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 10, ForceMode2D.Impulse);

        //esse sistema cria objetos, o que pode causar stack overflow, � melhor usar particulas para tiros simples
        //mas esse metodo � util para tiros especiais (misseis teleguiados, bombas, etc)
    }
}

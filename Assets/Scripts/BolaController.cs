using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    
    //Criando a variavel para saber quem é o meu RigidBody
    public Rigidbody2D meuRB;
    private Vector2 minhaVelocidade;
    public float velocidade = 5f; 
     
    // Start is called before the first frame update
    void Start()
    {
        //Passando a minha velocidade para minhaVelocidade
        minhaVelocidade.x = -velocidade;
        //Adicionando uma velocidade para a esquerda
        meuRB.velocity = minhaVelocidade;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

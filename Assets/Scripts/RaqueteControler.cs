using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteControler : MonoBehaviour
{

    private Vector3 minhaPosicao; 
    public float meuY;
    public float velocidade = 5f;
    public float meuLimite = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        //pegando a posição inicial da raquete e aplicando à minha posição
        minhaPosicao = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
   
        //Passando o meuY para o eixo Y da minhaPosicao
        minhaPosicao.y = meuY;

        //modificar a posicao da minha raquete
        transform.position = minhaPosicao;

        //Pegando a setinha para cima
        //Se eu apertar a setinha para cima ele vai subir a raquete
        if (Input.GetKey(KeyCode.UpArrow)) {//primeira forma
            //Checar se meuY é menor do que o meu limite
            if(meuY < meuLimite)
            {
                //Ação para quando a setinha para cima for pressionada
                //Aumentar o valor do meuY APENAS SE ele for menor do que o meu limite
                meuY = meuY + velocidade * Time.deltaTime; //Para se igualar a qualquer PC
            }

           

        }
        //Se eu apertar a setinha para baixo ele vai descer a raquete E Aumentar o valor do meuY APENAS SE ele for maior do que o meu limite
        if (Input.GetKey(KeyCode.DownArrow) && meuY > -meuLimite) //segundo forma
        {
     
                //Ação para quando a setinha para baixo for pressionada
                //Aumentar o valor do meuY APENAS SE ele for maior do que o meu limite
                meuY = meuY - velocidade * Time.deltaTime; //Para se igualar a qualquer PC
           
        }
    }
}

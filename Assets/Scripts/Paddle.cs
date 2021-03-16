using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    float velocidade = 0.5f;

    
    // Update is called once per frame
    void Update()
    {
        /**
         * se tecla para cima premida
         * então subir
         * senão se tecla para baixo premida
         * então descer
         */



        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position =
                transform.position + velocidade * Vector3.up;
        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position =
                transform.position + velocidade * Vector3.down;
            //Desce
        }

    }
}

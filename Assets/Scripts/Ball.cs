﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;
    bool bolaFoiLancada = true;
    float timer;


    // Start is called before the first frame update
    void Start()
    {
        //if(Random.value < 0.5f)
        //{
        //    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.right;
        //} else
        //{
        //    GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.left;
        //}

        GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitCircle;
    }

    // Update is called once per frame
    void Update()
    {

        if (bolaFoiLancada)
        {
            timer += Time.deltaTime;
        }

        if(timer >= 2f)
        {
            GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitCircle;
        }
        
         
    }
}

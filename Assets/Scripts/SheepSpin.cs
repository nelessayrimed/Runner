﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSpin : MonoBehaviour {

    float randx;
    float randy;
    float randz;
    int counter;
    private Vector3 tmp;
    public GameObject player;
    private void Start()
    {
        counter = 0;
        changeRote();
    }
    // Update is called once per frame
    void FixedUpdate () {
        
        counter++;
        tmp = transform.position;
        if ((transform.position.y<8*transform.localScale.y)&&(counter<10))
        {
            tmp.y+=0.015f;
        }
        if((transform.position.y>0) && (counter>10))
        {
            tmp.y -= 0.015f;
        }
        //tmp.z = player.transform.position.z;
        //tmp.x = player.transform.position.x;
        transform.position = tmp;
        if ((transform.position.y==0)||(counter==20))
        {
           // changeRote();
            counter = 0;
        }
        // transform.Rotate(randx, randy, randz);
        transform.Rotate(3,0,0);
     
   
    }
    void changeRote()
    {
        int k;
        randx = Random.Range(1.5f, 3);
        randy = Random.Range(1.5f, 3);
        randz = Random.Range(1.5f, 3);
        k = Random.Range(-1, 1);
        if (k < 0)
        {
            randx = -randx;
        }
        k = Random.Range(-1, 1);
        if (k < 0)
        {
            randy = -randy;
        }
        k = Random.Range(-1, 1);
        if (k < 0)
        {
            randz = -randz;
        }
    }
}

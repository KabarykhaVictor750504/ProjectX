﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


[RequireComponent (typeof(Player))] 

public class RunScript : MonoBehaviour
{

    public Player Player;

    private void Start()
    {
        
        Player = GetComponent<Player>();
       
    }

    private void Update()
    {
        if (Time.timeScale == 1)
        {
            if(Input.GetKeyDown(KeyCode.Space))
                Player.Jump();
            if(Input.GetKeyDown(KeyCode.F))
                Player.Attack();
            Player.Move();
            Player.Damage();
            Player.Health();
        }
       
    }
}

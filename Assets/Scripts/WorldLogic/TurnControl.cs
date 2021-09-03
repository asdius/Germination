﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnControl : MonoBehaviour
{
    // 4 turno asignado
    // 5 salto
    // 7 ataco
    private int estado = 0;
    CharctesSelection teamselection;
    public int Estado { get => estado; set => estado = value; }

    private void Start()
    {
        teamselection = GetComponent<CharctesSelection>();
    }
    // Update is called once per frame
    void Update()
    {
        if (estado >= 7 && teamselection.Team == 1)
        {
            Debug.Log("Turno acabado");
            teamselection.Team += 1;
            estado = 0;
        }
        else if (estado >= 7 && teamselection.Team == 2)
        {
            Debug.Log("Turno acabado");
            teamselection.Team -= 1;
            estado = 0;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Context
{
    private Transform player;
    private Strategy strategy;
    private Rigidbody2D rb;
    private Enemigo enemigo { get; set; }
    private float attackRange;
    public Context(Enemigo enemigo, Transform player, Rigidbody2D rb, float attackRange)
    {
        this.enemigo = enemigo;
        this.player = player;
        this.rb = rb;
        this.attackRange = attackRange;
    }

    public void escogerEstrategia()
    {
        float distanceToPlayer = Vector2.Distance(rb.position, player.position); //Revisa la distancia del jefe con el jugador
        if (distanceToPlayer <= attackRange) //Si el jugador esta en el rango de ataque del jefe, el jefe ataca
        {
            this.strategy = new Attack(this.enemigo);
            ejecutarEstrategia();
        }
        else //El jefe se mueve si el jugador esta fuera del rango de ataque
        {
            this.strategy = new Run(this.enemigo);
            ejecutarEstrategia();
        }
    }

    public void ejecutarEstrategia() // Se ejecuta la estrategia
    {
        strategy.execute();
    }
}


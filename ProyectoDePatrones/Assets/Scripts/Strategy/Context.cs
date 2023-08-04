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
        float distanceToPlayer = Vector2.Distance(rb.position, player.position);
        if (distanceToPlayer <= attackRange)
        {
            this.strategy = new Attack(this.enemigo);
            ejecutarEstrategia();
        }
        else
        {
            this.strategy = new Run(this.enemigo);
            ejecutarEstrategia();
        }
    }

    public void ejecutarEstrategia()
    {
        strategy.execute();
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Attack : Strategy
{
    private Enemigo enemigo { get; set; }

    public Attack(Enemigo enemigo)
    {
        this.enemigo = enemigo;
    }

    public void execute()
    {
        enemigo.Attack();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Run : Strategy
{
    private Enemigo enemigo { get; set; }

    public Run(Enemigo enemigo)
    {
        this.enemigo = enemigo;
    }

    public void execute()
    {
        enemigo.Run();
    }

}


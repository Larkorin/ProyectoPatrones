using Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object = UnityEngine.Object;
namespace Assets.Scripts.AbstractFactory
{
    public class EnemigoFactory
    {
        private readonly EnemigosConfiguration enemyConfiguration;

        public EnemigoFactory(EnemigosConfiguration enemyConfiguration)
        {
            this.enemyConfiguration = enemyConfiguration; // Se añade la configuración de EnemigoConfiguration al constructor
        }

        public Enemigo Create(string nombre)
        {
            var enemigo = enemyConfiguration.GetEnemigoPrefabById(nombre); // Busca el prefab del enemigo
            return Object.Instantiate(enemigo); // Instancia el prefab
        }
    }
}

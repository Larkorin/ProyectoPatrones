using System;
using System.Collections.Generic;
using UnityEngine;

namespace Heroes
{
    [CreateAssetMenu(menuName = "Custom/Enemigos Configuration")] // Nombre de la configuración en Unity
    public class EnemigosConfiguration : ScriptableObject
    {
        [SerializeField] private Enemigo[] enemigos; // Lista que conteine todos los tipos de enemigos que hay en forma de prefabs
        private Dictionary<string, Enemigo> enemigoName; // Diccionario para buscar los enemigos

        private void Awake()
        {
            enemigoName = new Dictionary<string, Enemigo>(); // Se crea el diccionario
            foreach (var enemigo in enemigos) // Iterador que pasa por todos los enemigos(en forma de prefabs) en la lista
            {
                enemigoName.Add(enemigo.Name, enemigo); // Añade el enemigo al diccionario para que pueda ser buscado
            }
        }

        public Enemigo GetEnemigoPrefabById(string nombre)
        {
            if (!enemigoName.TryGetValue(nombre, out var enemigo)) // Busca al enemigo en le diccionario
            {
                throw new Exception($"Enemigo tipo {nombre} no existe"); // En caso de que el tipo de enemigo indicado no exista
            }

            return enemigo; // Retorna el enemigo indicado
        }
    }
}

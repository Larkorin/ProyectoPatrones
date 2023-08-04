using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Ranita : MonoBehaviour
{
    public EnemigoNormal Intrinseco;
    public Habilidad habilidad;
    public int Capacidad;

    private Image _spriteImage;
    private Text _nombreTxt;
    private Text _DescripcionTxt;

    //AÑADIR DESDE AQUI UN GAME OBJ ENEMIGO SIN ARRAY Y LUEGO VER DONDE ENLAZAR ESTE SCRIPT
    private void Awake()
    {
        _spriteImage = transform.Find("Image").GetComponent<Image>();
        _nombreTxt = transform.Find("NameText").GetComponent<Text>();
        _DescripcionTxt = transform.Find("DescriptionText").GetComponent<Text>();

        _spriteImage.sprite = Intrinseco.Sprite;
        _nombreTxt.text = Intrinseco.Nombre;
        _DescripcionTxt.text = Intrinseco.Descripcion;

        habilidad = new Colision();

        //ALÑADIR LOGS AQUI PARA VER QUE DEVUELVEN
    }

    public Ranita Clonar()
    {
        GameObject clonedObject = Instantiate(gameObject, transform.parent);
        Ranita clonedBackpack = clonedObject.GetComponent<Ranita>();

        clonedBackpack.Intrinseco = Intrinseco;
        clonedBackpack.Capacidad = Capacidad;

        return clonedBackpack;
    }
    public void Clonar(GameObject[] enemigo,Vector2 pos, Quaternion quaternion)
    {
        int randomEnemigos = Random.Range(0, enemigo.Length);
         
        GameObject clonedObject = Instantiate(enemigo[randomEnemigos],pos, quaternion);
        //Ranita clonedRanita = clonedObject.GetComponent<Ranita>();

        //clonedRanita.Intrinseco = Intrinseco;
        //clonedRanita.Capacidad = Capacidad;

        //return clonedBackpack;
    }

    public void Kill()
    {
        Destroy(gameObject);
    }
}

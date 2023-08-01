using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSelect : MonoBehaviour
{

    public enum Gun { unarm, sword, hammer, gun, riffle };
    public Gun GunSelected;

    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public RuntimeAnimatorController[] gunsController;
    public Sprite[] gunRender;

    void Start()
    {
        switch (GunSelected)
        {
            case Gun.unarm:
                //spriteRenderer.sprite = gunRender[0];
               // animator.runtimeAnimatorController = gunsController[1];
                break;
            case Gun.sword:
               // spriteRenderer.sprite=gunRender[1];
               // animator.runtimeAnimatorController = gunsController[1];
                break;
            case Gun.hammer:
                animator.runtimeAnimatorController = gunsController[2];
                break;
            case Gun.gun:
                animator.runtimeAnimatorController = gunsController[3];
                break;
            case Gun.riffle:
                animator.runtimeAnimatorController = gunsController[4];
                break;
            default:
                break;
        }

    }


}

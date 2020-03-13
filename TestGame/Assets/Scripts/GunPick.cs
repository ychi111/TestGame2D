using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPick : MonoBehaviour
{
    /*
    TODO:
        - Разобраться, как взаимодействовать между объектами:
            * когда персонаж подходит к оружию, загорается спрайт с буквой Е
            * персонаж нажимет на Е и оружие пропадает
     */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer e_but = this.gameObject.GetComponentInChildren<SpriteRenderer>();
        e_but.enabled = true;
    }
}

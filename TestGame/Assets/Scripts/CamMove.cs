using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{

    /*
     TODO:
        - Сделать паузу
        - Сделать сцену - меню игры с переходом на главную сцену
        - Сделать набросок интерфейса, неважно с чем, просто понять, как это. 
            Можно, к примеру, добавить персонажу инвентарь и хп
        - Как-то перелапатить камеру, которая двигается за персонажем, чтобы это смотрелось адекватно
     */

    public GameObject naruto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(naruto.transform.position.x+2, naruto.transform.position.y+3.5f, -1f);
    }
}

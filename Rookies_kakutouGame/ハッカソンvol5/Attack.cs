using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    GameObject Cube2;//Cube2そのものが入る変数

    cube2_hp script;//cube2_hpが入る変数

    // Start is called before the first frame update
    void Start()
    {
        Cube2 = GameObject.Find("Cube2");//Cube2をオブジェクト名から取得して変数に格納
        script = Cube2.GetComponent<cube2_hp>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        script.HP -= 20;
        if (script.HP == 0)
        {
            Destroy(collision.gameObject);
        }
    }
}

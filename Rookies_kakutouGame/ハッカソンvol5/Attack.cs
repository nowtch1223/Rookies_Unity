using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    GameObject Cube2;//Cube2���̂��̂�����ϐ�

    cube2_hp script;//cube2_hp������ϐ�

    // Start is called before the first frame update
    void Start()
    {
        Cube2 = GameObject.Find("Cube2");//Cube2���I�u�W�F�N�g������擾���ĕϐ��Ɋi�[
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

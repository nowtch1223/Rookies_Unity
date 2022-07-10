using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeManager : MonoBehaviour
{


    public GameObject fight;   //�t�F�[�h�p�l���̎擾

    Text fadealpha;               //�t�F�[�h�p�l���̃C���[�W�擾�ϐ�

    private float alpha;           //�p�l����alpha�l�擾�ϐ�

    private bool fadeout;          //�t�F�[�h�A�E�g�̃t���O�ϐ�
    private bool fadein;      �@�@ //�t�F�[�h�C���̃t���O�ϐ�

    //public int SceneNo;            //�V�[���̈ړ���i���o�[�擾�ϐ�


    // Use this for initialization
    void Start()
    {
        fight = GameObject.Find("fight");
        fadealpha = fight.GetComponent<Text>(); //�p�l���̃C���[�W�擾
        alpha = fadealpha.color.a;                 //�p�l����alpha�l���擾
        fadein = true;                             //�V�[���ǂݍ��ݎ��Ƀt�F�[�h�C��������
    }

    // Update is called once per frame
    void Update()
    {
        


        if (fadein == true)
        {
            FadeIn();
        }

        if (fadeout == true)
        {
            FadeOut();
        }
    }

    void FadeIn()
    {
        alpha -= 0.01f;
        fadealpha.color = new Color(0, 0, 0, alpha);
        if (alpha <= 0)
        {
            fadein = false;
            fight.SetActive(false);

        }
    }

    void FadeOut()
    {
        
        alpha += 0.01f;
        fadealpha.color = new Color(0, 0, 0, alpha);
        if (alpha >= 1)
        {
            fadeout = false;
            //SceneManager.LoadScene("Fade" + SceneNo);
        }
    }

    public void SceneMove()
    {
        fadeout = true;
        fight.SetActive(true);
    }
}
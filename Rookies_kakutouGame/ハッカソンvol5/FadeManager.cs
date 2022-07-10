using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeManager : MonoBehaviour
{


    public GameObject fight;   //フェードパネルの取得

    Text fadealpha;               //フェードパネルのイメージ取得変数

    private float alpha;           //パネルのalpha値取得変数

    private bool fadeout;          //フェードアウトのフラグ変数
    private bool fadein;      　　 //フェードインのフラグ変数

    //public int SceneNo;            //シーンの移動先ナンバー取得変数


    // Use this for initialization
    void Start()
    {
        fight = GameObject.Find("fight");
        fadealpha = fight.GetComponent<Text>(); //パネルのイメージ取得
        alpha = fadealpha.color.a;                 //パネルのalpha値を取得
        fadein = true;                             //シーン読み込み時にフェードインさせる
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
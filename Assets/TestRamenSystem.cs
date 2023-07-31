using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestRamenSystem : MonoBehaviour
{
    private int num_of_maked_ramen; //作ったラーメンの数
    private float sec_of_touching_wh; //ラーメンに熱湯をそそいた秒数
    private bool is_having_ramen; //ラーメンを持っているかどうか

    // Start is called before the first frame update
    void Start()
    {
        num_of_maked_ramen = 0;
        sec_of_touching_wh = 0.0f;
        is_having_ramen = false;
    }

    void Update()
    {

    }


    // 衝突した時に呼び起こされる関数
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "kono")
        {   //ラーメンと河野先生が衝突した場合

            is_having_ramen = true;
            Destroy(gameObject); //河野先生にラーメンを渡したら，持っていたラーメンを消す．
            SceneManager.LoadScene("GameClear");

        }
    }
}
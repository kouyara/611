using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;
using System.Diagnostics;
using System.IO;

public class OnCollisionLeft : MonoBehaviour
{
    public AudioClip sound_ramen;
    public AudioClip sound_kono;
    AudioSource audioSource;
    public GameObject hand_ramen;//手に持っているラーメン
    public int num_of_maked_ramen = 0; //作ったラーメンの数
    private bool is_having_ramen; //ラーメンを持っているかどうか
    public bool give_ramen; //ラーメンを渡したかどうか

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); //Componentを取得
        hand_ramen.SetActive(false); //ラーメンは見えない。
        is_having_ramen = false; //ラーメンを持っているかどうか
        give_ramen = false; //ラーメンを渡していないので、初期値はfalse。
    }

    void Update()
    {
        give_ramen = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "ramen0") || (collision.gameObject.name == "ramen1") || (collision.gameObject.name == "ramen2"))
        {   //ラーメンに衝突した場合
            SceneManager.LoadScene("GameOver");
            //if (is_having_ramen == false)
            //{
            //    audioSource.PlayOneShot(sound_ramen);
            //    hand_ramen.SetActive(true); //ラーメンを持つ
            //    is_having_ramen = true;
            //    Destroy(collision.gameObject); //とったラーメンを消す
            //    give_ramen = true; //ラーメンを渡すと、値はtrue。
            //}
        }

        else if (collision.gameObject.name == "sano")
        {   //佐野さんに衝突した場合
            SceneManager.LoadScene("GameOver");
        }

        else if (collision.gameObject.name == "kono")
        {
            if (is_having_ramen)
            {   //河野先生に衝突した場合
                if (is_having_ramen == true)
                {
                    audioSource.PlayOneShot(sound_kono);
                    hand_ramen.SetActive(false);
                    is_having_ramen = false;
                    num_of_maked_ramen = num_of_maked_ramen + 1;

                    //if (num_of_maked_ramen >= 3)
                    //{
                    //    time = $"time  {stopwatch.Elapsed.Minutes}:{stopwatch.Elapsed.Seconds}";
                    //    SceneManager.LoadScene("GameClear");
                    //}
                }
            }
        }
    }
}
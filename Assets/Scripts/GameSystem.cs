using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;
using System.Diagnostics;
using System.IO;

public class GameSystem : MonoBehaviour
{
    public AudioClip sound_ramen;
    public AudioClip sound_kono;
    AudioSource audioSource;
    public GameObject hand_ramen;//手に持っているラーメン

    public int num_of_maked_ramen = 0; //作ったラーメンの数
    private bool is_having_ramen; //ラーメンを持っているかどうか

    public TextMeshProUGUI TextMeshPro1;
    public TextMeshProUGUI TextMeshPro2;
    public TextMeshProUGUI TextMeshPro3;
    public TextMeshProUGUI TextMeshPro4;
    public TextMeshProUGUI TextMeshPro5;
    public TextMeshProUGUI TextMeshPro6;
    public TextMeshProUGUI TextMeshPro7;
    public TextMeshProUGUI TextMeshPro8;
    public TextMeshProUGUI TextMeshPro9;

    Stopwatch stopwatch = new Stopwatch();

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); //Componentを取得
        hand_ramen.SetActive(false); //ラーメンは見えない
        is_having_ramen = false; //ラーメンを持っているかどうか。
        stopwatch.Start(); //ストップウォッチをスタートする。
    }

    void Update()
    {
        GameSystem gamesystem = GetComponent<GameSystem>();
        TimeSpan ts = stopwatch.Elapsed;
        //獲得したラーメンと、秒数をテキストに表示させる。
        TextMeshPro1.text = $"You have CapRamens : {num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro2.text = $"You have CapRamens : {num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro3.text = $"You have CapRamens : {num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro4.text = $"You have CapRamens : {num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro5.text = $"You have CapRamens : {num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro6.text = $"You have CapRamens : {num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro7.text = $"You have CapRamens : {num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro8.text = $"You have CapRamens : {num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro9.text = $"You have CapRamens : {num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
    }

    // 衝突した時に呼び起こされる関数
    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "ramen0") || (collision.gameObject.name == "ramen1") || (collision.gameObject.name == "ramen2"))
        {   //ラーメンに衝突した場合
            if (is_having_ramen == false)
            {
                audioSource.PlayOneShot(sound_ramen);
                hand_ramen.SetActive(true); //ラーメンを持つ
                is_having_ramen = true;
                Destroy(collision.gameObject); //とったラーメンを消す
            }
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

                    if (num_of_maked_ramen == 3)
                    {
                        string filePath = Path.Combine(Application.streamingAssetsPath, "time.txt");
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.Write(stopwatch.Elapsed.ToString());
                        }
                            SceneManager.LoadScene("GameClear");
                    }
                }
            }
        }
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Diagnostics;

public class GameOver : MonoBehaviour
{
    Stopwatch stopwatch = new Stopwatch();
    public static string time;

    void Start()
    {
        stopwatch.Start(); //ストップウォッチをスタートする。
    }


    void Update()
    {
        GameSystem gamesystem = GetComponent<GameSystem>();
        TimeSpan ts = stopwatch.Elapsed;
        if ($"{ts.Seconds}" ==  "24")
        {
            SceneManager.LoadScene("Title");
        }
    }
}

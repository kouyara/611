using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Diagnostics;
using System.Threading;
using UnityEngine.SceneManagement;

public class ScareSystem : MonoBehaviour
{
    int HaveCapRamens = 0; //渡したラーメンの数

    public TextMeshProUGUI TextMeshPro;
    public GameObject ramen0;
    public GameObject ramen1;
    public GameObject ramen2;
    private bool ramen0Bool;
    private bool ramen1Bool;
    private bool ramen2Bool;

    Stopwatch stopwatch = new Stopwatch();

    int TimeMinute = 0;
    int Timesec = 0;

    void Start()
    {
        stopwatch.Start();

    }

    private void Update()
    {
        if (!ramen0Bool && ramen0 == null)
        {
            HaveCapRamens = HaveCapRamens + 1;
            ramen0Bool = true;
        }
        if (!ramen1Bool && ramen1 == null)
        {
            HaveCapRamens = HaveCapRamens + 1;
            ramen1Bool = true;
        }
        if (!ramen2Bool && ramen2 == null)
        {
            HaveCapRamens = HaveCapRamens + 1;
            ramen2Bool = true;
        }

        TimeSpan ts = stopwatch.Elapsed;
        TextMeshPro.text = $"You have CapRamens : {HaveCapRamens}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
    }
}
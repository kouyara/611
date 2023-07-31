using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Diagnostics;
using System.Threading;

public class ScareSystem : MonoBehaviour
{

    private TextMeshProUGUI textMeshPro;
    int HaveCapRamens = 0;

    Stopwatch stopwatch = new Stopwatch();

    int TimeMinute = 0;
    int Timesec = 0;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        stopwatch.Start();

    }

    private void Update()
    {
        TimeSpan ts = stopwatch.Elapsed;
        textMeshPro.text = $"You have CapRamens : {HaveCapRamens}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
    }
}
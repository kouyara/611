using UnityEngine;
using TMPro;
using System;
using System.Diagnostics;

public class ScareSystem : MonoBehaviour
{
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
        stopwatch.Start();

    }

    private void Update()
    {
        GameSystem gamesystem = GetComponent<GameSystem>();
        TimeSpan ts = stopwatch.Elapsed;
        TextMeshPro1.text = $"You have CapRamens : {gamesystem.num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro2.text = $"You have CapRamens : {gamesystem.num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro3.text = $"You have CapRamens : {gamesystem.num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro4.text = $"You have CapRamens : {gamesystem.num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro5.text = $"You have CapRamens : {gamesystem.num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro6.text = $"You have CapRamens : {gamesystem.num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro7.text = $"You have CapRamens : {gamesystem.num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro8.text = $"You have CapRamens : {gamesystem.num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
        TextMeshPro9.text = $"You have CapRamens : {gamesystem.num_of_maked_ramen}\nTime : {ts.Minutes}:{ts.Seconds}.{ts.Milliseconds}";
    }
}
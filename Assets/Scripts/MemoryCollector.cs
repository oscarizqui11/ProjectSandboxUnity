using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class MemoryCollector : MonoBehaviour
{
    static StreamWriter dataLog;
    static StreamWriter timeLog;
    private long memoryReserved;

    // Start is called before the first frame update
    void Awake()
    {
        dataLog = new StreamWriter("Memoria4.csv");
        timeLog = new StreamWriter("Tiempo4.csv");

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        memoryReserved = GC.GetTotalMemory(false);
        dataLog.WriteLine(memoryReserved);
        timeLog.WriteLine(Time.time - Time.fixedDeltaTime);
    }

    private void OnApplicationQuit()
    {
        dataLog.Close();
        timeLog.Close();
    }
}

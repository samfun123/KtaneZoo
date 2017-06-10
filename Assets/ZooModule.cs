﻿using System;
using System.Collections.Generic;
using System.Linq;
using <ModuleID>;
using UnityEngine;
using Rnd = UnityEngine.Random;

/// <summary>
/// On the Subject of Zoo
/// Created by Timwi
/// </summary>
public class ZooModule : MonoBehaviour
{
    public KMBombInfo Bomb;
    public KMBombModule Module;
    public KMAudio Audio;

    void Start()
    {
        Debug.Log("[<Module Name>] Started");
    }

    void ActivateModule()
    {
        Debug.Log("[<Module Name>] Activated");
    }
}
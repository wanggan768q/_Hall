﻿using System;
using UnityEngine;

public class Constants : MonoBehaviour
{
    public static string IP = "101.37.85.230";
    public const int MSGLENTH = 4;
    public const int PORT = 0x22c3;

    public static string GetIP()
    {
        return IP;
    }
}


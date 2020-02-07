﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsSave : MonoBehaviour
{
    // PlayerCamera
    public float mouseSensitivity;

    private void Start()
    {
        // Defaults
        mouseSensitivity = 100f;
    }

    public void StartSaveData()
    {
        SaveSystem.SaveData(this);
    }
}

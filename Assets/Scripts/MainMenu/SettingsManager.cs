﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public GameObject volumeSettings;
    public GameObject debugButton2;

    private List<GameObject> allSettings;

    private void Start()
    {
        allSettings.Add(volumeSettings);
        allSettings.Add(debugButton2);
    }

    private void activateSetting(GameObject settingToActivate)
    {
        foreach (GameObject gameObject in allSettings)
        {
            if (gameObject != settingToActivate)
            {
                gameObject.SetActive(false);
            }
            settingToActivate.SetActive(true);
        }
    }

    public void onVolumeDown()
    {
        activateSetting(volumeSettings);
    }

    public void onDebugTwo()
    {
        activateSetting(debugButton2);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] private int TARGET_FPS = 60;


    private void Awake()
    {
        Application.targetFrameRate = TARGET_FPS;
        print($"TARGET_FPS - {TARGET_FPS}");
    }
}

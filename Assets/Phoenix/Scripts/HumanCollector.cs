using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanCollector : MonoBehaviour
{
    public float Humans = 0;
    public int score;
    public static HumanCollector instance;

    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

}

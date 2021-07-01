using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public sealed class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; }

    public Color TeamColor { get; set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);
    }
}

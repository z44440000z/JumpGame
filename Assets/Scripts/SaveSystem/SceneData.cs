﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[System.Serializable]
public class RingData
{
    public int index;
    public bool isGet = false;
    public float x, y, z;
}


[System.Serializable]
[CreateAssetMenu(fileName = "new SceneData", menuName = "SceneData")]
public class SceneData : ScriptableObject
{
    public int SceneIndex;
    public int RingCount;
    public Vector3 StartPosition;
}
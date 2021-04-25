﻿using UnityEngine;

public class Car : MonoBehaviour
{
    // 註解

    /* 註解
     * 註解 註解
     * 註解 註解 註解
     * 註解 註解
     * 註解
     */

    //[欄位名稱(屬性內容)]
    //[Header(""), ToolTip(""), Range(,)]

    [Header("C.C."), Tooltip("車的C.C."), Range(1000,5000)]
    public int cc = 2000;
    [Header("重量"), Tooltip("車的重量"), Range(1.00f, 10.00f)]
    public float weight = 1.5f;
    [Header("品牌"), Tooltip("車的品牌")]
    public string brand = "BMW";
    [Header("窗戶"), Tooltip("車窗是否開啟")]
    public bool windows = false;

    public char c = 'c';

    // Unity
    // Color
    // 座標2維-4維 Vector2、Vector3、Vector4

    public Color color = Color.red;
    public Color purple = new Color(0.3f, 0, 0.6f);
    public Color grey = new Color(0.5f, 0.5f, 0.5f, 0.5f); //(R比例, G比例, B比例, 不透明度)


}
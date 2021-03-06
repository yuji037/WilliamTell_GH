﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G20_ComponentUtility
{
    static string rootStr = "G20_Root";
    static Transform root;
    public static Transform Root
    {
        get
        {
            if (root == null)
            {
                root = FindRoot();
            }
            return root;
        }
    }
    static Transform FindRoot()
    {
        return GameObject.Find(rootStr).transform;
    }
    //scene上に一つしかないcompornentを返す
    public static type FindComponentOnScene<type>()
        where type : MonoBehaviour
    {
        type ret=null;
        try
        {
            return Root.GetComponentInChildren<type>();
        }
        catch
        {
            Debug.Log("error:"+rootStr+"が見つかりませんでした。");
        }
        return ret;
    }
}

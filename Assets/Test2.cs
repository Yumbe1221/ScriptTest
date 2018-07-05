using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int array = { 10, 20, 30, 40, 50 };

        // 配列の要素をすべて昇順で表示する
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        // 配列の要素をすべて降順で表示する
        for (int i = array.Length-1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

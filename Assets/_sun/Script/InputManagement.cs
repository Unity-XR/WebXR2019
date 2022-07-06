using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManagement : MonoBehaviour
{
    public InputData[] inputDatas;
    void Start()
    {
        for (int i = 0; i < inputDatas.Length; i++)
        {
            inputDatas[i].Init();
        }
    }
}
[Serializable]
public class InputData{
    public InputControl inputObject;
    public InputEvent objectEvent;
    public void Init(){
        inputObject.onMouseDown = objectEvent;
    }
}
[Serializable]
public class InputEvent : UnityEvent{

}

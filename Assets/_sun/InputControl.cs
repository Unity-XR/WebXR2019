using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputControl : MonoBehaviour
{
    public UnityEvent onMouseDown;
    private void OnMouseDown() {
        onMouseDown.Invoke();
    }
}

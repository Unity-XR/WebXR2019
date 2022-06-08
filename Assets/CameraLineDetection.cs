using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraLineDetection : MonoBehaviour
{
    public float rayTimeMax = 3;
    public float rayTime;
    public Image rayTimeImage;
    void Update()
    {
        Ray ray = new Ray(transform.position,transform.forward);
        
        RaycastHit hitInfo;
        if(Physics.Raycast(ray,out hitInfo))
        {
            rayTime -= Time.deltaTime;
            if(rayTime <= 0){
                hitInfo.collider.GetComponent<InputControl>().onMouseDown.Invoke();
            }
        }
        else
        {
            rayTime = rayTimeMax;
        }
        rayTimeImage.fillAmount = 1 - (rayTime / rayTimeMax);
        Debug.DrawLine(Camera.main.gameObject.transform.position, transform.forward * 1000);
    }
}

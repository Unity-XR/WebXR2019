using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public Material[] sceneSkyBox;
    public MeshRenderer meshRenderer;
    public void onToggleButtons(int sceneId){
        meshRenderer.material = sceneSkyBox[sceneId];
    }
}

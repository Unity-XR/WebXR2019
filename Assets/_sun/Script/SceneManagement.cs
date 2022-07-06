using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public Material sceneSkyBox;
    public Texture[] textures;
    public MeshRenderer meshRenderer;

    private void Start()
    {
        sceneSkyBox.SetTexture("_MainTex", textures[0]);
    }
    public void onToggleButtons(int sceneId)
    {
        sceneSkyBox.SetTexture("_MainTex", textures[sceneId]);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GoogleSheet : MonoBehaviour
{

    private TextMesh m_text;
    public void SetText(TextMesh text)
    {
        m_text = text;
    }
    public void GetData(int id)
    {
        StartCoroutine(Upload(id));
    }

    IEnumerator Upload(int id)
    {
        WWWForm form = new WWWForm();
        form.AddField("method", "read");
        form.AddField("id", id);
        //form.AddField("dataId", dataId);

        using (UnityWebRequest www = UnityWebRequest.Post("https://script.google.com/macros/s/AKfycbxFMhASuUVbTJPHebZkp7nt82BJs6AX4Zv76qt81j57titHFxVk-JrmvYmPDjb_5bIE/exec", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {

                GoogleData b = new GoogleData();
                JsonUtility.FromJsonOverwrite(www.downloadHandler.text, b);
                Debug.Log(b.typeData);
                switch (b.typeData)
                {
                    case "Url":
                        Application.OpenURL(b.dataContent);
                        break;
                    case "Text":
                        Debug.Log(b.dataContent);
                        m_text.text = b.dataContent;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
public class GoogleData
{
    public enum TypeData
    {
        Url,
        Text
    }
    public string typeData;
    public string dataContent;
}

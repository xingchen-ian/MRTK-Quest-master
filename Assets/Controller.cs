using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    UniWebView uniWebView;
    public RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        var webViewGameObject = new GameObject("UniWebView");
        uniWebView = webViewGameObject.AddComponent<UniWebView>();

        uniWebView.Frame = new Rect(0, 0, Screen.width, Screen.height); // 1
        uniWebView.ReferenceRectTransform = rectTransform;
        uniWebView.Load("https://docs.uniwebview.com/game.html");       // 2
        uniWebView.Show();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

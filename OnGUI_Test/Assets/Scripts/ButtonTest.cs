using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    public Texture btnTexture;
    public int nDefaultSelectIndex      = 0;
    public string[] strToolBars         = {"toolbar1", "toolbar2", "toolbar3"};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        // GUI:Button
        GUI.backgroundColor = Color.red;
        GUI.Button(new Rect(320, 100, 100, 50), "Red Button");
        if (GUI.Button(new Rect(320, 300, 128, 128), btnTexture))
        {
            Debug.Log("Clicked the button with an image");
        }
        if (GUI.Button(new Rect(320, 250, 100, 50), "click here"))
        {
            Debug.Log("you have click here!");
        }

        // GUI:Label
        GUI.Label(new Rect(320, 450, 100, 20), "Hello Lable");

        // GUI:Box
        GUI.Box(new Rect(0, 0, 100, 50), "Top-Left");
        GUI.Box(new Rect(Screen.width - 100, 0, 100, 50), "Top-Right");
        GUI.Box(new Rect(0, Screen.height - 50, 100, 50), "Buttom-Left");
        GUI.Box(new Rect(Screen.width - 100, Screen.height - 50, 100, 50), "Buttom-Right");

        // GUI:TextField
        GUI.TextField(new Rect(500, 100, 200, 20), "Hello TextField", 25);
        
        // GUI:TextArea
        GUI.TextArea(new Rect(500, 150, 200, 200), "Hello TextArea", 25);

        // GUI:Color     
        GUI.color = Color.yellow;
        GUI.Label(new Rect(100, 10, 100, 20), "Hello World!");
        GUI.Box(new Rect(100, 50, 50, 50), "A BOX");
        GUI.Button(new Rect(100, 110, 70, 30), "A button");

        // GUI:scroll
        Vector2 scrollPosition = Vector2.zero;
        GUI.BeginScrollView(new Rect(100, 200, 200, 200), scrollPosition, new Rect(0, 0, 800, 800));
        GUI.Button(new Rect(0, 0, 100, 20), "Top-left");
        GUI.Button(new Rect(100, 0, 100, 20), "Top-right");
        GUI.Button(new Rect(0, 0, 20, 200), "Bottom-left");
        GUI.Button(new Rect(160, 0, 20, 200), "Bottom-right");
        GUI.EndScrollView();

        // GUI:Slider
        GUI.HorizontalSlider(new Rect(800, 100, 120, 20), 0.0f, 0.0f, 1.0f);
        GUI.VerticalSlider(new Rect(800, 150, 20, 120), 0.0f, 1.0f, 0.0f);

        // GUI:Toolbar
        GUI.Toolbar(new Rect(800, 400, 210, 70), nDefaultSelectIndex, strToolBars);

        GUI.Box(new Rect(950, 100, 150, 175), new GUIContent("Box", "this box has a tooltip"));
    }
}

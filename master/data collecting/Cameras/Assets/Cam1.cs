using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Cam1 : MonoBehaviour
{
    Texture2D getScreen;
    Camera cam1 = new Camera();

    // Start is called before the first frame update
    public void Start()
    {
        //OnPostRender(i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPostRender(int i)
    {
        //cam1.enabled = false;
        //cam1.enabled = true;
        getScreen = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        getScreen.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, false);
        getScreen.Apply();

        byte[] bytes = getScreen.EncodeToPNG();
        File.WriteAllBytes(@"C:\Users\Jasiek\Desktop\NANO\Magisterka\Pomiar_13.04\" + i + "_1.png", bytes);
       // cam1.enabled = false;

    }
}

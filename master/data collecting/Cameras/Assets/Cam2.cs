using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Cam2 : MonoBehaviour
{
    Texture2D getScreen;


    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPostRender(int i)
    {
        //Display.displays[3].Activate();
        getScreen = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        getScreen.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, false);
        getScreen.Apply();

        byte[] bytes = getScreen.EncodeToPNG();
        File.WriteAllBytes(@"C:\Users\Jasiek\Desktop\NANO\Magisterka\Pomiar_13.04\" + i + "_2.png", bytes);

    }
}

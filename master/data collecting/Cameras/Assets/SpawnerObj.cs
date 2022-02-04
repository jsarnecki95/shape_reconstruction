using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SpawnerObj : MonoBehaviour
{   
    ObjGenerator meshtest;
    //MeshGenerator meshtest;
    Texture2D getScreen;

    public GameObject cam1;
    public GameObject cam1d;
    public GameObject cam2;
    public GameObject cam2d;
    public GameObject cam3;
    public GameObject cam3d;



    //tu to samo dla kamer

    // Start is called before the first frame update
    void Start()
    {

        meshtest = GameObject.FindGameObjectWithTag("Mesh").GetComponent<ObjGenerator>();
        //tu to samo dla kamer
        //Debug.Log(Lol(1));
        //meshtest.Start();
        StartCoroutine(loopDelay());

    
      

        //Update();
        //Invoke("BorrowStart", 2.0f);
    }


    // Update is called once per frame
    void BorrowStart()
    {
        
        meshtest.Start();
        
    }

    IEnumerator loopDelay()
    {
        for (int p = 1; p < 100; p++)
        {
            //meshtest.Rotator1();
            //       -------->        tu randomowo wybiera kolor a w pliku ObjGenerator bedzie randomowo wybierac model i minirotacje
            System.Random rnd = new System.Random();
            int l = rnd.Next(1, 6);
            var meshRenderer = meshtest.GetComponent<Renderer>();
            switch (l)
            {
                case 1:
                    
                    meshRenderer.material.SetColor("_Color", Color.green);
                    break;
                case 2:
                    
                    meshRenderer.material.SetColor("_Color", Color.yellow);
                    break;
                case 3:
                    
                    meshRenderer.material.SetColor("_Color", Color.magenta);
                    break;
                case 4:
                    
                    meshRenderer.material.SetColor("_Color", Color.cyan);
                    break;
                case 5:
                    
                    meshRenderer.material.SetColor("_Color", Color.white);
                    break;
            }
            
            //meshtest.Clear();
            BorrowStart();
            //meshtest.Rotator1();
            //meshtest.Rotator();
            //meshtest.Start();
            //Capture(p);
            //funkcja screenshot dla kamer 1-6
            Debug.Log("Przejscie " + p);
            //Capture(p);
            camDeactivator();
            yield return new WaitForEndOfFrame();
            StartCoroutine(Capture(p));
            yield return new WaitForSeconds(1);
            //meshtest.Rotator2();
        }
        //print("started delay");
        //yield return new WaitForSeconds(60);
    }

    //tu funkcja robiaca foto dla kamer 1-6
    IEnumerator Capture(int i)
    {
        for (int r = 1; r <= 6; r++)
        {
            yield return new WaitForEndOfFrame();
            switchCam(r);
            yield return new WaitForEndOfFrame();
            TakeAPic(r, i);
        }
        //switchCam(1);
        //cam1.OnPostRender(i);
        //switchCam(2);
        //cam1d.OnPostRender(i);
        //switchCam(3);
        //cam2.OnPostRender(i);
        //switchCam(4);
        //cam2d.OnPostRender(i);
        //switchCam(5);
        //cam3.OnPostRender(i);
        //switchCam(6);
        //cam3d.OnPostRender(i);
    }

    void switchCam (int s)
    {
        camDeactivator();
        if (s == 1)
        {
            cam1.SetActive(true);
            Debug.Log("Kamera 1");
        }
        else if (s == 2)
        {
            cam1d.SetActive(true);
            Debug.Log("Kamera 1d");
        }
        else if (s == 3)
        {
            cam2.SetActive(true);
            Debug.Log("Kamera 2");
        }
        else if (s == 4)
        {
            cam2d.SetActive(true);
            Debug.Log("Kamera 2d");
        }
        else if (s == 5)
        {
            cam3.SetActive(true);
            Debug.Log("Kamera 3");
        }
        else if (s == 6)
        {
            cam3d.SetActive(true);
            Debug.Log("Kamera 3d");
        }

    }

    void camDeactivator()
    {
        cam1.SetActive(false);
        cam1d.SetActive(false);
        cam2.SetActive(false);
        cam2d.SetActive(false);
        cam3.SetActive(false);
        cam3d.SetActive(false);

    }

    void TakeAPic (int a, int b)
    {
        if (a == 1)
        {
            getScreen = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
            getScreen.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, false);
            getScreen.Apply();

            byte[] bytes = getScreen.EncodeToPNG();
            File.WriteAllBytes(@"C:\Users\Jasiek\Documents\UNet\input11\" + ((0*500)+b) + "_1.png", bytes);
        }
        if (a == 2)
        {
            getScreen = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
            getScreen.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, false);
            getScreen.Apply();

            byte[] bytes = getScreen.EncodeToPNG();
            File.WriteAllBytes(@"C:\Users\Jasiek\Documents\UNet\output11\" + ((0*500)+b) + "_1d.png", bytes);
        }
        if (a == 3)
        {
            getScreen = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
            getScreen.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, false);
            getScreen.Apply();

            byte[] bytes = getScreen.EncodeToPNG();
            File.WriteAllBytes(@"C:\Users\Jasiek\Documents\UNet\input11\" + b + "_2.png", bytes);
        }
        if (a == 4)
        {
            getScreen = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
            getScreen.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, false);
            getScreen.Apply();

            byte[] bytes = getScreen.EncodeToPNG();
            File.WriteAllBytes(@"C:\Users\Jasiek\Documents\UNet\output11\" + b + "_2d.png", bytes);
        }
        if (a == 5)
        {
            getScreen = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
            getScreen.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, false);
            getScreen.Apply();

            byte[] bytes = getScreen.EncodeToPNG();
            File.WriteAllBytes(@"C:\Users\Jasiek\Documents\UNet\input11\" + b + "_3.png", bytes);
        }
        if (a == 6)
        {
            getScreen = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
            getScreen.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, false);
            getScreen.Apply();

            byte[] bytes = getScreen.EncodeToPNG();
            File.WriteAllBytes(@"C:\Users\Jasiek\Documents\UNet\output11\" + b + "_3d.png", bytes);
        }
    }

}

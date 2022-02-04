using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class ObjGenerator : MonoBehaviour
{

//skrypt testowy na potrzeby OBjGenerator

    Mesh mesh;

    Vector3[] vertices;
    int[] triangles;

    public int xSize = 20;
    public int zSize = 20;

   


    // Start is called before the first frame update
    public void Start()
    {

        System.Random rndang = new System.Random();
        int ang = rndang.Next(-20, 20);

        //transform.Rotate(270.0f, 180.0f, 270.0f);
        System.Random rnd = new System.Random();
        int l = rnd.Next(1, 7);

        //int l = 6;    //hardkod na probe

        //int l = 4;
        switch (l)
        {
            case 1:             //dinozarl
                mesh = Resources.Load<Mesh>("raptor_01");
                transform.position = new Vector3(0, -0.25f, -6);
                transform.localScale = new Vector3(160.0f, 160.0f, 160.0f);             // done!
                Rotator1(ang);
                break;
            case 2:             //pies
                mesh = Resources.Load<Mesh>("Labrador-Retriever_03");
                transform.position = new Vector3(0, 1, -6);
                transform.localScale = new Vector3(450.0f, 450.0f, 450.0f);             // done!
                Rotator2(ang);
                break;
            case 3:             //jaszczur
                mesh = Resources.Load<Mesh>("little_lizard_01");
                transform.position = new Vector3(1, 1, -6);
                transform.localScale = new Vector3(40.0f, 40.0f, 40.0f);                // done!
                Rotator3(ang);
                break;
            case 4:             //budda
                mesh = Resources.Load<Mesh>("happy-buddha");
                transform.position = new Vector3(0, 0, -6);
                transform.localScale = new Vector3(50.0f, 30.0f, 40.0f);                // done!
                Rotator4(ang);
                break;
            case 5:             //gitara
                mesh = Resources.Load<Mesh>("Guitar_01");
                transform.position = new Vector3(-2, 0, -6);                            // done!
                transform.localScale = new Vector3(4.0f, 4.0f, 4.0f);                
                Rotator5(ang);
                break;
            case 6:             //reka
                mesh = Resources.Load<Mesh>("HandFbx");
                transform.position = new Vector3(2, 0, -6);
                transform.localScale = new Vector3(40.0f, 40.0f, 40.0f);                
                Rotator6(ang);
                break;
        }

            


        GetComponent<MeshFilter>().mesh = mesh;
        //var meshRenderer = mesh.GetComponent<Renderer>();
        //meshRenderer.material.SetColor("_Color", Color.red);
        Debug.Log("Utworzono dinozarla");
        //transform.Rotate(90.0f, 180.0f, 90.0f);
        //Rotator();
        //transform.position = new Vector3(0, 0, -6);
        //transform.Rotate(90.0f, 90.0f, 180.0f);
        //UpdateMesh();
        //Debug.Log(mesh.position);
        //GetComponent<MeshFilter>().mesh = mesh;

    }

    public void Starter()
    {
        
        //CreateShape();
        //UpdateMesh();
    }

    public void CreateShape()
    {
        
    }

    // Update is called once per frame
    public void UpdateMesh()
    {
        //mesh.Clear();

    }

    public void Rotator1(int ang)
    {
        transform.eulerAngles = new Vector3(270, 90+ang, 180);              //dinozarl
    }

    public void Rotator2(int ang)
    {
        transform.eulerAngles = new Vector3(0, 270+ang, 0);              //pies
    }

    public void Rotator3(int ang)
    {
        transform.eulerAngles = new Vector3(180, 0+ang, 90);              //jaszczur
    }

    public void Rotator4(int ang)
    {
        transform.eulerAngles = new Vector3(0, -45+ang, 0);              //budda
    }

    public void Rotator5(int ang)
    {
        transform.eulerAngles = new Vector3(0, 180 + ang, 70);              //gitara
    }

    public void Rotator6(int ang)
    {
        transform.eulerAngles = new Vector3(0, 0 + ang/2, 70);              //reka
    }
}

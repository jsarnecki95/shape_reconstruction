using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour
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

        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        Starter();
        transform.Rotate(90.0f, 270.0f, 90.0f);
        transform.position = new Vector3(2, 3, -6);
        transform.localScale -= new Vector3(0.8f, 0f, 0.8f);

    }

    public void Starter()
    {
        
        CreateShape();
        UpdateMesh();
    }

    public void CreateShape()
    {
        vertices = new Vector3[(xSize + 1) * (zSize + 1)];
        int i = 0;
        for (int z = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {
                //Random rnd = new UnityEngine.Random();
                //int numint = rnd.Next(10);

                //float num = numint / 10;
                //float y = Mathf.PerlinNoise(x * .3f, z * .3f) * 2f; //powierzchnia 'zaszumiona'
                float y = Mathf.PerlinNoise(x * Random.value, z * Random.value) * 0.4f; //powierzchnia 'zaszumiona'
                vertices[i] = new Vector3(x, y, z);
                i++;
            }
        }

        triangles = new int[xSize * zSize * 6];
        int vert = 0;
        int tris = 0;

        for (int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {
                triangles[tris + 0] = vert + 0;
                triangles[tris + 1] = vert + xSize + 1;
                triangles[tris + 2] = vert + 1;
                triangles[tris + 3] = vert + 1;
                triangles[tris + 4] = vert + xSize + 1;
                triangles[tris + 5] = vert + xSize + 2;

                vert++;
                tris += 6;
            }
            vert++;
        }
    }

    // Update is called once per frame
    public void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
        
    }

    public void Rotator()
    {
        transform.Rotate(90.0f, 270.0f, 90.0f);
        transform.localScale += new Vector3(0.8f, 0f, 0.8f);
    }

}

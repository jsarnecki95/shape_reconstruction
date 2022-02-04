using UnityEngine;
using System.Collections;

// ATTACHED ON THE CAMERA

[ExecuteInEditMode]
public class RenderTextureTest : MonoBehaviour
{

    // https://docs.unity3d.com/ScriptReference/Texture2D.ReadPixels.html

    public Material mat;
    public Texture2D tex;

    public RenderTexture ShadowRenderTexture;

    private Camera _camera;

    void Start()
    {
        _camera = GetComponent<Camera>();
        _camera.depthTextureMode = DepthTextureMode.Depth;

        ShadowRenderTexture = _camera.targetTexture;

    }


    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, mat);

        //mat is the material which contains the shader
        //we are passing the destination RenderTexture to
    }
}
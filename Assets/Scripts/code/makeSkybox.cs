using UnityEngine;

public class SkyboxToCubemap : MonoBehaviour
{
    public Camera captureCamera;   // assign in Inspector
    public RenderTexture cubemap;  // assign render texture here

    void Start()
    {
        if (captureCamera != null && cubemap != null)
        {
            captureCamera.RenderToCubemap(cubemap);
            Debug.Log("Cubemap captured!");
        }
    }
}

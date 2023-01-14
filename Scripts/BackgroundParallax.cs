using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    public float speed = 0.005f;
    public Renderer[] sky;

    public JumpMovement jumpMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        jumpMovement.moveParallax += moveLayers;
        foreach (var layer in sky)
        {
            Material m = layer.material;
            m.mainTexture.wrapMode = TextureWrapMode.Repeat;
        }
    }

    private void moveLayers(float x, float y)
    {
        int i = 0;
        foreach (var layer in sky)
        {
            Material m = layer.material;
            m.SetTextureOffset("_MainTex", m.GetTextureOffset("_MainTex") + (new Vector2(x, y) * speed / ((i + 1) * 20.0f)));
            i++;
        }
    }
}

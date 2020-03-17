using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollUV : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        MeshRenderer ar = GetComponent<MeshRenderer>();

        Material mat = ar.material;

        mat.mainTexture.wrapMode = TextureWrapMode.Repeat;

        Vector2 offset = mat.mainTextureOffset;

        offset.x += Time.deltaTime/10f;

        mat.mainTextureOffset = offset;
    }
}

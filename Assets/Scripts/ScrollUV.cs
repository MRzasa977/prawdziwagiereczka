using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollUV : MonoBehaviour
{
    [SerializeField] float scrollingSpeed;

    void Update()
    {
        MeshRenderer ar = GetComponent<MeshRenderer>();

        Material mat = ar.material;

        mat.mainTexture.wrapMode = TextureWrapMode.Repeat;

        Vector2 offset = mat.mainTextureOffset;

        offset.y += Time.deltaTime/ scrollingSpeed;

        mat.mainTextureOffset = offset;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 0.86f;
    [SerializeField] private MeshRenderer mesh;
    
    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * scrollSpeed);
        mesh.material.mainTextureOffset = offset;
    }
}

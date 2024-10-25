using UnityEngine;

public class Background : MonoBehaviour
{
    MeshRenderer m_Renderer;
    public float animationSpeed = 0.05f;

    private void Awake()
    {
        m_Renderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        m_Renderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime,0);

    }
}

using UnityEngine;

public class GOInteraction : MonoBehaviour
{
    [SerializeField]
    private GameObject m_InteriorObject;

    private bool m_IsVisible = false;

    void Start()
    {
        m_InteriorObject.SetActive(false);
    }

    public bool Interaction
    {
        get => m_IsVisible;
        set
        {
            m_IsVisible = !m_IsVisible;
            m_InteriorObject.SetActive(m_IsVisible);
        }
    }
}
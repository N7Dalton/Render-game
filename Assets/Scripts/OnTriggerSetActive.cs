using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerSetActive : MonoBehaviour
{
    // Start is called before the first frame update
    private MeshRenderer m_MeshRenderer;
    void Start()
    {
        m_MeshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainPlayer"))
        {
            m_MeshRenderer.enabled = true;
        }
    }
}

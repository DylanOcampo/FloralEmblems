using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickTest : MonoBehaviour
{
    public Mousepos m_mousepos;
    private void OnMouseOver() {
        m_mousepos.enabled = true;
    }
    private void OnMouseUp() {
        m_mousepos.enabled = false;
    }

    private void OnMouseExit() {
        m_mousepos.enabled = false;
    }
}

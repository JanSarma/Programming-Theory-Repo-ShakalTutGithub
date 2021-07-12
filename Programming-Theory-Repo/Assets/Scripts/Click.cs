using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public Camera GameCamera;
    public Text text;
    
    public void Update()
    {
        HandleSelection();
    }

    public void HandleSelection()
    {
        var ray = GameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && Input.GetButtonDown("Fire1"))
        {
            
            var unit = hit.collider.GetComponent<Unit>();

            var prop = hit.collider.GetComponent <Renderer>();
            
            text.text = $"Object {unit.name} {prop.material.name}";
            //Debug.Log("ok " + m_Selected.name);

        }
    }

}

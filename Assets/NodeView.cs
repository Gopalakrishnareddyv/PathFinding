using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeView : MonoBehaviour
{
    public GameObject tile;

    [Range(0,0.15f)]
    public float borderSIze = 0.15f;

    public void InIt(Node node)
    {
        if (tile != null)
        {
            gameObject.name = "Node (" + node.xIndex + "," + node.yIndex + ")";
            gameObject.transform.position = node.position;
            tile.transform.localScale = new Vector3(1f - borderSIze, 1f, 1f - borderSIze);
            
        }
    }
    public void ColorNode(Color color,GameObject go)
    {
        if (go != null)
        {
            Renderer goRenderor = go.GetComponent<Renderer>();
            if (goRenderor != null)
            {
                goRenderor.sharedMaterial.color = color;
            }
        }
    }
    public void ColorNode(Color color)
    {
        ColorNode(color, tile);
    }
}

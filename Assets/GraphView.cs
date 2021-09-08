using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Graph))]
public class GraphView : MonoBehaviour
{
    public GameObject nodePrefab;
    public Color baseColor = Color.white;
    public Color wallColor = Color.black;

    public void InIt(Graph graph)
    {
        if (graph == null)
        {
            Debug.LogWarning("Graphview is not available");
            return;
        }
        else
        {
            foreach (Node item in graph.nodes)
            {
                GameObject temp= Instantiate(nodePrefab, Vector3.zero, Quaternion.identity);
                NodeView nodeView = temp.GetComponent<NodeView>();
                if (nodeView != null)
                {
                    nodeView.InIt(item);
                    if (item.nodeType == NodeType.Blocked)
                    {
                        //Debug.Log("vhahsdsd");
                        nodeView.ColorNode(wallColor);
                    }
                    else
                    {
                        nodeView.ColorNode(baseColor);
                    }
                }
            }
        }
    }
}

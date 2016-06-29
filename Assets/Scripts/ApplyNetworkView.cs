using UnityEngine;
using System.Collections;

public class ApplyNetworkView : MonoBehaviour
{

    public void addNetworkView()
    {
        Transform[] children = transform.gameObject.GetComponentsInChildren<Transform>();

        for (int i = 0; i < children.Length; i++)
        {
            if (children[i].gameObject.GetComponent<NetworkView>() == null)
            {
                children[i].gameObject.AddComponent<NetworkView>();
                children[i].gameObject.GetComponent<NetworkView>().stateSynchronization = (NetworkStateSynchronization)2;
            }
        }
    }

    public void removeNetworkView()
    {
        Transform[] children = transform.gameObject.GetComponentsInChildren<Transform>();

        for (int i = 0; i < children.Length; i++)
        {
            if (children[i].gameObject.GetComponent<NetworkView>() != null)
            {
                DestroyImmediate(children[i].gameObject.GetComponent<NetworkView>());
            }
        }
    }

}





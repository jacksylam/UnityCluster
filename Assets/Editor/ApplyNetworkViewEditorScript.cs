using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(ApplyNetworkView))]
public class ApplyNetworkViewEditorScript : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ApplyNetworkView myScript = (ApplyNetworkView)target;

        if (GUILayout.Button("Add Network View Components"))
        {
            myScript.addNetworkView();
        }

        if (GUILayout.Button("Remove Network View Components"))
        {
            myScript.removeNetworkView();
        }
    }
}

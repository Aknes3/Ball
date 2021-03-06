using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GlobalPosition : MonoBehaviour
{
    [MenuItem("Debug/Print Global Position")]
     public static void PrintGlobalPosition()
     {
         if (Selection.activeGameObject != null)
         {
             Debug.Log(Selection.activeGameObject.name + " is at " + Selection.activeGameObject.transform.position);
         }
     }
}

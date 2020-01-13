using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MouseCursorController : MonoBehaviour
{
    public Texture2D normalCursor;

    public void ChangeCursor(Texture2D newCursor) {
        Cursor.SetCursor(newCursor, Vector2.zero, CursorMode.Auto);
    }

    [MenuItem("Utilidades/Reset Mouse Cursor")]
    public static void ResetNormalCursor() {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

}

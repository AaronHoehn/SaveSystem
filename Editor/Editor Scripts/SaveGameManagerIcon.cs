using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public static class SaveGameManagerIcon
{
    private static Texture2D icon;

    static SaveGameManagerIcon()
    {
        icon = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/SaveSystemPackage/Editor/EditorResources/SaveIcon.png");
        EditorApplication.hierarchyWindowItemOnGUI += OnHierarchyGUI;
    }

    private static void OnHierarchyGUI(int instanceID, Rect selectionRect)
    {
        GameObject obj = EditorUtility.InstanceIDToObject(instanceID) as GameObject;
        if (obj != null && obj.GetComponent<SaveGameManager>() != null)
        {
            Rect iconRect = new Rect(selectionRect.xMax - 20, selectionRect.y, 16, 16);
            GUI.DrawTexture(iconRect, icon);
        }
    }
}

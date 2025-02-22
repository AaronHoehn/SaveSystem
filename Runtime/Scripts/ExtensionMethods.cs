using UnityEngine;
using System;
using System.Collections.Generic;

public static class ExtensionMethods
{
    #region GameObjects

    /// <summary>
    /// Gets the component of a GameObject. If component does not exist, add component.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="gameObject"></param>
    /// <returns></returns>
    public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        if (component == null) gameObject.AddComponent<T>();
        return component;
    }

    /// <summary>
    /// Check if Gameobjects has a specific component
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="gameObject"></param>
    /// <returns></returns>
    public static bool HasComponent<T>(this GameObject gameObject) where T : Component
    {
        return gameObject.GetComponent<T>() != null;
    }

    #endregion

    #region Remapping

    /// <summary>
    /// Remaps a float from one range to another.
    /// </summary>
    public static float Remap(this float value, float fromMin, float fromMax, float toMin, float toMax)
    {
        float t = Mathf.InverseLerp(fromMin, fromMax, value);
        return Mathf.Lerp(toMin, toMax, t);
    }

    #endregion

    #region RigidBodies

    /// <summary>
    /// Applies the velocity and angular velocity of another Rigidbody to this one.
    /// </summary>
    public static void ApplyForceFrom(this Rigidbody target, Rigidbody source, float multiplier = 1f)
    {
        if (target == null || source == null)
            return;

        target.linearVelocity = source.linearVelocity * multiplier;
        target.angularVelocity = source.angularVelocity * multiplier;
    }

    #endregion

    #region Lists

    /// <summary>
    /// Forces a list to a fixed length (cut when too long, adding default when too short).
    /// </summary>
    public static void ResizeList<T>(this List<T> list, int newCount)
    {
        if (newCount <= 0)
        {
            list.Clear();
        }
        else
        {
            while (list.Count > newCount) list.RemoveAt(list.Count - 1);
            while (list.Count < newCount) list.Add(default(T));
        }
    }

    #endregion
}

using UnityEngine;
using System;

public static class ExtentionFunctions
{
    //
    //  Extention Methots and Generics
    //


    /// <summary>
    /// 
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

    public static bool HasComponent<T>(this GameObject gameObject) where T : Component
    {
        return gameObject.GetComponent<T>() != null;
    }

    public static Component GetOrAddComponent(this GameObject instance, Type type)
        => instance.GetComponent(type) ?? instance.AddComponent(type);
}



public class TestClass : MonoBehaviour
{
    public GameObject go;

    private void Test()
    {
        go.GetOrAddComponent<Rigidbody>();
    }   
}

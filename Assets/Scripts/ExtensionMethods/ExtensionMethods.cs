using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods
{
    // Reset the transformation
    public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = Vector3.one;
    }

    // Move to a certain location
    public static void MoveTo(this Transform source, Vector3 destination , float speed)
    {
        if (source.position != destination)
        {
            source.Translate((destination - source.position).normalized * speed * Time.deltaTime);
        }
        else { source.position = destination; }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Profile", menuName = "Scriptable Objects/Profile")]
public class Profile : ScriptableObject
{
    public Sprite artwork;
    public new string name;
    [TextArea(3, 10)]
    public string description;
}

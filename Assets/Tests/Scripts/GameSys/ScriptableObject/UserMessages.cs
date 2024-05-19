using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MessageList", menuName = "ScriptableObjects/SO_MessageList", order = 1)]

public class SO_MessageList: ScriptableObject
{
    public List<message> messageObjectContainer= new List<message>();
}

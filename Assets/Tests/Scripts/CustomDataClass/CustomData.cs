using System;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class BoquetObject
{
    public string name;
    public  componentType typeOfComponent;
    public List<Meaning> meanings;

    public Meaning currentMeaning;

}

[Serializable]
public class Meaning{
    public string _meaning;
    public Sprite image;
    public meaningType reference;
}

[Serializable]
public enum meaningType{
    Yellow,
    Pink,
    Red, 
    White,
    Blue,
    Purple,
    Small,
    Big,
    Cut,
    UnCut

}

[Serializable]
public enum componentType{
    Plant,
    Paper,
    Ribbon
}

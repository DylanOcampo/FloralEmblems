using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BouquetObject", menuName = "ScriptableObjects/SO_BouquetObject", order = 1)]
public class SO_BouquetList: ScriptableObject
{
    public List<BoquetObject> bouquetObjectContainers= new List<BoquetObject>();
}
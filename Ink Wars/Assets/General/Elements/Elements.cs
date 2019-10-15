using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Element", menuName = "Element")]
public class Elements : ScriptableObject
{
    public Elements[] goodAgainstElements;
    public Elements[] badAgainstElements;
}

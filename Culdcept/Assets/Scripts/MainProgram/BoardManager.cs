using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [field:SerializeField] Transform[] BoardTransforms { get; set; } = new Transform[22];
}

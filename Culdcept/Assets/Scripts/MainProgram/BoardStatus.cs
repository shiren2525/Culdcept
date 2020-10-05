using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardStatus : MonoBehaviour
{
    public int BoardNum { get; set; } = 22;

    public int[] BoardOwners { get; set; } = new int[22];
    public int[] BoardValues { get; set; } = new int[22];
    public int[] BoardLevels { get; set; } = new int[22];
    public int[] BoardAttributes { get; set; } = new int[22];
    public GameObject[] BoardCards { get; set; } = new GameObject[22];
}

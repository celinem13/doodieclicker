using UnityEngine;
using UnityEngine.Events;

public class DoodleCounterManager : MonoBehaviour
{
    public UnityEvent buyDoodleLovers;

    // idk make this the most expensive reward?
    public UnityEvent buyCheric;

    public UnityEvent buyAmericanEagles;

    public UnityEvent buyElephantToothpaste;

    public UnityEvent buySubathon;

    public static int totalDoodles = 0;
}